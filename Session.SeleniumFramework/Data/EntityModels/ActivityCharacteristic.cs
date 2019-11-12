namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityCharacteristic")]
    public partial class ActivityCharacteristic
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid CharacteristicId { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Characteristic Characteristic { get; set; }
    }
}
