using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services
{
    public class HomeApplianceInfoRepositry : Repository, IHomeApplianceInfoRepositry
    {
        public HomeApplianceInfoRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
           : base(parauserInfo, paradbContext)
        {
        }

        public async Task<IEntity> GetObjectsById(int paramId, IEntity paramEntity)
        {
            String local_EntityName = paramEntity.GetType().ToString();

           
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.GetAddressById(paramId)));
            }
            
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetApplianceActionById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetApplianceById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetCityById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetContactById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetContactTypeById(paramId)));
            }
            if (local_EntityName.Contains("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetCountryById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetEntranceById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetHomeAreaTypeById(paramId))); ;
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetLocationById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetRoomCoordinateById(paramId)));
            }
            if (local_EntityName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetStateById(paramId)));
            }
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IEntity>> GetAll(String paramName)
        {
            //String local_EntityName = paramEntity.GetType().ToString();


            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }

            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Contains("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetAll()));
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Home"))
            {
                IHomeRepositry local_Repositry = new HomeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetAll()));
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            if (paramName.Equals("Smart.Wasl.Homes.Services.HomeAppliances.Domain.State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await local_Repositry.GetAll());
            }
            throw new NotImplementedException();
        }
        public Task<IEntity> GetLocationById(int paramId, IEntity paramEntity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IEntity> GetHomeAppliancesObjets(int paraObjectId, IEntity paramEntity)
        {
            throw new NotImplementedException();
        }
    }
}
