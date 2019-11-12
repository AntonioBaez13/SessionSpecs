namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructionSecurityAttribute")]
    public partial class InstructionSecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid InstructionId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Instruction Instruction { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
