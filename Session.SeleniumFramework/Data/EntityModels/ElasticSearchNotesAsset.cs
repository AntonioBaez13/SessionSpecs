namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchNotesAsset")]
    public partial class ElasticSearchNotesAsset
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string Content { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MainEntityId { get; set; }

        [StringLength(11)]
        public string MainEntityType { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        public Guid? UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        public Guid? RelatedEnumTypeItemId { get; set; }

        public string RelatedEntities { get; set; }
    }
}
