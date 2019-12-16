namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CumrooInfo")]
    public partial class CumrooInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CumrooInfo()
        {
            BillInfo = new HashSet<BillInfo>();
        }

        [Key]
        public int CumID { get; set; }

        public int CusID { get; set; }

        public int RooID { get; set; }

        public bool? IsDamage { get; set; }

        [StringLength(100)]
        public string IsDamageInfo { get; set; }

        public DateTime CusDatestart { get; set; }

        public DateTime? CusDateEnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        public virtual CustomInfo CustomInfo { get; set; }

        public virtual RoomInfo RoomInfo { get; set; }
    }
}
