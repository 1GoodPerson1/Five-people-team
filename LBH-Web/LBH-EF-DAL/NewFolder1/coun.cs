namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coun")]
    public partial class coun
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string CType { get; set; }

        public int Cvalue { get; set; }
    }
}
