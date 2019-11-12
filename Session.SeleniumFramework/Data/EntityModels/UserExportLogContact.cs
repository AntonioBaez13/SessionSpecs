namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserExportLogContact")]
    public partial class UserExportLogContact
    {
        public Guid Id { get; set; }

        public Guid UserExportLogId { get; set; }

        public Guid ContactId { get; set; }

        public string SendMethod { get; set; }

        public string SendType { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual UserExportLog UserExportLog { get; set; }
    }
}
