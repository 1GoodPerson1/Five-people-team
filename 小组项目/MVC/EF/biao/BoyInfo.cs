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
        [DisplayName("编号")]
        public int boyid { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("姓名")]
        public string boyName { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("性别")]
        public string boySex { get; set; }

        [DisplayName("年龄")]
        public int boyAge { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("手机号")]
        public string boyfonle { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("邮箱")]
        public string boymail { get; set; }

        [DisplayName("身高")]
        public int boyHeight { get; set; }

        [DisplayName("体重")]
        public double boyWeight { get; set; }

        [StringLength(100)]
        [DisplayName("工作")]
        public string boyjob { get; set; }

        [DisplayName("薪资")]
        public decimal? boyjobMoney { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("住址")]
        public string boyAddress { get; set; }

        [StringLength(100)]
        [DisplayName("爱好")]
        public string boyHobbly { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("择偶标准")]
        public string boymate { get; set; }

        [DisplayName("靓照1")]
        public string boyimg { get; set; }

        [DisplayName("靓照2")]
        public string boyimg1 { get; set; }

        [DisplayName("靓照3")]
        public string boyimg2 { get; set; }
    }
}
