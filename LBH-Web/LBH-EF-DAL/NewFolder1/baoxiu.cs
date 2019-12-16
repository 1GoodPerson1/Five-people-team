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
        [DisplayName("������")]
        public string baoname { get; set; }
        [DisplayName("���޷���")]
        public int baofang { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("����Ʒ")]
        public string wupin { get; set; }

        [DisplayName("����ʱ��")]
        
        public DateTime? shijian { get; set; }

        [DisplayName("�Ƿ���")]
        public bool? ischuli { get; set; }
        [DisplayName("����ʱ��")]
        
        public DateTime? chushijian { get; set; }
    }
}
