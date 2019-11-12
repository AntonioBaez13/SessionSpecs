namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingListContact")]
    public partial class MarketingListContact
    {
        public Guid Id { get; set; }

        public Guid MarketingListId { get; set; }

        public Guid ContactId { get; set; }

        public Guid? PrimaryAddressTypeId { get; set; }

        public Guid? SendMethodOverrideId { get; set; }

        public Guid? SendTypeOverrideId { get; set; }

        public Guid? SignatoryId { get; set; }

        public Guid? EmailId { get; set; }

        public bool IsEmailUpdated { get; set; }

        public Guid ExportStatusId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual ContactEmail ContactEmail { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual MarketingList MarketingList { get; set; }

        public virtual User User { get; set; }
    }
}
