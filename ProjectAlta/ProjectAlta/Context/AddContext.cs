using Microsoft.EntityFrameworkCore;
using ProjectAlta.Entity;

namespace ProjectAlta.Context
{
    public class AddContext : DbContext
    {
        public AddContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<BarcodesUsageHistory> BarcodesUsageHistories { get; set; }
        public virtual DbSet<CharsetBarcode> CharsetBarcodes { get; set; }
        public virtual DbSet<CharsetType> CharsetTypes { get; set; }
        public virtual DbSet<CodeDetail> CodeDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<CustomerTypeofBussiness> CustomerTypeofBussinesses { get; set; }
        public virtual DbSet<Gift> Gifts { get; set; }
        public virtual DbSet<GiftsOfCampign> GiftsOfCampigns { get; set; }
        public virtual DbSet<ProgramSize> ProgramSizes { get; set; }
        public virtual DbSet<RulesForGift> RulesForGifts { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        
        public virtual DbSet<TimeFrame> TimeFrames { get; set; }
        public virtual DbSet<TypeBarcode> TypeBarcodes { get; set; }
        public virtual DbSet<Entity.TypeCode> TypeCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Gmail)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Barcode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Barcode>()
                .Property(e => e.CharsetBarcodeName)
                .IsUnicode(false);

            modelBuilder.Entity<Barcode>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<Barcode>()
                .Property(e => e.Profix)
                .IsUnicode(false);

            modelBuilder.Entity<BarcodesUsageHistory>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CharsetBarcode>()
                .Property(e => e.CharsetBarcodeName)
                .IsUnicode(false);

            modelBuilder.Entity<CharsetType>()
                .Property(e => e.Charset)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerPhone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProgramSize>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramSize>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramSize>()
                .Property(e => e.Profix)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramSize>()
                .Property(e => e.Charset)
                .IsUnicode(false);
        }
    }
}

