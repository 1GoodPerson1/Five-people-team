namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("word")]
    public partial class word
    {
        [Key]
        public int wid { get; set; }

        public int? sid { get; set; }

        [StringLength(20)]
        public string wname { get; set; }

        [Column(TypeName = "money")]
        public decimal? wmoney { get; set; }

        public virtual stuinfo stuinfo { get; set; }
    }
}
