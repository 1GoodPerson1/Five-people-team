namespace UI
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

        public virtual DbSet<_class> _class { get; set; }
        public virtual DbSet<stuinfo> stuinfo { get; set; }
        public virtual DbSet<word> word { get; set; }
        public virtual DbSet<zhunbei> zhunbei { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_class>()
                .Property(e => e.classname)
                .IsUnicode(false);

            modelBuilder.Entity<stuinfo>()
                .Property(e => e.sname)
                .IsUnicode(false);

            modelBuilder.Entity<stuinfo>()
                .Property(e => e.sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<word>()
                .Property(e => e.wname)
                .IsUnicode(false);

            modelBuilder.Entity<word>()
                .Property(e => e.wmoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<zhunbei>()
                .Property(e => e.zstatic)
                .IsUnicode(false);
        }
    }
}
