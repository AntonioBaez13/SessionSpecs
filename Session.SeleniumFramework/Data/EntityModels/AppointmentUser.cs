namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppointmentUser")]
    public partial class AppointmentUser
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid AppointmentId { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual User User { get; set; }
    }
}
