namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyContactsView")]
    public partial class CompanyContactsView
    {
        public Guid? Id { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ContactId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompanyId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string CompanyName { get; set; }

        [StringLength(257)]
        public string ContactName { get; set; }

        [StringLength(128)]
        public string ContactFirstName { get; set; }

        [StringLength(128)]
        public string ContactLastName { get; set; }

        [StringLength(128)]
        public string JobTitle { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ContactDatahugRank { get; set; }

        public DateTimeOffset? ContactLastInteractionDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ContactIsDatahugOnly { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsDeceased { get; set; }

        [StringLength(128)]
        public string PrimaryBusinessPhone { get; set; }

        [StringLength(128)]
        public string PrimaryHomePhone { get; set; }

        [StringLength(128)]
        public string PrimaryMobilePhone { get; set; }

        [StringLength(128)]
        public string PrimaryEmail { get; set; }

        [StringLength(81)]
        public string NegotiatorName { get; set; }

        [StringLength(255)]
        public string NegotiatorDepartment { get; set; }

        public bool? NegotiatorActive { get; set; }
    }
}
