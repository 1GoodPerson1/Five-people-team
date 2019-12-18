namespace EF.biao
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<BoyInfo> BoyInfo { get; set; }
        public virtual DbSet<GirlInfo> GirlInfo { get; set; }
        public virtual DbSet<GroupInfo> GroupInfo { get; set; }
        public virtual DbSet<loginUser> loginUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyName)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boySex)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyfonle)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boymail)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyjob)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyHobbly)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boymate)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyimg)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyimg1)
                .IsUnicode(false);

            modelBuilder.Entity<BoyInfo>()
                .Property(e => e.boyimg2)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlName)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlSex)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girfonle)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girmail)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girljob)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlAddress)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlHobbly)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlmate)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlimg)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlimg1)
                .IsUnicode(false);

            modelBuilder.Entity<GirlInfo>()
                .Property(e => e.girlimg2)
                .IsUnicode(false);

            modelBuilder.Entity<GroupInfo>()
                .Property(e => e.boyName)
                .IsUnicode(false);

            modelBuilder.Entity<GroupInfo>()
                .Property(e => e.GirlName)
                .IsUnicode(false);

            modelBuilder.Entity<loginUser>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<loginUser>()
                .Property(e => e.userPwd)
                .IsUnicode(false);
        }
    }
}
