using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprache;
using Smart.Wasl.Homes.Services.HomeAppliances.Helper;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public enum PowerState { On, Off };
    public enum VolumeState { Up, Down };
    public enum CurrentState { On, Off };

    public class ApplianceStateConfiguration
    {

        public PowerState Power { get; set; }
        public VolumeState Volume { get; set; }
        public CurrentState CurrentState { get; set; }
        public Decimal VolumeValuue { get; set; }
        public Decimal TimerValue { get; set; }


    }
    public interface IApplianceStateStringParser
    {
        ApplianceStateConfiguration Parse(string strappliancestate);
    }
    public class ApplianceStateStringParser : IApplianceStateStringParser
    {
        public ApplianceStateConfiguration Parse(string strappliancestate)
        {
            try
            {
                var local_ApplianceactionUpdate = ApplianceActionBuilder.ConnectionStringBuilder.Parse(strappliancestate);
                var local_strApplianceConfiguration = local_ApplianceactionUpdate.Aggregate(new ApplianceStateConfiguration(),
                                    (current, updateFunction) => updateFunction(current));
                //  local_strApplianceConfiguration.Validate();
                return local_strApplianceConfiguration;
            }
            catch (ParseException parseException)
            {
                throw new Exception();
            }
        }
    }

 
    
}
