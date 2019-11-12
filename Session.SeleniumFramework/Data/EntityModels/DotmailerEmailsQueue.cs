namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerEmailsQueue")]
    public partial class DotmailerEmailsQueue
    {
        public Guid Id { get; set; }

        public Guid DotmailerEmailTypeId { get; set; }

        public Guid ContactEmailId { get; set; }

        public Guid BusinessId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset ScheduledStartTime { get; set; }

        public DateTimeOffset? ActualStartTime { get; set; }

        public Guid? SignatoryUserId { get; set; }

        public string ErrorLog { get; set; }

        public virtual ContactEmail ContactEmail { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
