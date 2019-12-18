namespace EF.biao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loginUser")]
    public partial class loginUser
    {
        [Key]
        public int Userid { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(100)]
        public string userPwd { get; set; }

        public bool? Userinfo { get; set; }
    }
}
