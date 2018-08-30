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
using Microsoft.Extensions.Logging;

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
    [HttpGet()]
    public IActionResult Index()
    {
        return Redirect("~/swagger");
    }

    [HttpGet("{QueryObject}/{name=string}/{id=int}")]
    public async Task<IActionResult> QueryObject(String name, int id)
    {
            var local_logger = LogHelper.GetLogger<HomeApplianceInfoService>();
            try
            {
               
                IHomeApplianceInfoService hainfo = new HomeApplianceInfoService(
                    local_logger,
                    new UserInfo { Name = "qa" },
                    HomeApplianceContext);
                Type t = Type.GetType("Smart.Wasl.Homes.Services.HomeAppliances.Domain." + name);
                IEntity o = Activator.CreateInstance(t) as IEntity;
                o = await (hainfo.GetObjectsById(id, o));
                return Ok(o);
            }
            catch( Exception param_Exception)
            {

                local_logger.LogDebug("From HomeApplianceInfoService",param_Exception);
                return NotFound();
            }
     }

        [HttpGet("{QueryObject}/{name=string}")]
        public async Task<IActionResult> QueryObject(String name)
        {
            var local_logger = LogHelper.GetLogger<HomeApplianceInfoService>();
            try
            {

                IHomeApplianceInfoService hainfo = new HomeApplianceInfoService(
                    local_logger,
                    new UserInfo { Name = "qa" },
                    HomeApplianceContext);
                Type t = Type.GetType("Smart.Wasl.Homes.Services.HomeAppliances.Domain." + name);
                name = $"Smart.Wasl.Homes.Services.HomeAppliances.Domain." + name;
                IEnumerable<IEntity> o =null;
                o =  await (hainfo.GetAll(name));
                return Ok(o);
            }
            catch (Exception param_Exception)
            {

                local_logger.LogDebug("From HomeApplianceInfoService", param_Exception);
                return NotFound();
            }
        }

        //[HttpGet]
        //[Route("[Manage]")]
        //public Task<IActionResult> Manage([FromQuery]string appliancename, int id)

        //{
        //    throw new NotImplementedException();
        //}
    }
}
