namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTemplateRole")]
    public partial class DocumentTemplateRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentTemplateRole()
        {
            DocumentTemplateFields = new HashSet<DocumentTemplateField>();
        }

        public Guid Id { get; set; }

        public Guid DocumentTemplateId { get; set; }

        public Guid TemplateRoleId { get; set; }

        public virtual DocumentTemplate DocumentTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplateField> DocumentTemplateFields { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
