namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactInstructionView")]
    public partial class ContactInstructionView
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

        [StringLength(81)]
        public string LeadNegotiatorName { get; set; }

        public bool? IsLeadNegotiatorActive { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid NegotiatorId { get; set; }

        public Guid? ContactId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ServiceLineId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTimeOffset CreationTime { get; set; }

        public Guid? DivisionId { get; set; }
    }
}
