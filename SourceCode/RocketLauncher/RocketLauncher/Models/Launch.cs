using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RocketLauncher.Models
{
    class Launch
    {
        [JsonProperty("DeviceName")]
        string deviceName;

        [JsonProperty("DateTime")]
        DateTime datetime;

        [JsonProperty("Delay")]
        int delay;

        [JsonProperty("Cancelled")]
        bool cancelled;

        
    }
}
