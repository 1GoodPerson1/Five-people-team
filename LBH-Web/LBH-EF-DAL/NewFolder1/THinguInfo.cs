namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THinguInfo")]
    public partial class THinguInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THinguInfo()
        {
            ShopInfo = new HashSet<ShopInfo>();
        }

        [Key]
        public int ThiID { get; set; }

        [Required]
        [StringLength(50)]
        public string ThiName { get; set; }

        [Column(TypeName = "money")]
        public decimal ThiPrice { get; set; }

        public int ThiNum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopInfo> ShopInfo { get; set; }
    }
}
