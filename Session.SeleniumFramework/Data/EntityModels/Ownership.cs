namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ownership")]
    public partial class Ownership
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ownership()
        {
            AssetParties = new HashSet<AssetParty>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SellDate { get; set; }

        public Guid AssetId { get; set; }

        public decimal? BuyPrice { get; set; }

        public decimal? SellPrice { get; set; }

        public Guid OwnershipTenureId { get; set; }

        public Guid OwnershipTypeId { get; set; }

        public Guid CurrencyId { get; set; }

        public bool IsNotCurrent { get; set; }

        public bool IsValuation { get; set; }

        public Guid? ValuationUserId { get; set; }

        public Guid? ValuationUserRoleId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetParty> AssetParties { get; set; }
    }
}
