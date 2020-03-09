using Framkalla.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Contracts.Repositories
{
    public interface IRepositoryWrapper
    {
        IWorkflowRepository WorkflowRepository { get; }
        IVoucherTypeRepository VoucherTypeRepository { get; }
        IVoucherRuleRepository VoucherRuleRepository { get; }
        IVoucherRepository VoucherRepository { get; }
        IUserVoucherRepository UserVoucherRepository { get; }
        IUserTokenRepository UserTokenRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IUserDeviceRepository UserDeviceRepository { get; }
        IUserRepository UserRepository { get; }
        ISocialAccountTypeRepository SocialAccountTypeRepository { get; }
        ISocialAccountRepository SocialAccountRepository { get; }
        IReferralRuleRepository ReferralRuleRepository { get; }
        IPromotionRepository PromotionRepository { get; }
        IProductTypeBackgroundImageRepository ProductTypeBackgroundImageRepository { get; }
        IProductTypeRepository ProductTypeRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        IProductGroupImageRepository ProductGroupImageRepository { get; }
        IProductGroupRepository ProductGroupRepository { get; }
        IProductRepository ProductRepository { get; }
        IPrintAgencyRepository PrintAgencyRepository { get; }
        IPaperFamilyRepository PaperFamilyRepository { get; }
        IOrdersStatisticsRepository OrdersStatisticsRepository { get; }
        IOrderItemOrderItemRepository OrderItemOrderItemRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }
        IOrderRepository OrderRepository { get; }
        ILoyaltyRepository LoyaltyRepository { get; }
        IInventoryHistoryRepository InventoryHistoryRepository { get; }
        IInventoryRepository InventoryRepository { get; }
        IImageInfoRepository ImageInfoRepository { get; }
        IFreightRuleRepository FreightRuleRepository { get; }
        IFreightCostRepository FreightCostRepository { get; }
        IExchangeRateRepository ExchangeRateRepository { get; }
        IDeviceRepository DeviceRepository { get; } 
        IAverageOrderSizeDataRepository AverageOrderSizeDataRepository { get; } 
        void Save(); 
    }
}
