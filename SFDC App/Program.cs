using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salesforce.Common;
using Salesforce.Force;
using System.Dynamic;

namespace SFDC_Connect_Demo
{
    class Program
    {
        private static readonly string SecToken = ConfigurationManager.AppSettings["Salesforce:SecurityToken"];
        private static readonly string ConsumerKey = ConfigurationManager.AppSettings["Salesforce:ConsumerKey"];
        private static readonly string ConsumerSecret = ConfigurationManager.AppSettings["Salesforce:ConsumerSecret"];
        private static readonly string UN = ConfigurationManager.AppSettings["Salesforce:Username"];
        private static readonly string PW = ConfigurationManager.AppSettings["Salesforce:Password"] + ConfigurationManager.AppSettings["Salesforce:SecurityToken"];
        private static readonly string IsSandBox = ConfigurationManager.AppSettings["Salesforce:IsSandBoxUser"];
        private static readonly string CaseRT = ConfigurationManager.AppSettings["Salesforce:CaseProvisioningRT"];

        static void Main(string[] args)
        {
            try
            {
                var task = ProcessCases();
                task.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        private static async Task ProcessCases()
        {
            // Make the Connection - this is usually absctracted out for apps with many process 
            // and returns the client and exposes a boo if connection is made
            var auth = new AuthenticationClient();
            var url = IsSandBox.Equals("true", StringComparison.CurrentCultureIgnoreCase)
                ? "https://cs2.salesforce.com/services/oauth2/token"
                : "https://login.salesforce.com/services/oauth2/token";

            await auth.UsernamePasswordAsync(ConsumerKey, ConsumerSecret, UN, PW, url);
            //await auth.WebServerAsync(UsernamePasswordAsync(ConsumerKey, ConsumerSecret, UN, PW, url);
            Console.WriteLine("Connected to SFDC");

            var client = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);

            //Now we will get all the cases which are Provision with a status of Requested
            string soqlQry = "SELECT id FROM case WHERE recordtypeid = '" + CaseRT + "' and status = 'Requested'";
            List<SFDC_App.Models.Salesforce.Case> cases = new List<SFDC_App.Models.Salesforce.Case>();
            var results = await client.QueryAsync<SFDC_App.Models.Salesforce.Case>(soqlQry);
            int totalSize = results.TotalSize;
            Console.WriteLine("Queried " + totalSize + " records");

            cases.AddRange(results.Records);
            var nextRecord = results.NextRecordsUrl;

            if (!string.IsNullOrEmpty(nextRecord))
            {
                while (true)
                {
                    var continuationResults = await client.QueryContinuationAsync<SFDC_App.Models.Salesforce.Case>(nextRecord);
                    int NewSize = continuationResults.TotalSize;
                    Console.WriteLine("Queried an additional " + NewSize + " records");
                    cases.AddRange(continuationResults.Records);
                    if (string.IsNullOrEmpty(continuationResults.NextRecordsUrl)) break;
                    nextRecord = continuationResults.NextRecordsUrl;
                }
            }
        }
    }
}

