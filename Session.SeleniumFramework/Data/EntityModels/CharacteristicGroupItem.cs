namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CharacteristicGroupItem")]
    public partial class CharacteristicGroupItem
    {
        public Guid Id { get; set; }

        public Guid CharacteristicId { get; set; }

        public Guid CharacteristicGroupUsageId { get; set; }

        public virtual Characteristic Characteristic { get; set; }

        public virtual CharacteristicGroupUsage CharacteristicGroupUsage { get; set; }
    }
}
