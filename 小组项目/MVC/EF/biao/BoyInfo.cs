namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoyInfo")]
    public partial class BoyInfo
    {
        [Key]
        [DisplayName("���")]
        public int boyid { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("����")]
        public string boyName { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("�Ա�")]
        public string boySex { get; set; }

        [DisplayName("����")]
        public int boyAge { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("�ֻ���")]
        public string boyfonle { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("����")]
        public string boymail { get; set; }

        [DisplayName("���")]
        public int boyHeight { get; set; }

        [DisplayName("����")]
        public double boyWeight { get; set; }

        [StringLength(100)]
        [DisplayName("����")]
        public string boyjob { get; set; }

        [DisplayName("н��")]
        public decimal? boyjobMoney { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("סַ")]
        public string boyAddress { get; set; }

        [StringLength(100)]
        [DisplayName("����")]
        public string boyHobbly { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("��ż��׼")]
        public string boymate { get; set; }

        [DisplayName("����1")]
        public string boyimg { get; set; }

        [DisplayName("����2")]
        public string boyimg1 { get; set; }

        [DisplayName("����3")]
        public string boyimg2 { get; set; }
    }
}
