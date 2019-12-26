namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GirlInfo")]
    public partial class GirlInfo
    {
        [Key]
        [DisplayName("���")]
        public int girlid { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("����")]
        public string girlName { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("�Ա�")]
        public string girlSex { get; set; }

        [DisplayName("����")]
        public int girlAge { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("�ֻ���")]
        public string girfonle { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("����")]
        public string girmail { get; set; }

        [DisplayName("���")]
        public int girlHeight { get; set; }

        [DisplayName("����")]
        public double girlWeight { get; set; }

        [StringLength(100)]
        [DisplayName("����")]
        public string girljob { get; set; }

        [DisplayName("н��")]
        public decimal? girljobMoney { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("סַ")]
        public string girlAddress { get; set; }

        [StringLength(100)]
        [DisplayName("����")]
        public string girlHobbly { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("��ż��׼")]
        public string girlmate { get; set; }

        public string girlimg { get; set; }

        public string girlimg1 { get; set; }

        public string girlimg2 { get; set; }
    }
}
