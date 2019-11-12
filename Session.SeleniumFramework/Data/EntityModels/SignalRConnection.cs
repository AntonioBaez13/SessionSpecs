namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SignalRConnection")]
    public partial class SignalRConnection
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public string ConnectionId { get; set; }

        public DateTimeOffset DateRegistered { get; set; }

        public virtual User User { get; set; }
    }
}
