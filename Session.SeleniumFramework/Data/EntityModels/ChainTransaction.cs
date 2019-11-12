namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChainTransaction")]
    public partial class ChainTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChainTransaction()
        {
            ChainTransaction1 = new HashSet<ChainTransaction>();
            ChainTransactionParties = new HashSet<ChainTransactionParty>();
        }

        public Guid Id { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid? RequirementId { get; set; }

        public Guid? ParentId { get; set; }

        public bool IsEnd { get; set; }

        public Guid AssetId { get; set; }

        public string Vendor { get; set; }

        public string Buyer { get; set; }

        public Guid? AgentUserId { get; set; }

        public Guid MortgageId { get; set; }

        public Guid SurveyId { get; set; }

        public Guid SearchesId { get; set; }

        public Guid EnquiriesId { get; set; }

        public Guid ContractAgreedId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SurveyDate { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Asset Asset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransaction> ChainTransaction1 { get; set; }

        public virtual ChainTransaction ChainTransaction2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransactionParty> ChainTransactionParties { get; set; }
    }
}
