namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zhunbei")]
    public partial class zhunbei
    {
        [Key]
        public int zid { get; set; }

        public int? sid { get; set; }

        [StringLength(50)]
        public string zstatic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? wtime { get; set; }

        public virtual stuinfo stuinfo { get; set; }
    }
}
