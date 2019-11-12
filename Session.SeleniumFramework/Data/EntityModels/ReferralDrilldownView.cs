namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferralDrilldownView")]
    public partial class ReferralDrilldownView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string Reference { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid StatusId { get; set; }

        [StringLength(100)]
        public string StatusLocalised { get; set; }

        [StringLength(257)]
        public string Contact { get; set; }

        public Guid? ReferrerId { get; set; }

        public string Referrer { get; set; }

        public Guid? RecipientId { get; set; }

        [StringLength(100)]
        public string Recipient { get; set; }

        public string Requirement { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTimeOffset Sent { get; set; }

        public string LatestNote { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTimeOffset StatusModifiedDate { get; set; }

        public int? DaysSinceLastStatusModification { get; set; }

        public decimal? AwardAmount { get; set; }

        public Guid? AwardCurrencyId { get; set; }

        public bool? CreatedInThisFinancialYear { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid LocaleId { get; set; }
    }
}
