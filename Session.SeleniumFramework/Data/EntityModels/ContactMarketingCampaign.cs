namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactMarketingCampaign")]
    public partial class ContactMarketingCampaign
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        [Column(TypeName = "date")]
        public DateTime CampaignDate { get; set; }

        public int CampaignId { get; set; }

        public string CampaignName { get; set; }

        public string Subject { get; set; }

        public Guid StatusId { get; set; }

        [StringLength(500)]
        public string Sender { get; set; }

        public string MarketingListTitle { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
