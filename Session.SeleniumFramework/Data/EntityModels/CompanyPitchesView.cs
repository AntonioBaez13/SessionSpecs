namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyPitchesView")]
    public partial class CompanyPitchesView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ProjectTitle { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DeadlineDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ResultId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid CompanyId { get; set; }

        [Key]
        [Column(Order = 5)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(81)]
        public string PitchLeadName { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsLeadActive { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string PitchLeadDepartmentName { get; set; }

        public bool? IsFund { get; set; }

        public bool? IsChildCompany { get; set; }
    }
}
