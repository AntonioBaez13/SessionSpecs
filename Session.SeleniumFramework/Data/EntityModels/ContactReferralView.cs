namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactReferralView")]
    public partial class ContactReferralView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string UniqueReferenceCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ContactId { get; set; }

        public Guid? RecipientId { get; set; }

        [StringLength(81)]
        public string RecipientName { get; set; }

        public Guid? ReferrerId { get; set; }

        [StringLength(81)]
        public string ReferrerName { get; set; }

        public Guid? ManagerId { get; set; }

        [StringLength(81)]
        public string ManagerName { get; set; }

        public bool? IsReferrerActive { get; set; }

        public bool? IsRecipientActive { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool OffSystemReferrer { get; set; }

        public string OffSystemReferrerName { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool OffSystemRecipient { get; set; }

        [StringLength(100)]
        public string OffSystemRecipientName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTimeOffset CreationTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid ReferralStatusId { get; set; }

        public string Requirement { get; set; }
    }
}
