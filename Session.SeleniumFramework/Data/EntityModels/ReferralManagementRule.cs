namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReferralManagementRule
    {
        public Guid Id { get; set; }

        public Guid? ReferrerCountryId { get; set; }

        public Guid RecipientCountryId { get; set; }

        public Guid? ServiceLineId { get; set; }

        public Guid? RecipientDepartmentId { get; set; }

        public bool CanMakeDirectReferral { get; set; }

        public int OrderOfPrecedence { get; set; }

        public Guid UserId { get; set; }

        public virtual Country Country { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual ServiceLine ServiceLine { get; set; }

        public virtual User User { get; set; }
    }
}
