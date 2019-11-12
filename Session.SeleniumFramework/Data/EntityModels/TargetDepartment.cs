namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TargetDepartment")]
    public partial class TargetDepartment
    {
        public Guid Id { get; set; }

        public Guid DepartmentId { get; set; }

        public int FinMonth { get; set; }

        public int? ReferralsSent_All { get; set; }

        public int? ReferralsSentAccepted_All { get; set; }

        public int? MarketAppraisals_All { get; set; }

        public int? Instructions_All { get; set; }

        public int? Viewings_All { get; set; }

        public int? Offers_All { get; set; }

        public int? OffersAccepted_All { get; set; }

        public int? Exchanges_All { get; set; }

        public decimal? ExchangeFees_All { get; set; }

        public decimal? KFCommissionPct_All { get; set; }

        public decimal? MAToInstrucionsPct_All { get; set; }

        public int? MarketAppraisals_Core { get; set; }

        public int? Instructions_Core { get; set; }

        public int? Viewings_Core { get; set; }

        public int? Offers_Core { get; set; }

        public int? OffersAccepted_Core { get; set; }

        public int? Exchanges_Core { get; set; }

        public decimal? ExchangeFees_Core { get; set; }

        public decimal? KFCommissionPct_Core { get; set; }

        public decimal? MAToInstrucionsPct_Core { get; set; }

        public int? MarketAppraisals_Prime { get; set; }

        public int? Instructions_Prime { get; set; }

        public int? Viewings_Prime { get; set; }

        public int? Offers_Prime { get; set; }

        public int? OffersAccepted_Prime { get; set; }

        public int? Exchanges_Prime { get; set; }

        public decimal? ExchangeFees_Prime { get; set; }

        public decimal? KFCommissionPct_Prime { get; set; }

        public decimal? MAToInstrucionsPct_Prime { get; set; }
    }
}
