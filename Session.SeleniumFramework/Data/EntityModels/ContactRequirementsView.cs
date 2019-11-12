namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactRequirementsView")]
    public partial class ContactRequirementsView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RequirementStatusId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid RequirementTypeId { get; set; }

        public Guid? ServiceLineId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTimeOffset CreationTime { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? NegotiatorId { get; set; }

        [StringLength(40)]
        public string NegotiatorFirstName { get; set; }

        [StringLength(40)]
        public string NegotiatorLastName { get; set; }

        public bool? IsNegotiatorActive { get; set; }

        public int? RequirementStatusPrimarySortOrder { get; set; }

        [StringLength(4000)]
        public string Applicants { get; set; }
    }
}
