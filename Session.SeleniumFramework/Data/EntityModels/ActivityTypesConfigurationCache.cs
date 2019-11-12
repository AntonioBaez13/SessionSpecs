namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityTypesConfigurationCache")]
    public partial class ActivityTypesConfigurationCache
    {
        public Guid Id { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid ActivityTypeId { get; set; }

        public Guid ActivityStatusId { get; set; }

        public Guid AgencyTypeId { get; set; }

        public Guid ServiceLineId { get; set; }
    }
}
