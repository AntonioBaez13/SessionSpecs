namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructionActivity")]
    public partial class InstructionActivity
    {
        public Guid Id { get; set; }

        public Guid InstructionId { get; set; }

        public Guid ActivityId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Instruction Instruction { get; set; }
    }
}
