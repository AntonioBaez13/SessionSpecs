namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactUser")]
    public partial class ContactUser
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid? RelationshipTypeId { get; set; }

        public bool IsKeyRelationship { get; set; }

        public string KeyRelationshipStatement { get; set; }

        public bool IsTargetRelationship { get; set; }

        public string TargetRelationshipStatement { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WillFadeDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FadedDate { get; set; }

        public short HighestDataHugRank { get; set; }

        public DateTimeOffset? LatestLastInteractionDate { get; set; }

        public Guid UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual User User { get; set; }
    }
}
