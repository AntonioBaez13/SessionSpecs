namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchCompany")]
    public partial class ElasticSearchCompany
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        [StringLength(128)]
        public string AlternativeName { get; set; }

        public Guid? HoldingCompanyId { get; set; }

        public Guid? CompanyCategoryId { get; set; }

        public string CompanyCategoryLocalised { get; set; }

        public Guid? ClientCareStatusId { get; set; }

        public string ClientCareStatusLocalised { get; set; }

        [StringLength(2500)]
        public string WebsiteUrl { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Valid { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? CreatedByDepartmentId { get; set; }

        public Guid? CreatedByDivisionId { get; set; }

        public Guid? CreatedByBusinessId { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CddWarningFlag { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short HighestDataHugRank { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool DataHugOnly { get; set; }

        [StringLength(128)]
        public string RegistrationNumber { get; set; }

        public bool? IsChildCompany { get; set; }

        public bool? IsHoldingCompany { get; set; }

        public bool? IsFund { get; set; }

        public bool? IsOwningCompany { get; set; }

        [StringLength(128)]
        public string OwningCompanyName { get; set; }

        public Guid? OwningCompanyId { get; set; }

        public Guid? HoldingOwningCompanyId { get; set; }

        [StringLength(128)]
        public string HierarchySortField { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KfConnection { get; set; }

        public Guid? HeadOfficeLocationId { get; set; }

        public Guid? TenantTypeId { get; set; }

        public Guid? InvestorTypeId { get; set; }

        public string Address { get; set; }

        public string RelationshipManager { get; set; }
    }
}
