namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pitch")]
    public partial class Pitch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pitch()
        {
            PitchSecurityAttributes = new HashSet<PitchSecurityAttribute>();
            PitchUsers = new HashSet<PitchUser>();
            Companies = new HashSet<Company>();
            Instructions = new HashSet<Instruction>();
            ServiceLines = new HashSet<ServiceLine>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string ProjectTitle { get; set; }

        public string InstructionOverview { get; set; }

        [Column(TypeName = "date")]
        public DateTime BriefReceivedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeadlineDate { get; set; }

        public Guid ResultId { get; set; }

        public bool Confidential { get; set; }

        public string Costs { get; set; }

        public string AdditionalInfo { get; set; }

        public string Debrief { get; set; }

        public string Outcome { get; set; }

        public bool HasDocuments { get; set; }

        public decimal? ActualFeeAmount { get; set; }

        public Guid? PotentialFeeIncomeId { get; set; }

        public bool Deleted { get; set; }

        public int Version { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual FeeIncome FeeIncome { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PitchSecurityAttribute> PitchSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PitchUser> PitchUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLine> ServiceLines { get; set; }
    }
}
