namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyInstructionsView")]
    public partial class CompanyInstructionsView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InstructionStatusId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ServiceLineId { get; set; }

        public Guid? CompanyId { get; set; }

        [Key]
        [Column(Order = 4)]
        public string CompanyName { get; set; }

        [StringLength(81)]
        public string LeadNegotiatorName { get; set; }

        public bool? IsLeadNegotiatorActive { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid NegotiatorId { get; set; }

        public bool? IsFund { get; set; }

        public bool? IsChildCompany { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTimeOffset CreationTime { get; set; }

        public Guid? DivisionId { get; set; }
    }
}
