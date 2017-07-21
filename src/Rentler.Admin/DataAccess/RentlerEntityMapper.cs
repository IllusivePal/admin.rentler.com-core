using Rentler.Admin.DataAccess;
using Rentler.Admin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin
{
    public class RentlerEntityMapper:EntityMapper
    {
        public RentlerEntityMapper()
        {
            Mappings = new List<IEntityMap>()
            {
                new AchTransactionMap() as IEntityMap,
                new ApiCustomerKeyMap() as IEntityMap,
                new ApiCustomerMap() as IEntityMap,
                new ApiKeyMap() as IEntityMap,
                new ApplicantMap() as IEntityMap,
                new ApplicationMap() as IEntityMap,
                new ApplicationUserMap() as IEntityMap,
                new ArticleMap() as IEntityMap,
                new AutopaySettingMap() as IEntityMap,
                new BankAccountMap() as IEntityMap,
                new BankMap() as IEntityMap,
                new BlogMap() as IEntityMap,
                new BrandMap() as IEntityMap,
                new BrandServiceMap() as IEntityMap,
                new BrandZipMap() as IEntityMap,
                new BuildingAmenityMap() as IEntityMap,
                new BuildingMap() as IEntityMap,
                new BuildingUtilityMap() as IEntityMap,
                new CareerMap() as IEntityMap,
                new CommunityAmenityMap() as IEntityMap,
                new CommunityMap() as IEntityMap,
                new CommunityPhotoMap() as IEntityMap,
                new ContactInfoMap() as IEntityMap,
                new CustomAmenityMap() as IEntityMap,
                new EmailPreferenceMap() as IEntityMap,
                new FeaturedListingMap() as IEntityMap,
                new FeauturedCommunityMap() as IEntityMap,
                new FormCategoryMap() as IEntityMap,
                new FormMap() as IEntityMap,
                new FormProviderMap() as IEntityMap,
                new GuestCardMap() as IEntityMap,
                new LeaseMap() as IEntityMap,
                new LegalEntityMap() as IEntityMap,
                new ListingReportMap() as IEntityMap,
                new LocalServiceMap() as IEntityMap,
                new LocalServiceZipMap() as IEntityMap,
                new MerchantAccountMap() as IEntityMap,
                new MessageMap() as IEntityMap,
                new NextRecurringPaymentMap() as IEntityMap,
                new NotificationMap() as IEntityMap,
                new OldUserPasswordMap() as IEntityMap,
                new OperatingDayMap() as IEntityMap,
                new OrderItemMap() as IEntityMap,
                new OrderMap() as IEntityMap,
                new PageMap() as IEntityMap,
                new PaymentInviteMap() as IEntityMap,
                new PaymentLineItemMap() as IEntityMap,
                new PaymentMap() as IEntityMap,
                new PaymentMethodMap() as IEntityMap,
                new PaymentSeriesLineItemMap() as IEntityMap,
                new PaymentSeriesMap() as IEntityMap,
                new PhotoMap() as IEntityMap,
                new PressMap() as IEntityMap,
                new PromoCodeMap() as IEntityMap,
                new PropertyMap() as IEntityMap,
                new RecurringPaymentMap() as IEntityMap,
                new RefreshScheduleMap() as IEntityMap,
                new RentalApplicantMap() as IEntityMap
                


            };
        }
    }
}
