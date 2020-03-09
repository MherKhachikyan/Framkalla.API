using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Repository.Models;
using System;

namespace Framkalla.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IProductGroupRepository _productGroupRepository;
        private IProductTypeRepository _productTypeRepository;
        private IWorkflowRepository _workflowRepository;
        private IVoucherTypeRepository _voucherTypeRepository;
        private IVoucherRuleRepository _voucherRuleRepository;
        private IVoucherRepository _voucherRepository;
        private IUserVoucherRepository _userVoucherRepository;
        private IUserTokenRepository _userTokenRepository;
        private IUserRoleRepository _userRoleRepository;
        private IUserDeviceRepository _userDeviceRepository;
        private IUserRepository _userRepository;
        private ISocialAccountTypeRepository _socialAccountTypeRepository;
        private ISocialAccountRepository _socialAccountRepository;
        private IReferralRuleRepository _referralRuleRepository;
        private IPromotionRepository _promotionRepository;
        private IProductTypeBackgroundImageRepository _productTypeBackgroundImageRepository;
        private IProductImageRepository _productImageRepository;
        private IProductGroupImageRepository _productGroupImageRepository;
        private IProductRepository _productRepository;
        private IPrintAgencyRepository _printAgencyRepository;
        private IPaperFamilyRepository _paperFamilyRepository;
        private IOrdersStatisticsRepository _ordersStatisticsRepository;
        private IOrderItemOrderItemRepository _orderItemOrderItemRepository;
        private IOrderItemRepository _orderItemRepository;
        private IOrderRepository _orderRepository;
        private ILoyaltyRepository _loyaltyRepository;
        private IInventoryHistoryRepository _inventoryHistoryRepository;
        private IInventoryRepository _inventoryRepository;
        private IImageInfoRepository _imageInfoRepository;
        private IFreightRuleRepository _freightRuleRepository;
        private IFreightCostRepository _freightCostRepository;
        private IExchangeRateRepository _exchangeRateRepository;
        private IDeviceRepository _deviceRepository;
        private IAverageOrderSizeDataRepository _averageOrderSizeDataRepository;

        public IProductGroupRepository ProductGroupRepository
        {
            get
            {
                if (_productGroupRepository == null)
                {
                    _productGroupRepository = new ProductGroupRepository(_repoContext);
                }
                return _productGroupRepository;
            }
        }

        public IProductTypeRepository ProductTypeRepository
        {
            get
            {
                if (_productTypeRepository == null)
                {
                    _productTypeRepository = new ProductTypeRepository(_repoContext);
                }
                return _productTypeRepository;
            }
        }

        public IWorkflowRepository WorkflowRepository
        {
            get
            {
                if (_workflowRepository == null)
                {
                    _workflowRepository = new WorkflowRepository(_repoContext);
                }
                return _workflowRepository;
            }
        }

        public IVoucherTypeRepository VoucherTypeRepository
        {
            get
            {
                if (_voucherTypeRepository == null)
                {
                    _voucherTypeRepository = new VoucherTypeRepository(_repoContext);
                }
                return _voucherTypeRepository;
            }
        }

        public IVoucherRuleRepository VoucherRuleRepository
        {
            get
            {
                if (_voucherRuleRepository == null)
                {
                    _voucherRuleRepository = new VoucherRuleRepository(_repoContext);
                }
                return _voucherRuleRepository;
            }
        }

        public IVoucherRepository VoucherRepository
        {
            get
            {
                if (_voucherRepository == null)
                {
                    _voucherRepository = new VoucherRepository(_repoContext);
                }
                return _voucherRepository;
            }
        }

        public IUserVoucherRepository UserVoucherRepository
        {
            get
            {
                if (_userVoucherRepository == null)
                {
                    _userVoucherRepository = new UserVoucherRepository(_repoContext);
                }
                return _userVoucherRepository;
            }
        }

        public IUserTokenRepository UserTokenRepository
        {
            get
            {
                if (_userTokenRepository == null)
                {
                    _userTokenRepository = new UserTokenRepository(_repoContext);
                }
                return _userTokenRepository;
            }
        }

        public IUserRoleRepository UserRoleRepository
        {
            get
            {
                if (_userRoleRepository == null)
                {
                    _userRoleRepository = new UserRoleRepository(_repoContext);
                }
                return _userRoleRepository;
            }
        }

        public IUserDeviceRepository UserDeviceRepository
        {
            get
            {
                if (_userDeviceRepository == null)
                {
                    _userDeviceRepository = new UserDeviceRepository(_repoContext);
                }
                return _userDeviceRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_repoContext);
                }
                return _userRepository;
            }
        }

        public ISocialAccountTypeRepository SocialAccountTypeRepository
        {
            get
            {
                if (_socialAccountTypeRepository == null)
                {
                    _socialAccountTypeRepository = new SocialAccountTypeRepository(_repoContext);
                }
                return _socialAccountTypeRepository;
            }
        }

        public ISocialAccountRepository SocialAccountRepository
        {
            get
            {
                if (_socialAccountRepository == null)
                {
                    _socialAccountRepository = new SocialAccountRepository(_repoContext);
                }
                return _socialAccountRepository;
            }
        }

        public IReferralRuleRepository ReferralRuleRepository
        {
            get
            {
                if (_referralRuleRepository == null)
                {
                    _referralRuleRepository = new ReferralRuleRepository(_repoContext);
                }
                return _referralRuleRepository;
            }
        }

        public IPromotionRepository PromotionRepository
        {
            get
            {
                if (_promotionRepository == null)
                {
                    _promotionRepository = new PromotionRepository(_repoContext);
                }
                return _promotionRepository;
            }
        }

        public IProductTypeBackgroundImageRepository ProductTypeBackgroundImageRepository
        {
            get
            {
                if (_productTypeBackgroundImageRepository == null)
                {
                    _productTypeBackgroundImageRepository = new ProductTypeBackgroundImageRepository(_repoContext);
                }
                return _productTypeBackgroundImageRepository;
            }
        }

        public IProductImageRepository ProductImageRepository
        {
            get
            {
                if (_productImageRepository == null)
                {
                    _productImageRepository = new ProductImageRepository(_repoContext);
                }
                return _productImageRepository;
            }
        }

        public IProductGroupImageRepository ProductGroupImageRepository
        {
            get
            {
                if (_productGroupImageRepository == null)
                {
                    _productGroupImageRepository = new ProductGroupImageRepository(_repoContext);
                }
                return _productGroupImageRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_repoContext);
                }
                return _productRepository;
            }
        }

        public IPrintAgencyRepository PrintAgencyRepository
        {
            get
            {
                if (_printAgencyRepository == null)
                {
                    _printAgencyRepository = new PrintAgencyRepository(_repoContext);
                }
                return _printAgencyRepository;
            }
        }

        public IPaperFamilyRepository PaperFamilyRepository
        {
            get
            {
                if (_paperFamilyRepository == null)
                {
                    _paperFamilyRepository = new PaperFamilyRepository(_repoContext);
                }
                return _paperFamilyRepository;
            }
        }

        public IOrdersStatisticsRepository OrdersStatisticsRepository
        {
            get
            {
                if (_ordersStatisticsRepository == null)
                {
                    _ordersStatisticsRepository = new OrdersStatisticsRepository(_repoContext);
                }
                return _ordersStatisticsRepository;
            }
        }

        public IOrderItemOrderItemRepository OrderItemOrderItemRepository
        {
            get
            {
                if (_orderItemOrderItemRepository == null)
                {
                    _orderItemOrderItemRepository = new OrderItemOrderItemRepository(_repoContext);
                }
                return _orderItemOrderItemRepository;
            }
        }

        public IOrderItemRepository OrderItemRepository
        {
            get
            {
                if (_orderItemRepository == null)
                {
                    _orderItemRepository = new OrderItemRepository(_repoContext);
                }
                return _orderItemRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_repoContext);
                }
                return _orderRepository;
            }
        }

        public ILoyaltyRepository LoyaltyRepository
        {
            get
            {
                if (_loyaltyRepository == null)
                {
                    _loyaltyRepository = new LoyaltyRepository(_repoContext);
                }
                return _loyaltyRepository;
            }
        }

        public IInventoryHistoryRepository InventoryHistoryRepository 
        {
            get
            {
                if (_inventoryHistoryRepository == null)
                {
                    _inventoryHistoryRepository = new InventoryHistoryRepository(_repoContext);
                }
                return _inventoryHistoryRepository;
            }
        }

        public IInventoryRepository InventoryRepository 
        {
            get
            {
                if (_inventoryRepository == null)
                {
                    _inventoryRepository = new InventoryRepository(_repoContext);
                }
                return _inventoryRepository;
            }
        }

        public IImageInfoRepository ImageInfoRepository 
        {
            get
            {
                if (_imageInfoRepository == null)
                {
                    _imageInfoRepository = new ImageInfoRepository(_repoContext);
                }
                return _imageInfoRepository;
            }
        }

        public IFreightRuleRepository FreightRuleRepository 
        {
            get
            {
                if (_freightRuleRepository == null)
                {
                    _freightRuleRepository = new FreightRuleRepository(_repoContext);
                }
                return _freightRuleRepository;
            }
        }

        public IFreightCostRepository FreightCostRepository 
        {
            get
            {
                if (_freightCostRepository == null)
                {
                    _freightCostRepository = new FreightCostRepository(_repoContext);
                }
                return _freightCostRepository;
            }
        }

        public IExchangeRateRepository ExchangeRateRepository 
        {
            get
            {
                if (_exchangeRateRepository == null)
                {
                    _exchangeRateRepository = new ExchangeRateRepository(_repoContext);
                }
                return _exchangeRateRepository;
            }
        }

        public IDeviceRepository DeviceRepository 
        {
            get
            {
                if (_deviceRepository == null)
                {
                    _deviceRepository = new DeviceRepository(_repoContext);
                }
                return _deviceRepository;
            }
        }

        public IAverageOrderSizeDataRepository AverageOrderSizeDataRepository 
        {
            get
            {
                if (_averageOrderSizeDataRepository == null)
                {
                    _averageOrderSizeDataRepository = new AverageOrderSizeDataRepository(_repoContext);
                }
                return _averageOrderSizeDataRepository;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public RepositoryWrapper()
        {
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
