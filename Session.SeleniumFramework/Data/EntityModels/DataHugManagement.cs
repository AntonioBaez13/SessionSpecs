namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugManagement")]
    public partial class DataHugManagement
    {
        public Guid Id { get; set; }

        public int PollingIntervalSeconds { get; set; }

        public bool Enabled { get; set; }

        public int MinimumHugRank { get; set; }

        public int EmailAddressBatchSize { get; set; }

        public int ApiRetryThreshold { get; set; }

        public int DbExceptionThreshold { get; set; }
    }
}
