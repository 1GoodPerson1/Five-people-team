namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomInfo")]
    public partial class RoomInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomInfo()
        {
            BillInfo = new HashSet<BillInfo>();
            CumrooInfo = new HashSet<CumrooInfo>();
        }

        [Key]
        public int RooID { get; set; }

        public int RTypeID { get; set; }

        public int? NumID { get; set; }

        public int? RightID { get; set; }

        [Required]
        [StringLength(50)]
        public string Rooname { get; set; }

        [Column(TypeName = "money")]
        public decimal RooPrice { get; set; }

        public bool? IsRoo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumrooInfo> CumrooInfo { get; set; }

        public virtual RoomNum RoomNum { get; set; }

        public virtual RooRight RooRight { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
