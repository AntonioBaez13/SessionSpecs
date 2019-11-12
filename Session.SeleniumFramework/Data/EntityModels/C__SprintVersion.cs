namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__SprintVersion")]
    public partial class C__SprintVersion
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string SprintVersion { get; set; }

        public DateTime? DataExtractAsAt { get; set; }

        public DateTime? MigrationCompletedAt { get; set; }
    }
}
