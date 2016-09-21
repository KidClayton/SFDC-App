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
    public class Contact
    {
        [Key]
        [Display(Name = "Contact ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Master Record ID")]
        [Createable(false), Updateable(false)]
        public string MasterRecordId { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(80)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(40)]
        public string FirstName { get; set; }

        public string Salutation { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(121)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Mailing Street")]
        public string MailingStreet { get; set; }

        [Display(Name = "Mailing City")]
        [StringLength(40)]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing State/Province")]
        [StringLength(80)]
        public string MailingState { get; set; }

        [Display(Name = "Mailing Zip/Postal Code")]
        [StringLength(20)]
        public string MailingPostalCode { get; set; }

        [Display(Name = "Mailing Country")]
        [StringLength(80)]
        public string MailingCountry { get; set; }

        [Display(Name = "Mailing Latitude")]
        public double? MailingLatitude { get; set; }

        [Display(Name = "Mailing Longitude")]
        public double? MailingLongitude { get; set; }

        [Display(Name = "Business Phone")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Business Fax")]
        [Phone]
        public string Fax { get; set; }

        [Display(Name = "Mobile Phone")]
        [Phone]
        public string MobilePhone { get; set; }

        [Display(Name = "Reports To ID")]
        public string ReportsToId { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(80)]
        public string Department { get; set; }

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

        [Display(Name = "Last Activity")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastActivityDate { get; set; }

        [Display(Name = "Last Stay-in-Touch Request Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastCURequestDate { get; set; }

        [Display(Name = "Last Stay-in-Touch Save Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastCUUpdateDate { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Email Bounced Reason")]
        [StringLength(255)]
        public string EmailBouncedReason { get; set; }

        [Display(Name = "Email Bounced Date")]
        public DateTimeOffset? EmailBouncedDate { get; set; }

        [Display(Name = "Is Email Bounced")]
        [Createable(false), Updateable(false)]
        public bool IsEmailBounced { get; set; }

        [Display(Name = "Photo URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string PhotoUrl { get; set; }

        [Display(Name = "Jigsaw Contact ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string JigsawContactId { get; set; }

        [Display(Name = "MMSUserID")]
        public double? MMSUserID__c { get; set; }

        [Display(Name = "FFT Expiration Date")]
        public DateTimeOffset? FFT_Expiration_Date__c { get; set; }

        [Display(Name = "FFT Follow Up 1")]
        public bool FFT_Follow_Up_1__c { get; set; }

        [Display(Name = "FFT Follow Up 2")]
        public bool FFT_Follow_Up_2__c { get; set; }

        [Display(Name = "FFT Follow Up Demo")]
        public bool FFT_Follow_Up_Demo__c { get; set; }

        [Display(Name = "FFT Follow Up Expire")]
        public bool FFT_Follow_Up_Expire__c { get; set; }

    }
}
