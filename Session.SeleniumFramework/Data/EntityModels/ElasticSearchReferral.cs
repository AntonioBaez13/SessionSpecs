namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchReferral")]
    public partial class ElasticSearchReferral
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string UniqueReferenceCode { get; set; }

        public string Requirement { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        [StringLength(33)]
        public string StatusModifiedDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ReferralStatusId { get; set; }

        public Guid? InstructionId { get; set; }

        public string RegistrationReferenceNumber { get; set; }

        public Guid? RateId { get; set; }

        [StringLength(100)]
        public string OffSystemRecipientName { get; set; }

        public string OffSystemReferrerName { get; set; }

        public Guid? OffSystemReferrerCountryId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CountryId { get; set; }

        public Guid? RegistrationSystemId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ExpectingAward { get; set; }

        public decimal? AwardAmount { get; set; }

        public decimal? KfFeeAmount { get; set; }

        public string Contact { get; set; }

        public string Referrer { get; set; }

        public string Recipient { get; set; }

        public string Manager { get; set; }

        public Guid? ServiceLineId { get; set; }

        public Guid? SubServiceLineId { get; set; }
    }
}
