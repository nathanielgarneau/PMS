
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using PMS.Xam.DAL.Model;

namespace PMS.DAL
{
    public class CodeFirstModel : System.Data.Entity.DbContext
    {
        public CodeFirstModel()
            : base("name=CodeFirstModel")
        {
            Database.SetInitializer<CodeFirstModel>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MicroQCCodeFirstModel, Migrations.Configuration>());
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Colour> Colour { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Facility> Facility { get; set; }
        public DbSet<IdentificationType> IdentificationType { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Pawn> Pawn { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            AddressEntityConfig(modelBuilder);
            CityEntityConfig(modelBuilder);
            ClientEntityConfig(modelBuilder);
            ColourEntityConfig(modelBuilder);
            ConditionEntityConfig(modelBuilder);
            CountryEntityConfig(modelBuilder);
            FacilityEntityConfig(modelBuilder);
            IdentificationTypeEntityConfig(modelBuilder);
            LocationEntityConfig(modelBuilder);
            NoteEntityConfig(modelBuilder);
            PawnEntityConfig(modelBuilder);
            PaymentEntityConfig(modelBuilder);
            PaymentTypeEntityConfig(modelBuilder);
            ProductEntityConfig(modelBuilder);
            ProductTypeEntityConfig(modelBuilder);
            ProvinceEntityConfig(modelBuilder);
            PurchaseEntityConfig(modelBuilder);
            RateEntityConfig(modelBuilder);
            SettingEntityConfig(modelBuilder);
            TagEntityConfig(modelBuilder);
            UserEntityConfig(modelBuilder);
            UserSettingsEntityConfig(modelBuilder);
            //  modelBuilder.HasDefaultSchema("ClientName");//Multitenant setup
            base.OnModelCreating(modelBuilder);
        }

        private EntityTypeConfiguration<T> EntityTypeConfiguration<T>(DbModelBuilder modelBuilder) where T : class
        {
            return modelBuilder.Entity<T>();
        }
        private void AddressEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Address>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.City);
            entityConfig.HasRequired(x => x.Province);
            entityConfig.HasRequired(x => x.Country);
            entityConfig.HasRequired(x => x.PostalCode);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(255);
        }

        private void CityEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<City>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Province);
        }

        private void ClientEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Client>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.FirstName);
            entityConfig.Property(x => x.FirstName).HasMaxLength(50);
            entityConfig.HasRequired(x => x.LastName);
            entityConfig.Property(x => x.LastName).HasMaxLength(50);
            entityConfig.HasRequired(x => x.Address);
            entityConfig.HasRequired(x => x.LicenseNumber);
            entityConfig.Property(x => x.LicenseNumber).HasMaxLength(50);
            entityConfig.HasRequired(x => x.IdentificationType);
            entityConfig.HasOptional(x => x.OtherIdentificationNumber);
            entityConfig.Property(x => x.OtherIdentificationNumber).HasMaxLength(50);
            entityConfig.HasOptional(x => x.OtherIdentificationNumber);
        }
        private void ColourEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Colour>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(50);
            entityConfig.HasRequired(x => x.Code);
            entityConfig.Property(x => x.Code).HasMaxLength(20);
        }
        private void ConditionEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Condition>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(50);
        }
        private void CountryEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Country>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(50);
        }
        private void FacilityEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Facility>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Address);
        }
        private void IdentificationTypeEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<IdentificationType>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
        }
        private void LocationEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Location>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Description);
            entityConfig.Property(x => x.Description).HasMaxLength(255);
            entityConfig.HasRequired(x => x.Facility);
        }
        private void NoteEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Note>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Value);
            entityConfig.Property(x => x.Value).HasMaxLength(255);
        }

        private void PawnEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Pawn>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Client);
            entityConfig.HasRequired(x => x.Rate);
            entityConfig.HasRequired(x => x.Items);
            entityConfig.HasMany(x => x.Items);
            entityConfig.HasRequired(x => x.Notes);
            entityConfig.HasMany(x => x.Notes);
            entityConfig.HasRequired(x => x.StorageLocations);
            entityConfig.HasMany(x => x.StorageLocations);
            entityConfig.HasRequired(x => x.Payments);
            entityConfig.HasMany(x => x.Payments);
        }

        private void PaymentEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Payment>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.PaymentType);
        }
        private void PaymentTypeEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<PaymentType>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(50);
        }

        private void ProductEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Product>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Description);
            entityConfig.Property(x => x.Description).HasMaxLength(255);
            entityConfig.HasRequired(x => x.ProductType);
            entityConfig.HasRequired(x => x.Conditions);
            entityConfig.HasMany(x => x.Conditions);
            entityConfig.HasRequired(x => x.Colour);
            entityConfig.HasRequired(x => x.Tags);
            entityConfig.HasMany(x => x.Tags);
        }

        private void ProductTypeEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<ProductType>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(50);
        }
        private void ProvinceEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Province>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Country);

        }

        private void PurchaseEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Purchase>(modelBuilder);
            entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Client);
            entityConfig.HasRequired(x => x.Items);
            entityConfig.HasMany(x => x.Items);
            entityConfig.HasRequired(x => x.Notes);
            entityConfig.HasMany(x => x.Notes);
            entityConfig.HasRequired(x => x.StorageLocations);
            entityConfig.HasMany(x => x.StorageLocations);

            entityConfig.HasRequired(x => x.Payments);
            entityConfig.HasMany(x => x.Payments);
        }

        private void RateEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Rate>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
        }
        private void SettingEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Setting>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
            entityConfig.HasRequired(x => x.Value);
            entityConfig.Property(x => x.Value).HasMaxLength(100);
        }
        private void TagEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<Tag>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
        }
        private void UserEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<User>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.UserSettings);
            entityConfig.HasMany(x => x.UserSettings);
        }
        private void UserSettingsEntityConfig(DbModelBuilder modelBuilder)
        {
            var entityConfig = EntityTypeConfiguration<UserSetting>(modelBuilder); entityConfig.HasKey(x => x.Id);
            entityConfig.HasRequired(x => x.Name);
            entityConfig.Property(x => x.Name).HasMaxLength(80);
        }
    }
}
