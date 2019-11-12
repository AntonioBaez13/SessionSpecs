namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PitchDrilldownView")]
    public partial class PitchDrilldownView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PitchId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ProjectTitle { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ResultId { get; set; }

        [StringLength(100)]
        public string ResultLocalised { get; set; }

        public string Company { get; set; }

        public string ServiceLine { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid PitchLeadId { get; set; }

        [StringLength(81)]
        public string PitchLead { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime BriefReceived { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "date")]
        public DateTime Deadline { get; set; }

        public Guid? PitchMemberId { get; set; }

        public Guid? ContactLeadNegotiatorId { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid LocaleId { get; set; }

        public Guid? PitchUserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTimeOffset CreationTime { get; set; }
    }
}
