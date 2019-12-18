namespace EF.biao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupInfo")]
    public partial class GroupInfo
    {
        [Key]
        public int groupId { get; set; }

        [Required]
        [StringLength(50)]
        public string boyName { get; set; }

        [Required]
        [StringLength(50)]
        public string GirlName { get; set; }

        public DateTime? lovetime { get; set; }

        public bool hand { get; set; }

        public DateTime? SusseccTime { get; set; }
    }
}
