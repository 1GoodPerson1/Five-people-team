namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tousu")]
    public partial class tousu
    {
        [Key]
        public int touid { get; set; }

        [Required]
        [StringLength(20)]
        public string touname { get; set; }

        public int toufang { get; set; }

        [Required]
        [StringLength(20)]
        public string toudui { get; set; }

        [Required]
        [StringLength(500)]
        public string touliyou { get; set; }

        public bool? ischu { get; set; }

        [StringLength(500)]
        public string chufang { get; set; }
    }
}
