namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchInstruction")]
    public partial class ElasticSearchInstruction
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string ReferenceNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ServiceLineId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid DepartmentId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid InstructionStatusId { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid InstructionTypeId { get; set; }

        public Guid? CddCompleteId { get; set; }

        public bool? IsValuation { get; set; }

        public Guid? ReferralId { get; set; }

        [StringLength(33)]
        public string RegistrationDate { get; set; }

        public string Assets { get; set; }

        public string InstructionAddresses { get; set; }

        public Guid? InstructionRegistrationStatusId { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        public string Negotiator { get; set; }

        public string ContactClient { get; set; }

        public string CompanyClient { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }
    }
}
