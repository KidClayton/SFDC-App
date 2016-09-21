using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDC_App.Models.Salesforce
{
    public class Case
    {
        [Key]
        [Display(Name = "Case ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Case Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string CaseNumber { get; set; }

        [Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Name")]
        [StringLength(80)]
        public string SuppliedName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string SuppliedEmail { get; set; }

        [Display(Name = "Phone")]
        [StringLength(40)]
        public string SuppliedPhone { get; set; }

        [Display(Name = "Company")]
        [StringLength(80)]
        public string SuppliedCompany { get; set; }

        [Display(Name = "Case Type")]
        public string Type { get; set; }

        [Display(Name = "Record Type ID")]
        public string RecordTypeId { get; set; }

        public string Status { get; set; }

        [Display(Name = "Case Reason")]
        public string Reason { get; set; }

        [Display(Name = "Case Origin")]
        public string Origin { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        public string Priority { get; set; }

        public string Description { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "Closed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ClosedDate { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Reason for Contact")]
        public string Reason_for_Contact__c { get; set; }

        [Display(Name = "Customer Temperment")]
        public string Customer_Temperment__c { get; set; }

        [Display(Name = "Provisioning Action")]
        public string Provsioning_Action__c { get; set; }

        [Display(Name = "Search Key Words")]
        public string Search_Key_Words__c { get; set; }

        [Display(Name = "User Id")]
        [StringLength(25)]
        public string User_Id__c { get; set; }

        [Display(Name = "New End Date")]
        public DateTimeOffset? New_End_Date__c { get; set; }

        [Display(Name = "User Password")]
        public string User_Password__c { get; set; }

        [Display(Name = "Error Message")]
        public string Error_Message__c { get; set; }

        [Display(Name = "Error Code")]
        [StringLength(10)]
        public string Error_Code__c { get; set; }

    }
}
