namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SapInstructionUniqueNumber")]
    public partial class SapInstructionUniqueNumber
    {
        [Key]
        public Guid InstructionId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniqueNumber { get; set; }

        public virtual Instruction Instruction { get; set; }
    }
}
