namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerExportLogContact")]
    public partial class DotmailerExportLogContact
    {
        public Guid Id { get; set; }

        public Guid DotmailerExportLogId { get; set; }

        public Guid ContactId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual DotmailerExportLog DotmailerExportLog { get; set; }
    }
}
