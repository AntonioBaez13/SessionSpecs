namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchNotesContact")]
    public partial class ElasticSearchNotesContact
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public string Content { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MainEntityId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(7)]
        public string MainEntityType { get; set; }

        public string VisibleClaims { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        public Guid? UserId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Deleted { get; set; }

        public Guid? RelatedEnumTypeItemId { get; set; }

        public string RelatedEntities { get; set; }
    }
}
