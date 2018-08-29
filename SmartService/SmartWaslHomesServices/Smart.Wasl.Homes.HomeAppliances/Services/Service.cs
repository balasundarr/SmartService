using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services
{
    public abstract class Service : IService
    {
        protected ILogger Logger;
        protected IUserInfo UserInfo;
        protected bool Disposed;
        protected readonly HomeAppliancesContext DbContext;
        protected IHomeApplianceActionRepositry HomeApplianceActionRepositry;
        protected HomeApplianceInfoRepositry HomeApplianceInfoRepositry;
        protected HomeApplianceManageRepository HomeApplianceManageRepository;

        //protected IAddressRepositry AddressRepositry;
        //protected IApplianceActionRepositry ApplianceActionRepositry;
        //protected IApplianceRepositry ApplianceRepositryry;
        //protected ICityRepositry CityRepositr;
        //protected IContactRepositry IContactRepositry;
        //protected IContactTypeRepositry ContactTypeRepositryy;
        //protected ICountryRepositry CountryRepositry;
        //protected IEntranceRepositry EntranceRepositr;
        //protected IHomeAreaTypeRepositry HomeAreaTypeRepositry;
        //protected IHomeRepositry HomeRepositry;
        //protected ILocationRepositry LocationRepositry;
        //protected IRoomCoordinateRepositry RoomCoordinateRepositry;
        //protected IStateRepositry StateRepositry;

        public Service(ILogger logger, IUserInfo userInfo, HomeAppliancesContext dbContext)
        {
            Logger = logger;
            UserInfo = userInfo;
            DbContext = dbContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                DbContext?.Dispose();

                Disposed = true;
            }
        }

        protected IHomeApplianceActionRepositry ActionRepositry
            => HomeApplianceActionRepositry ?? (HomeApplianceActionRepositry = new HomeApplianceActionRepositry(UserInfo, DbContext));

        protected IHomeApplianceInfoRepositry InfoRespositry
            => HomeApplianceInfoRepositry ?? (HomeApplianceInfoRepositry = new HomeApplianceInfoRepositry(UserInfo, DbContext));

        protected IHomeApplianceManageRepository ManageRepositry
            => HomeApplianceManageRepository ?? (HomeApplianceManageRepository = new HomeApplianceManageRepository(UserInfo, DbContext));
    }
}
