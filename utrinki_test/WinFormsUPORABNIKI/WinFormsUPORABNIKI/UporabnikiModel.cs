namespace WinFormsUPORABNIKI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UporabnikiModel : DbContext
    {
        public UporabnikiModel()
            : base("name=UporabnikiModel")
        {
        }

        public virtual DbSet<UPORABNIKI> UPORABNIKI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UPORABNIKI>()
                .Property(e => e.KOMENTAR)
                .IsUnicode(false);
        }
    }
}
