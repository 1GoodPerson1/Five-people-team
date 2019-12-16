namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoyInfo")]
    public partial class BoyInfo
    {
        [Key]
        public int boyid { get; set; }

        [Required]
        [StringLength(20)]
        public string boyName { get; set; }

        [Required]
        [StringLength(2)]
        public string boySex { get; set; }

        public int boyAge { get; set; }

        public int boyHeight { get; set; }

        public double boyWeight { get; set; }

        [StringLength(100)]
        public string boyjob { get; set; }

        public decimal? boyjobMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string boyAddress { get; set; }

        [StringLength(100)]
        public string boyHobbly { get; set; }

        [Required]
        [StringLength(500)]
        public string boymate { get; set; }

        public string boyimg { get; set; }

        public string boyimg1 { get; set; }

        public string boyimg2 { get; set; }
    }
}
