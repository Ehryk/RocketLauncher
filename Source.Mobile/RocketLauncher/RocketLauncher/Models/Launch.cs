using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RocketLauncher.Models
{
    class Launch
    {
        [JsonProperty("DeviceName")]
        string DeviceName;

        [JsonProperty("BeginTime")]
        DateTime BeginTime;

        [JsonProperty("LaunchTime")]
        DateTime? LaunchTime;

        [JsonProperty("Delay")]
        int Delay;

        [JsonProperty("Cancelled")]
        bool Cancelled;
    }
}
