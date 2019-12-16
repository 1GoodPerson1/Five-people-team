namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
   
    [Table("baoxiu")]
    public partial class baoxiu
    {
        [Key]
        
        public int baoid { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("报修人")]
        public string baoname { get; set; }
        [DisplayName("报修房间")]
        public int baofang { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("损坏物品")]
        public string wupin { get; set; }

        [DisplayName("报修时间")]
        
        public DateTime? shijian { get; set; }

        [DisplayName("是否处理")]
        public bool? ischuli { get; set; }
        [DisplayName("处理时间")]
        
        public DateTime? chushijian { get; set; }
    }
}
