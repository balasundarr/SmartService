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

        public async Task<IEntity> GetObjectsById(int paraId, IEntity paraentity)
        {
            String local_EntityName = paraentity.GetType().ToString();
            if (local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.GetAddressById( paraId )));
            }
            
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetApplianceActionById(paraId)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetApplianceById(paraId)));
            }
            if (local_EntityName.Contains("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetCityById(paraId)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetContactById(paraId)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetContactTypeById(paraId)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetCountryById(paraId)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetEntranceById(paraId)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetHomeAreaTypeById(paraId))); ;
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetLocationById(paraId)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetRoomCoordinateById(paraId)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.GetStateById(paraId)));
            }
            throw new NotImplementedException();
        }

        public Task<IEntity> GetLocationById(int paraId, IEntity paraentity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IEntity> GetHomeAppliancesObjets(int paraObjectId, IEntity paraentity)
        {
            throw new NotImplementedException();
        }
    }
}
