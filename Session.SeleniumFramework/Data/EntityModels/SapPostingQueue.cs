namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SapPostingQueue")]
    public partial class SapPostingQueue
    {
        public Guid Id { get; set; }

        public Guid InstructionId { get; set; }

        public Guid? LastPostingErrorCodeId { get; set; }

        public DateTimeOffset? LastPostingDate { get; set; }

        public string ErrorDescription { get; set; }

        public virtual Instruction Instruction { get; set; }

        public virtual RegistrationStatu RegistrationStatu { get; set; }
    }
}
