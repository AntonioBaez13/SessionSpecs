namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserFeedLog")]
    public partial class UserFeedLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserFeedLog()
        {
            UserFeedDetails = new HashSet<UserFeedDetail>();
        }

        public Guid Id { get; set; }

        public DateTimeOffset LastRunStartTime { get; set; }

        public DateTimeOffset? LastRunEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFeedDetail> UserFeedDetails { get; set; }
    }
}
