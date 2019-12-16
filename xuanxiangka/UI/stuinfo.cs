namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stuinfo")]
    public partial class stuinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stuinfo()
        {
            word = new HashSet<word>();
            zhunbei = new HashSet<zhunbei>();
        }

        [Key]
        public int sid { get; set; }

        [Required]
        [StringLength(20)]
        public string sname { get; set; }

        [Required]
        [StringLength(2)]
        public string sex { get; set; }

        public int? classid { get; set; }

        public int age { get; set; }

        public virtual _class _class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<word> word { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zhunbei> zhunbei { get; set; }
    }
}
