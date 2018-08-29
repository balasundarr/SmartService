using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services
{
    public class HomeApplianceManageRepository : Repository, IHomeApplianceManageRepository
    {
        

        public HomeApplianceManageRepository(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {

        }
        public async Task<Int32> AddAEntityAsync(IEntity paraentity)
        {
            String local_EntityName = paraentity.GetType().ToString();
            if ( local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddAddressAsync(paraentity as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddApplianceActioneAsync(paraentity as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddApplianceAsync(paraentity as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddCityAsync(paraentity as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddContacteAsync(paraentity as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddContactTypeAsync(paraentity as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddCountryAsync(paraentity as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddEntranceAsync(paraentity as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddHomeAreaTypeAsync(paraentity as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddLocationAsync(paraentity as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddRoomCoordinateAsync(paraentity as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddStateAsync(paraentity as State)));
            }
            throw new NotFiniteNumberException();
        }

        public async Task<Int32> UpdateEntityAsync(IEntity parachanges)
        {
            String local_EntityName = parachanges.GetType().ToString();
            if (local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateAddressAsync(parachanges as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateApplianceActionAsync(parachanges as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateApplianceAsync(parachanges as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateCityAsync(parachanges as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateContactAsync(parachanges as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateContactTypeAsync(parachanges as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateCountryAsync(parachanges as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateEntranceAsync(parachanges as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateHomeAreaTypeAsync(parachanges as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateLocationAsync(parachanges as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateRoomCoordinateAsync(parachanges as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateStateAsync(parachanges as State)));
            }
         
            throw new NotFiniteNumberException();
        }


        public async Task<Int32> DeleteEntityAsync(IEntity paraentity)
        {
            String local_EntityName = paraentity.GetType().ToString();
            if (local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteAddressAsync(paraentity as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteApplianceActioneAsync(paraentity as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteApplianceAsync(paraentity as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteCityeAsync(paraentity as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteContactAsync(paraentity as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteContactTypeAsync(paraentity as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteCountryAsync(paraentity as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteEntranceAsync(paraentity as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteHomeAreaTypeAsync(paraentity as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteLocationAsync(paraentity as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteRoomCoordinateAsync(paraentity as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteStateAsync(paraentity as State)));
            }
            throw new NotFiniteNumberException();
        }
}
    }

