namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SignalR.Messages_0")]
    public partial class Messages_0
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PayloadId { get; set; }

        [Required]
        public byte[] Payload { get; set; }

        public DateTime InsertedOn { get; set; }
    }
}
