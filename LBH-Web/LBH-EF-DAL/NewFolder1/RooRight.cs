namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RooRight")]
    public partial class RooRight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RooRight()
        {
            RoomInfo = new HashSet<RoomInfo>();
        }

        [Key]
        public int RightID { get; set; }

        [Column("RooRight")]
        [Required]
        [StringLength(20)]
        public string RooRight1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomInfo> RoomInfo { get; set; }
    }
}
