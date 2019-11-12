namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructionDrilldownView")]
    public partial class InstructionDrilldownView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string RegistrationReference { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Title { get; set; }

        [StringLength(257)]
        public string Client { get; set; }

        public Guid? ClientId { get; set; }

        [StringLength(32)]
        public string Postcode { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid InstructionStatusId { get; set; }

        public DateTimeOffset? RegistrationDate { get; set; }

        public Guid? RegistrationStatusId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid NegotiatorId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid LocaleId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTimeOffset LastUpdatedDate { get; set; }
    }
}
