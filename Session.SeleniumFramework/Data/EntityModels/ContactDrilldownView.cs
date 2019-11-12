namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactDrilldownView")]
    public partial class ContactDrilldownView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NegotiatorId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ContactUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EntityVersion { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short HugRank { get; set; }

        [StringLength(257)]
        public string ContactName { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsDeceased { get; set; }

        [StringLength(128)]
        public string CompanyName { get; set; }

        public bool? AnyCurrentInstructions { get; set; }

        public bool? AnyCurrentReferrals { get; set; }

        public bool? AnyCurrentOwnerships { get; set; }

        public bool? AnyCurrentRequirements { get; set; }

        public bool? AnyCurrentActivities { get; set; }

        public bool? AnyCurrentTenancies { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ToBePhoned { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextCallDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WillFadeDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FadedDate { get; set; }

        public Guid? RelationshipTypeId { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsKeyRelationship { get; set; }

        public string KeyRelationshipStatement { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsTargetRelationship { get; set; }

        public string TargetRelationshipStatement { get; set; }

        [Key]
        [Column(Order = 9)]
        public Guid LocaleId { get; set; }

        public bool? IsAccessRequestStatusPending { get; set; }
    }
}
