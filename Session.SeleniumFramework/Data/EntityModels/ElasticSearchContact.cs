namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchContact")]
    public partial class ElasticSearchContact
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(257)]
        public string FullName { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string FirstNameInitialLetter { get; set; }

        [StringLength(128)]
        public string AlternativeFirstName { get; set; }

        [StringLength(128)]
        public string AlternativeLastName { get; set; }

        [StringLength(128)]
        public string ContactSource { get; set; }

        public bool? IsPodDoNotCall { get; set; }

        public bool? IsSuperRichAdvisor { get; set; }

        public Guid? AgeBandId { get; set; }

        public Guid? NationalityId { get; set; }

        public Guid? PersonalWealthId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonalWealthPrimarySortOrder { get; set; }

        public Guid? ProfessionId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? CreatedByDepartmentId { get; set; }

        public Guid? CreatedByDivisionId { get; set; }

        public Guid? CreatedByBusinessId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CddWarningFlag { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool DataHugOnly { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short HighestDataHugRank { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsDeceased { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KfConnection { get; set; }

        public string Negotiators { get; set; }

        public string ContactCompanies { get; set; }

        public string ContactEmails { get; set; }

        public string ContactPhonesMobile { get; set; }

        public string ContactPhonesNonMobile { get; set; }

        public string ContactProperties { get; set; }

        public string ContactCompanyProperties { get; set; }

        public string ContactPropertyInterests { get; set; }

        public string ContactTypes { get; set; }

        public string ContactPropertyTypesInterests { get; set; }

        [StringLength(128)]
        public string PrimaryBusinessAddressCompanyName { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }

        public string Subscriptions { get; set; }

        public bool? HasEmailConsent { get; set; }

        public bool? HasPostalConsent { get; set; }

        public bool? HasCompleteConsent { get; set; }

        public string ContactToBePhoned { get; set; }

        public bool? HasHomePhoneNumber { get; set; }

        public bool? HasBusinessPhoneNumber { get; set; }

        public string AccessRequests { get; set; }
    }
}
