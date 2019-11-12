namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressFormEntityType")]
    public partial class AddressFormEntityType
    {
        public Guid Id { get; set; }

        public Guid AddressFormId { get; set; }

        public Guid EnumTypeItemId { get; set; }

        public virtual AddressForm AddressForm { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
