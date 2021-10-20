using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data.Context
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactCreditcard> ContactCreditcards { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<CountryRegionCurrency> countryRegionCurrencies { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<SalesOrderHeadersSalesReason> salesOrderHeadersSalesReasons { get; set; }

        public DbSet<SalesPerson> SalesPeople { get; set; }

        public DbSet<SalesReason> SalesReasons { get; set; }
        public DbSet<SalesTaxRate> SalesTaxRates { get; set; }
        public DbSet<SalesTerritory> SalesTerritories { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<TransactionHistory> transactionHistories { get; set; }
        public DbSet<TransactionHistoryArchive> transactionHistoryArchives { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorAddress> VendorAddresses { get; set; }
        public DbSet<VendorContact> VendorContacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}