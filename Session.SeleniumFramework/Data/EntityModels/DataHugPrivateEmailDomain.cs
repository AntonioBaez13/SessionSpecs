namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugPrivateEmailDomain")]
    public partial class DataHugPrivateEmailDomain
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Domain { get; set; }
    }
}
