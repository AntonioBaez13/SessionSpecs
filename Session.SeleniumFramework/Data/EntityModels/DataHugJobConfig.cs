namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugJobConfig")]
    public partial class DataHugJobConfig
    {
        public Guid Id { get; set; }

        public int DayOfWeek { get; set; }

        public bool RunInFullMode { get; set; }
    }
}
