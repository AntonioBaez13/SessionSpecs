namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerImportedCampaign")]
    public partial class DotmailerImportedCampaign
    {
        public Guid Id { get; set; }

        public int CampaignId { get; set; }
    }
}
