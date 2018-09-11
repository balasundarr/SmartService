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
        public async Task<Int32> AddAEntityAsync(IEntity paramEntity)
        {
            String local_EntityName = paramEntity.GetType().ToString();
            if ( local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddAddressAsync(paramEntity as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddApplianceActioneAsync(paramEntity as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddApplianceAsync(paramEntity as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddCityAsync(paramEntity as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddContacteAsync(paramEntity as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddContactTypeAsync(paramEntity as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddCountryAsync(paramEntity as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddEntranceAsync(paramEntity as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddHomeAreaTypeAsync(paramEntity as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddLocationAsync(paramEntity as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddRoomCoordinateAsync(paramEntity as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await (local_Repositry.AddStateAsync(paramEntity as State)));
            }
            throw new NotFiniteNumberException();
        }

        public async Task<Int32> UpdateEntityAsync(IEntity paramChanges)
        {
            String local_EntityName = paramChanges.GetType().ToString();
            if (local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateAddressAsync(paramChanges as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateApplianceActionAsync(paramChanges as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateApplianceAsync(paramChanges as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateCityAsync(paramChanges as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateContactAsync(paramChanges as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateContactTypeAsync(paramChanges as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateCountryAsync(paramChanges as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateEntranceAsync(paramChanges as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateHomeAreaTypeAsync(paramChanges as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateLocationAsync(paramChanges as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateRoomCoordinateAsync(paramChanges as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.UpdateStateAsync(paramChanges as State)));
            }
         
            throw new NotFiniteNumberException();
        }


        public async Task<Int32> DeleteEntityAsync(IEntity paramEntity)
        {
            String local_EntityName = paramEntity.GetType().ToString();
            if (local_EntityName.Equals("Address"))
            {
                IAddressRepositry local_Repositry = new AddressRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteAddressAsync(paramEntity as Address)));
            }
            if (local_EntityName.Equals("ApplianceAction"))
            {
                IApplianceActionRepositry local_Repositry = new ApplianceActionRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteApplianceActioneAsync(paramEntity as ApplianceAction)));
            }
            if (local_EntityName.Equals("Appliance"))
            {
                IApplianceRepositry local_Repositry = new ApplianceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteApplianceAsync(paramEntity as Appliance)));
            }
            if (local_EntityName.Equals("City"))
            {
                ICityRepositry local_Repositry = new CityRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteCityeAsync(paramEntity as City)));
            }
            if (local_EntityName.Equals("Contact"))
            {
                IContactRepositry local_Repositry = new ContactRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteContactAsync(paramEntity as Contact)));
            }
            if (local_EntityName.Equals("ContactType"))
            {
                IContactTypeRepositry local_Repositry = new ContactTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteContactTypeAsync(paramEntity as ContactType)));
            }
            if (local_EntityName.Equals("Country"))
            {
                ICountryRepositry local_Repositry = new CountryRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteCountryAsync(paramEntity as Country)));
            }
            if (local_EntityName.Equals("Entrance"))
            {
                IEntranceRepositry local_Repositry = new EntranceRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteEntranceAsync(paramEntity as Entrance)));
            }
            if (local_EntityName.Equals("HomeAreaType"))
            {
                IHomeAreaTypeRepositry local_Repositry = new HomeAreaTypeRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteHomeAreaTypeAsync(paramEntity as HomeAreaType)));
            }
            if (local_EntityName.Equals("Location"))
            {
                ILocationRepositry local_Repositry = new LocationRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteLocationAsync(paramEntity as Location)));
            }
            if (local_EntityName.Equals("RoomCoordinate"))
            {
                IRoomCoordinateRepositry local_Repositry = new RoomCoodinateRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteRoomCoordinateAsync(paramEntity as RoomCoordinate)));
            }
            if (local_EntityName.Equals("State"))
            {
                IStateRepositry local_Repositry = new StatesRepositry(UserInfo, DbContext as HomeAppliancesContext);
                return (await(local_Repositry.DeleteStateAsync(paramEntity as State)));
            }
            throw new NotFiniteNumberException();
        }
}
    }

