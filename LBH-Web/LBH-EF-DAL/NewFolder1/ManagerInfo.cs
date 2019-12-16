namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagerInfo")]
    public partial class ManagerInfo
    {
        [Key]
        public int ManID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string ManName { get; set; }

        [Required]
        [StringLength(2)]
        public string ManSex { get; set; }

        public int? ManCard { get; set; }

        [Required]
        [StringLength(20)]
        public string ManPhone { get; set; }

        //public virtual UserInfo UserInfo { get; set; }
    }
}
