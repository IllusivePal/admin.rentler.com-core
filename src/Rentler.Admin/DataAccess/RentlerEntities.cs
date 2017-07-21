using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rentler.Admin.Configuration;
using Rentler.Admin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Rentler.Admin.DataAccess
{
    public partial class RentlerEntities : DbContext
    {
        public String ConnectionString { get; }
        public IEntityMapper EntityMapper { get; }
      
        public RentlerEntities(IOptions<AppSettings> appSettings, IEntityMapper entityMapper) 
        {
            ConnectionString = appSettings.Value.ConnectionString;
            EntityMapper = entityMapper;
        }
        public RentlerEntities(IOptions<AppSettings> appSettings)
        {
            ConnectionString = appSettings.Value.ConnectionString;
            EntityMapper = new EntityMapper();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityMapper.MapEntities(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<AchTransaction> AchTransactions { get; set; }
        public virtual DbSet<AffiliateUser> AffiliateUsers { get; set; }
        public virtual DbSet<ApiKey> ApiKeys { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BuildingAmenity> BuildingAmenities { get; set; }
        public virtual DbSet<ContactInfo> ContactInfoes { get; set; }
        public virtual DbSet<CustomAmenity> CustomAmenities { get; set; }
        public virtual DbSet<FeaturedListing> FeaturedListings { get; set; }
        public virtual DbSet<FormCategory> FormCategories { get; set; }
        public virtual DbSet<FormProvider> FormProviders { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<NextRecurringPayment> NextRecurringPayments { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PaymentInvite> PaymentInvites { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<PromoCode> PromoCodes { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<SavedBuilding> SavedBuildings { get; set; }
        public virtual DbSet<Scammer> Scammers { get; set; }
        public virtual DbSet<TenantApplication> TenantApplications { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        public virtual DbSet<VendorSignup> VendorSignups { get; set; }
        public virtual DbSet<ZipInfo> ZipInfoes { get; set; }
        public virtual DbSet<ListingReport> ListingReports { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<ApiCustomerKey> ApiCustomerKeys { get; set; }
        public virtual DbSet<ApiCustomer> ApiCustomers { get; set; }
        public virtual DbSet<CommunityAmenity> CommunityAmenities { get; set; }
        public virtual DbSet<OperatingDay> OperatingDays { get; set; }
        public virtual DbSet<RentalApplication> RentalApplications { get; set; }
        public virtual DbSet<RentalApplicationUser> RentalApplicationUsers { get; set; }
        public virtual DbSet<Verification> Verifications { get; set; }
        public virtual DbSet<FeaturedCommunity> FeaturedCommunities { get; set; }
        public virtual DbSet<BuildingUtility> BuildingUtilities { get; set; }
        public virtual DbSet<CommunityPhoto> CommunityPhotos { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Thread> Threads { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandService> BrandServices { get; set; }
        public virtual DbSet<BrandZip> BrandZips { get; set; }
        public virtual DbSet<Career> Careers { get; set; }
        public virtual DbSet<EmailPreference> EmailPreferences { get; set; }
        public virtual DbSet<GuestCard> GuestCards { get; set; }
        public virtual DbSet<Lease> Leases { get; set; }
        public virtual DbSet<LegalEntity> LegalEntities { get; set; }
        public virtual DbSet<LocalServiceZip> LocalServiceZips { get; set; }
        public virtual DbSet<OldUserPassword> OldUserPasswords { get; set; }
        public virtual DbSet<PaymentLineItem> PaymentLineItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentSeriesLineItem> PaymentSeriesLineItems { get; set; }
        public virtual DbSet<Press> Presses { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<RefreshSchedule> RefreshSchedules { get; set; }
        public virtual DbSet<AutopaySetting> AutopaySettings { get; set; }
        public virtual DbSet<ScheduledTransaction> ScheduledTransactions { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<PaymentSeries> PaymentSeries { get; set; }
        public virtual DbSet<LocalService> LocalServices { get; set; }
        public virtual DbSet<UserNote> UserNotes { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<MerchantAccount> MerchantAccounts { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Screening> Screenings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<RentalApplicant> RentalApplicants { get; set; }
    }
}
