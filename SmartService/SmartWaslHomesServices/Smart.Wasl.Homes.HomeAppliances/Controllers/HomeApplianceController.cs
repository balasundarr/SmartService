using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Services;
using Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface;
using Smart.Wasl.Homes.Services.HomeAppliances.Settings;
using Smart.Wasl.Homes.Services.HomeAppliances.Helper;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smart.Wasl.Homes.Services.HomeAppliances.Controllers
{
    [Route("api/[controller]")]
    public class HomeApplianceController : Controller
    {
        private readonly HomeAppliancesContext HomeApplianceContext;
        private readonly AppSettings settings;

        
    
    public HomeApplianceController(HomeAppliancesContext context,
                               IOptionsSnapshot<AppSettings> setting
                               )
    {
        HomeApplianceContext = context ?? throw new ArgumentNullException(nameof(context));


        settings = setting.Value;
        ((DbContext)context).ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    
        //    [HttpGet("Index")]
        //    public async Task<IActionResult> Index([FromQuery(Name = "sortValue")]string sortValue, [FromQuery(Name = "showDeactivated")] bool showDeactivated)
    [HttpGet("{QueryObject}/{name=string}/{id=int}")]
    public async Task<IActionResult> QueryObject(String name, int id)
    {
       // var options = new DbContextOptionsBuilder<HomeAppliancesContext>().Options;

        if (name.Contains("City"))
        {
                IHomeApplianceInfoService hainfo = new HomeApplianceInfoService(
                   LogHelper.GetLogger<HomeApplianceInfoService>(),
                   new UserInfo { Name = "qa" },
                   HomeApplianceContext);
              // new HomeAppliancesContext(options));
                City local_City = new City();
                local_City = (hainfo.GetObjectsById(id, local_City as IEntity).GetAwaiter().GetResult()) as City;
                return  Ok(local_City);
            }
            return   NotFound();

        }
    //[HttpGet]
    //[Route("[Manage]")]
    //public Task<IActionResult> Manage([FromQuery]string appliancename, int id)

    //{
    //    throw new NotImplementedException();
    //}
}
}
