namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistrationSystem")]
    public partial class RegistrationSystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistrationSystem()
        {
            Instructions = new HashSet<Instruction>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public Guid? ReferralRegistrationSystemId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }
    }
}
