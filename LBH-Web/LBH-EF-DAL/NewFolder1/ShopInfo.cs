namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopInfo")]
    public partial class ShopInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopInfo()
        {
            BillInfo = new HashSet<BillInfo>();
        }

        [Key]
        public int ShopID { get; set; }

        public int CusID { get; set; }

        public int ThiID { get; set; }

        public int ShopNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShopPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfo { get; set; }

        public virtual CustomInfo CustomInfo { get; set; }

        public virtual THinguInfo THinguInfo { get; set; }
    }
}
