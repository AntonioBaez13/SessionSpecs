namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Offer")]
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            Activities = new HashSet<Activity>();
            Notifications = new HashSet<Notification>();
            OfferParties = new HashSet<OfferParty>();
            OfferPropertyAreas = new HashSet<OfferPropertyArea>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }

        public Guid OfferTypeId { get; set; }

        public Guid StatusId { get; set; }

        public Guid? MortgageStatusId { get; set; }

        public Guid? MortgageSurveyStatusId { get; set; }

        public Guid? FinancialPositionId { get; set; }

        public Guid? SearchStatusId { get; set; }

        public Guid? EnquiriesId { get; set; }

        public Guid? AdditionalSurveyStatusId { get; set; }

        public Guid? RequirementId { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? NegotiatorId { get; set; }

        public Guid? NegotiatorDepartmentId { get; set; }

        public bool ContractApproved { get; set; }

        public bool? DepositSent { get; set; }

        public int? MortgageLoanToValue { get; set; }

        public decimal? Price { get; set; }

        public decimal? ReservationAmount { get; set; }

        public decimal? PricePerWeek { get; set; }

        public decimal? AgreedPrice { get; set; }

        public Guid? AgreedCapitalValueId { get; set; }

        public decimal? ParkingPrice { get; set; }

        public decimal? PricePerMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OfferDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExchangeDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProposedTenancyStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MortgageSurveyDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AdditionalSurveyDate { get; set; }

        public string SpecialConditions { get; set; }

        public string ProgressComment { get; set; }

        public bool? IsHidden { get; set; }

        public Guid? AgentTypeId { get; set; }

        public decimal? AmountPA { get; set; }

        public Guid? AmountMinId { get; set; }

        public Guid? AmountMaxId { get; set; }

        public Guid? AgentUserId { get; set; }

        public bool IsNoteOfInterest { get; set; }

        public bool External { get; set; }

        public bool Deleted { get; set; }

        public int Version { get; set; }

        public Guid CurrencyId { get; set; }

        public Guid? ResponsibleForSaleCompanyId { get; set; }

        public Guid? LeaseTermPeriodTypeId { get; set; }

        public int? LeaseTermPeriod { get; set; }

        public Guid? DurationTypeId { get; set; }

        public Guid? OfferAgreementTypeId { get; set; }

        public Guid? RentFrequencyId { get; set; }

        public bool? HavePets { get; set; }

        public bool? AreSmokers { get; set; }

        public bool IsAreaBreakdownInAcres { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public Guid? PropertyArea_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Company Company { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual EnumTypeItem EnumTypeItem5 { get; set; }

        public virtual EnumTypeItem EnumTypeItem6 { get; set; }

        public virtual EnumTypeItem EnumTypeItem7 { get; set; }

        public virtual EnumTypeItem EnumTypeItem8 { get; set; }

        public virtual EnumTypeItem EnumTypeItem9 { get; set; }

        public virtual EnumTypeItem EnumTypeItem10 { get; set; }

        public virtual EnumTypeItem EnumTypeItem11 { get; set; }

        public virtual EnumTypeItem EnumTypeItem12 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        public virtual OfferType OfferType { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual PropertyArea PropertyArea { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual User User4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferParty> OfferParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferPropertyArea> OfferPropertyAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
