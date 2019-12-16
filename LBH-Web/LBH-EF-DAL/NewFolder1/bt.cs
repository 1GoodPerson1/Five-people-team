namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bt")]
    public partial class bt
    {
        public long? op { get; set; }

        [Key]
        [Column(Order = 0)]
        public int baoid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string baoname { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int baofang { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string wupin { get; set; }

        public DateTime? shijian { get; set; }

        public bool? ischuli { get; set; }

        public DateTime? chushijian { get; set; }
    }
}
