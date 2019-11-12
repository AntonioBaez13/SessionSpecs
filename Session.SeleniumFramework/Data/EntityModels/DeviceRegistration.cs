namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceRegistration")]
    public partial class DeviceRegistration
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid LocaleId { get; set; }

        [Required]
        [StringLength(255)]
        public string DeviceToken { get; set; }

        public Guid DeviceOsId { get; set; }

        [Required]
        [StringLength(10)]
        public string FullLocale { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual User User { get; set; }
    }
}
