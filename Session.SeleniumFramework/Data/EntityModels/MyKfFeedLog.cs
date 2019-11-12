namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyKfFeedLog")]
    public partial class MyKfFeedLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyKfFeedLog()
        {
            MyKfFeedDetails = new HashSet<MyKfFeedDetail>();
        }

        public Guid Id { get; set; }

        public DateTimeOffset LastRunStartTime { get; set; }

        public DateTimeOffset? LastRunEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyKfFeedDetail> MyKfFeedDetails { get; set; }
    }
}
