namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeeSplit")]
    public partial class FeeSplit
    {
        public Guid Id { get; set; }

        public decimal? FeeValue { get; set; }

        public decimal? ShareOfFee { get; set; }

        public decimal? FeePercentage { get; set; }

        public Guid FeeGroupId { get; set; }

        public Guid? FeeTakenFromId { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid? TenancyId { get; set; }

        public Guid? RequirementId { get; set; }

        public Guid? NegotiatorId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? PartyContactId { get; set; }

        public Guid? PartyCompanyId { get; set; }

        public Guid? PartyAddressId { get; set; }

        public Guid? PartyRoleId { get; set; }

        public string PartyOtherName { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Address Address { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        public virtual User User { get; set; }
    }
}
