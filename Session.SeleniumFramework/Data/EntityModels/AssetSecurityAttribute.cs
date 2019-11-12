namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssetSecurityAttribute")]
    public partial class AssetSecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid AssetId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
