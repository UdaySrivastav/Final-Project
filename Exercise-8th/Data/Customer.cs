namespace Exercise_8th.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Customer : DbContext
    {
        public Customer()
            : base("name=Customer")
        {
        }

        public virtual DbSet<custDetail> custDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<custDetail>()
                .Property(e => e.Cust_Account)
                .IsUnicode(false);

            modelBuilder.Entity<custDetail>()
                .Property(e => e.Cust_Payee)
                .IsUnicode(false);

            modelBuilder.Entity<custDetail>()
                .Property(e => e.Cust_Tag)
                .IsUnicode(false);
        }
    }
}
