namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyManagementContact")]
    public partial class PropertyManagementContact
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid AssetId { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
