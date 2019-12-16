namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffInfo")]
    public partial class StaffInfo
    {
        [Key]
        public int StaID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string StaName { get; set; }

        [Required]
        [StringLength(2)]
        public string StaSex { get; set; }

        [Required]
        [StringLength(20)]
        public string StaPhone { get; set; }

        [Required]
        [StringLength(20)]
        public string StaCard { get; set; }

        public bool? IsWork { get; set; }

        //public virtual UserInfo UserInfo { get; set; }
    }
}
