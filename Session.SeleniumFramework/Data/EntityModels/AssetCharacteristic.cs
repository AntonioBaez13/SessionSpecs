namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssetCharacteristic")]
    public partial class AssetCharacteristic
    {
        public Guid Id { get; set; }

        public Guid AssetId { get; set; }

        public Guid CharacteristicId { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Characteristic Characteristic { get; set; }
    }
}
