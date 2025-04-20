using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSPTT
{
    public class SettingsClasses
    {
        public class RunSettings
        {
            public int TriggerType { get; set; }
            public int SensorType { get; set; }
            public int SourceType { get; set; }
            public bool PreTest { get; set; }

        }
        
        public class TestSettings
        {

        }


        public static RunSettings initRunSettings()
        {
            SettingsClasses.RunSettings runSettings = new SettingsClasses.RunSettings();
            
            return runSettings;
        }
    }
}
