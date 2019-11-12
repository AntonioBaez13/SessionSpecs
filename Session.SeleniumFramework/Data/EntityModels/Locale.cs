namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locale")]
    public partial class Locale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locale()
        {
            ActivityLocaliseds = new HashSet<ActivityLocalised>();
            ActivityTypeLocaliseds = new HashSet<ActivityTypeLocalised>();
            AgeBandLocaliseds = new HashSet<AgeBandLocalised>();
            Attachments = new HashSet<Attachment>();
            BusinessLanguages = new HashSet<BusinessLanguage>();
            CharacteristicGroupLocaliseds = new HashSet<CharacteristicGroupLocalised>();
            CharacteristicLocaliseds = new HashSet<CharacteristicLocalised>();
            ContactTitles = new HashSet<ContactTitle>();
            CountryLocaliseds = new HashSet<CountryLocalised>();
            DeviceRegistrations = new HashSet<DeviceRegistration>();
            DocumentTemplates = new HashSet<DocumentTemplate>();
            EnumLocaliseds = new HashSet<EnumLocalised>();
            FeeIncomeLocaliseds = new HashSet<FeeIncomeLocalised>();
            FlexibleReports = new HashSet<FlexibleReport>();
            LocaleLocaliseds = new HashSet<LocaleLocalised>();
            LocaleLocaliseds1 = new HashSet<LocaleLocalised>();
            NationalityLocaliseds = new HashSet<NationalityLocalised>();
            OfferTypeLocaliseds = new HashSet<OfferTypeLocalised>();
            ProfessionLocaliseds = new HashSet<ProfessionLocalised>();
            PropertyTypeLocaliseds = new HashSet<PropertyTypeLocalised>();
            RegistrationStatusLocaliseds = new HashSet<RegistrationStatusLocalised>();
            ReportGroupLocaliseds = new HashSet<ReportGroupLocalised>();
            ReportLocaliseds = new HashSet<ReportLocalised>();
            RequirementTypeLocaliseds = new HashSet<RequirementTypeLocalised>();
            ServiceLineLocaliseds = new HashSet<ServiceLineLocalised>();
            TenancyTypeLocaliseds = new HashSet<TenancyTypeLocalised>();
            TranslationLocaliseds = new HashSet<TranslationLocalised>();
            Users = new HashSet<User>();
            WindowsTimeZoneLocaliseds = new HashSet<WindowsTimeZoneLocalised>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(2)]
        public string IsoCode { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLocalised> ActivityLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityTypeLocalised> ActivityTypeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgeBandLocalised> AgeBandLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessLanguage> BusinessLanguages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupLocalised> CharacteristicGroupLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicLocalised> CharacteristicLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactTitle> ContactTitles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryLocalised> CountryLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceRegistration> DeviceRegistrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnumLocalised> EnumLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeIncomeLocalised> FeeIncomeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlexibleReport> FlexibleReports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaleLocalised> LocaleLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaleLocalised> LocaleLocaliseds1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NationalityLocalised> NationalityLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferTypeLocalised> OfferTypeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionLocalised> ProfessionLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyTypeLocalised> PropertyTypeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationStatusLocalised> RegistrationStatusLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportGroupLocalised> ReportGroupLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportLocalised> ReportLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementTypeLocalised> RequirementTypeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLineLocalised> ServiceLineLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyTypeLocalised> TenancyTypeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranslationLocalised> TranslationLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WindowsTimeZoneLocalised> WindowsTimeZoneLocaliseds { get; set; }
    }
}
