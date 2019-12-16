namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatisticalInfo")]
    public partial class StatisticalInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatisticalNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? Statistical { get; set; }

        public DateTime? StatisticalDate { get; set; }
    }
}
