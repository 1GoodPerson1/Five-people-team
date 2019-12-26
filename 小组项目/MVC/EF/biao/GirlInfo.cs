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
        [DisplayName("编号")]
        public int girlid { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("姓名")]
        public string girlName { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("性别")]
        public string girlSex { get; set; }

        [DisplayName("年龄")]
        public int girlAge { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("手机号")]
        public string girfonle { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("邮箱")]
        public string girmail { get; set; }

        [DisplayName("身高")]
        public int girlHeight { get; set; }

        [DisplayName("体重")]
        public double girlWeight { get; set; }

        [StringLength(100)]
        [DisplayName("工作")]
        public string girljob { get; set; }

        [DisplayName("薪资")]
        public decimal? girljobMoney { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("住址")]
        public string girlAddress { get; set; }

        [StringLength(100)]
        [DisplayName("爱好")]
        public string girlHobbly { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("择偶标准")]
        public string girlmate { get; set; }

        public string girlimg { get; set; }

        public string girlimg1 { get; set; }

        public string girlimg2 { get; set; }
    }
}
