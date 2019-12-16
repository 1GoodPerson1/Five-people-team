namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomInfo")]
    public partial class CustomInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomInfo()
        {
            BillInfo = new HashSet<BillInfo>();
            CumrooInfo = new HashSet<CumrooInfo>();
            ShopInfo = new HashSet<ShopInfo>();
        }

        [Key]
        public int CusID { get; set; }

        [Required]
        [StringLength(20)]
        public string CusName { get; set; }

        [Required]
        [StringLength(2)]
        public string CusSex { get; set; }

        [Required]
        [StringLength(20)]
        public string CusPhone { get; set; }

        [Required]
        [StringLength(20)]
        public string CusBodyId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumrooInfo> CumrooInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopInfo> ShopInfo { get; set; }
    }
}
