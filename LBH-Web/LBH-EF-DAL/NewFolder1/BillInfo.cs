namespace LBH_EF_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        [Key]
        public int BilID { get; set; }

        public int CusID { get; set; }

        public int RooID { get; set; }

        public int CumID { get; set; }

        public int ShopID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cumprice { get; set; }

        public virtual CumrooInfo CumrooInfo { get; set; }

        public virtual CustomInfo CustomInfo { get; set; }

        public virtual RoomInfo RoomInfo { get; set; }

        public virtual ShopInfo ShopInfo { get; set; }
    }
}
