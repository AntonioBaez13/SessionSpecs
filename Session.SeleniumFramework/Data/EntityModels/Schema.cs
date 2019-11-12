namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SignalR.Schema")]
    public partial class Schema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchemaVersion { get; set; }
    }
}
