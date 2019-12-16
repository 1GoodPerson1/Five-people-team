namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GirlInfo")]
    public partial class GirlInfo
    {
        [Key]
        public int girlid { get; set; }

        [Required]
        [StringLength(20)]
        public string girlName { get; set; }

        [Required]
        [StringLength(2)]
        public string girlSex { get; set; }

        public int girlAge { get; set; }

        public int girlHeight { get; set; }

        public double girlWeight { get; set; }

        [StringLength(100)]
        public string girljob { get; set; }

        public decimal? girljobMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string girlAddress { get; set; }

        [StringLength(100)]
        public string girlHobbly { get; set; }

        [Required]
        [StringLength(500)]
        public string girlmate { get; set; }

        public string girlimg { get; set; }

        public string girlimg1 { get; set; }

        public string girlimg2 { get; set; }
    }
}
