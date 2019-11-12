namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressFieldDefinition")]
    public partial class AddressFieldDefinition
    {
        public Guid Id { get; set; }

        public Guid AddressFieldId { get; set; }

        public Guid AddressFieldLabelId { get; set; }

        public Guid AddressFormId { get; set; }

        public bool Required { get; set; }

        [StringLength(50)]
        public string RegEx { get; set; }

        public short RowOrder { get; set; }

        public short ColumnOrder { get; set; }

        public short ColumnSize { get; set; }

        [StringLength(1)]
        public string Separator { get; set; }

        public bool SpaceAfter { get; set; }

        public virtual AddressField AddressField { get; set; }

        public virtual AddressFieldLabel AddressFieldLabel { get; set; }

        public virtual AddressForm AddressForm { get; set; }
    }
}
