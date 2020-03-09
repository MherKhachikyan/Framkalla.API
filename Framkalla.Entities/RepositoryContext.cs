using Framkalla.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Framkalla.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
         
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<FreightCost> FreightCosts { get; set; }
        public DbSet<FreightRule> FreightRules { get; set; }
        public DbSet<ImageInfo> ImageInfos { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryHistory> InventoryHistories { get; set; }
        public DbSet<Loyalty> Loyalties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemOrderItem> OrderItemOrderItems { get; set; }
        public DbSet<OrdersStatistics> OrdersStatistics { get; set; }
        public DbSet<PaperFamily> PaperFamilies { get; set; }
        public DbSet<PrintAgency> PrintAgencies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroupImage> ProductGroupImages { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductTypeBackgroundImage> ProductTypeBackgroundImages { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ReferralRule> ReferralRules { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
        public DbSet<SocialAccountType> SocialAccountTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDevice> UserDevices { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<UserVoucher> UserVouchers { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherRule> VoucherRules { get; set; }
        public DbSet<VoucherType> VoucherTypes { get; set; }
        public DbSet<Workflow> Workflows { get; set; } 
        public DbSet<AverageOrderSizeData> AverageOrderSizeDatas { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
