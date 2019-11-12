namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructionRequirement")]
    public partial class InstructionRequirement
    {
        public Guid Id { get; set; }

        public Guid InstructionId { get; set; }

        public Guid RequirementId { get; set; }

        public virtual Instruction Instruction { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
