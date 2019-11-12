namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppointmentOtherAttendee")]
    public partial class AppointmentOtherAttendee
    {
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }

        public Guid ChannelTypeId { get; set; }

        [Required]
        [StringLength(128)]
        public string ChannelValue { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
