namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTemplate")]
    public partial class DocumentTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentTemplate()
        {
            Attachments = new HashSet<Attachment>();
            DocumentTemplateRoles = new HashSet<DocumentTemplateRole>();
            OrganisationUnits = new HashSet<OrganisationUnit>();
            OrganisationUnits1 = new HashSet<OrganisationUnit>();
            EnumTypeItems = new HashSet<EnumTypeItem>();
            EnumTypeItems1 = new HashSet<EnumTypeItem>();
            EnumTypeItems2 = new HashSet<EnumTypeItem>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Code { get; set; }

        public bool? SigningRequired { get; set; }

        public Guid TemplateTypeId { get; set; }

        public Guid? TemplateSubtypeId { get; set; }

        public Guid? EntityTypeId { get; set; }

        public Guid? TargetEntityTypeId { get; set; }

        public Guid? AgencyTypeId { get; set; }

        public Guid? DocumentTypeId { get; set; }

        public Guid? LanguageId { get; set; }

        public Guid? CompanyId { get; set; }

        public string Subject { get; set; }

        [StringLength(128)]
        public string FileName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual Company Company { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual EnumTypeItem EnumTypeItem5 { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual DocumentTemplateContent DocumentTemplateContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplateRole> DocumentTemplateRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnumTypeItem> EnumTypeItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnumTypeItem> EnumTypeItems1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnumTypeItem> EnumTypeItems2 { get; set; }
    }
}
