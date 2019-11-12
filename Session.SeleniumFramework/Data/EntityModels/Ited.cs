namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ited")]
    public partial class Ited
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Cc { get; set; }

        [StringLength(50)]
        public string Ndc { get; set; }

        [StringLength(50)]
        public string Iso { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }
    }
}
