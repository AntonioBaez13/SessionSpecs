namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructionAsset")]
    public partial class InstructionAsset
    {
        public Guid Id { get; set; }

        public Guid InstructionId { get; set; }

        public Guid AssetId { get; set; }

        public bool IsPrimary { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Instruction Instruction { get; set; }
    }
}
