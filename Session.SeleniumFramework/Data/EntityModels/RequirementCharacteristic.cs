namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementCharacteristic")]
    public partial class RequirementCharacteristic
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid CharacteristicId { get; set; }

        public string Text { get; set; }

        public virtual Characteristic Characteristic { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
