namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppointmentContact")]
    public partial class AppointmentContact
    {
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }

        public Guid ChannelTypeId { get; set; }

        [StringLength(128)]
        public string ChannelValue { get; set; }

        public Guid? PartyRoleTypeId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? ContactId { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }
    }
}
