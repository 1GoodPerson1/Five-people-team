namespace LBH_EF_DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<baoxiu> baoxiu { get; set; }
        public virtual DbSet<BillInfo> BillInfo { get; set; }
        public virtual DbSet<coun> coun { get; set; }
        public virtual DbSet<CumrooInfo> CumrooInfo { get; set; }
        public virtual DbSet<CustomInfo> CustomInfo { get; set; }
        public virtual DbSet<ManagerInfo> ManagerInfo { get; set; }
        public virtual DbSet<RoomInfo> RoomInfo { get; set; }
        public virtual DbSet<RoomNum> RoomNum { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<RooRight> RooRight { get; set; }
        public virtual DbSet<ShopInfo> ShopInfo { get; set; }
        public virtual DbSet<StaffInfo> StaffInfo { get; set; }
        public virtual DbSet<THinguInfo> THinguInfo { get; set; }
        public virtual DbSet<tousu> tousu { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<bt> bt { get; set; }
        public virtual DbSet<StatisticalInfo> StatisticalInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<baoxiu>()
                .Property(e => e.baoname)
                .IsUnicode(false);

            modelBuilder.Entity<baoxiu>()
                .Property(e => e.wupin)
                .IsUnicode(false);

            modelBuilder.Entity<BillInfo>()
                .Property(e => e.Cumprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<coun>()
                .Property(e => e.CType)
                .IsUnicode(false);

            modelBuilder.Entity<CumrooInfo>()
                .Property(e => e.IsDamageInfo)
                .IsUnicode(false);

            modelBuilder.Entity<CumrooInfo>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.CumrooInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomInfo>()
                .Property(e => e.CusName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomInfo>()
                .Property(e => e.CusSex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomInfo>()
                .Property(e => e.CusPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CustomInfo>()
                .Property(e => e.CusBodyId)
                .IsUnicode(false);

            modelBuilder.Entity<CustomInfo>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.CustomInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomInfo>()
                .HasMany(e => e.CumrooInfo)
                .WithRequired(e => e.CustomInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomInfo>()
                .HasMany(e => e.ShopInfo)
                .WithRequired(e => e.CustomInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ManagerInfo>()
                .Property(e => e.ManName)
                .IsUnicode(false);

            modelBuilder.Entity<ManagerInfo>()
                .Property(e => e.ManSex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ManagerInfo>()
                .Property(e => e.ManPhone)
                .IsUnicode(false);

            modelBuilder.Entity<RoomInfo>()
                .Property(e => e.Rooname)
                .IsUnicode(false);

            modelBuilder.Entity<RoomInfo>()
                .Property(e => e.RooPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RoomInfo>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.RoomInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomInfo>()
                .HasMany(e => e.CumrooInfo)
                .WithRequired(e => e.RoomInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomNum>()
                .Property(e => e.RooNum)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.RooType)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.RoomInfo)
                .WithRequired(e => e.RoomType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RooRight>()
                .Property(e => e.RooRight1)
                .IsUnicode(false);

            modelBuilder.Entity<ShopInfo>()
                .Property(e => e.ShopPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShopInfo>()
                .HasMany(e => e.BillInfo)
                .WithRequired(e => e.ShopInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffInfo>()
                .Property(e => e.StaName)
                .IsUnicode(false);

            modelBuilder.Entity<StaffInfo>()
                .Property(e => e.StaSex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StaffInfo>()
                .Property(e => e.StaPhone)
                .IsUnicode(false);

            modelBuilder.Entity<StaffInfo>()
                .Property(e => e.StaCard)
                .IsUnicode(false);

            modelBuilder.Entity<THinguInfo>()
                .Property(e => e.ThiName)
                .IsUnicode(false);

            modelBuilder.Entity<THinguInfo>()
                .Property(e => e.ThiPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<THinguInfo>()
                .HasMany(e => e.ShopInfo)
                .WithRequired(e => e.THinguInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tousu>()
                .Property(e => e.touname)
                .IsUnicode(false);

            modelBuilder.Entity<tousu>()
                .Property(e => e.toudui)
                .IsUnicode(false);

            modelBuilder.Entity<tousu>()
                .Property(e => e.touliyou)
                .IsUnicode(false);

            modelBuilder.Entity<tousu>()
                .Property(e => e.chufang)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.UserPwd)
                .IsUnicode(false);

            //modelBuilder.Entity<UserInfo>()
            //    .HasMany(e => e.ManagerInfo)
            //    .WithRequired(e => e.UserInfo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<UserInfo>()
            //    .HasMany(e => e.StaffInfo)
            //    .WithRequired(e => e.UserInfo)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<bt>()
                .Property(e => e.baoname)
                .IsUnicode(false);

            modelBuilder.Entity<bt>()
                .Property(e => e.wupin)
                .IsUnicode(false);

            modelBuilder.Entity<StatisticalInfo>()
                .Property(e => e.Statistical)
                .HasPrecision(19, 4);
        }
    }
}
