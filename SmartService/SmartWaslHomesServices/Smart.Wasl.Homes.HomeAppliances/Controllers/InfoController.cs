//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;

//using Smart.Wasl.Homes.Services.HomeAppliances.Data;
//using Smart.Wasl.Homes.Services.HomeAppliances.Services;
//using Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface;
//using Smart.Wasl.Homes.Services.HomeAppliances.Settings;
//using Smart.Wasl.Homes.Services.HomeAppliances.Helper;
//using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
//using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;


//namespace Smart.Wasl.Homes.Services.HomeAppliances.Controllers
//{
//    public class InfoController
//    {


//        private readonly HomeAppliancesContext HomeApplianceContext;
//        private readonly AppSettings settings;


//        public InfoController(HomeAppliancesContext context,
//                                 IOptionsSnapshot<AppSettings> settings
//                                 )
//        {
//            HomeApplianceContext = context ?? throw new ArgumentNullException(nameof(context));


//            settings = settings.Value;
//            ((DbContext)context).ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
//        }
//        [HttpGet]
//        [Route("[appliance]")]
//        public Task<IActionResult> appliance([FromQuery]String objectname, int id)

//        //{
//            var options = new DbContextOptionsBuilder<HomeAppliancesContext>().Options;

//            if (objectname.Equals("City"))
//            {
//                IHomeApplianceInfoService hainfo = new HomeApplianceInfoService(
//                   LogHelper.GetLogger<HomeApplianceInfoService>(),
//                   new UserInfo { Name = "qa" },
//                   new HomeAppliancesContext(options));
//                City local_City = new City();
//                hainfo.GetObjectsById(id, local_City as IEntity);

//            }
//            throw new NotImplementedException();
//        }
//    }
//}
