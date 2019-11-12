namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementParty")]
    public partial class RequirementParty
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        [StringLength(255)]
        public string GenericDescription { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid RoleId { get; set; }

        public string OtherName { get; set; }

        [StringLength(3)]
        public string Discriminator { get; set; }

        public virtual Address Address { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
