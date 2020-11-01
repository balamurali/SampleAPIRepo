using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.API.Shared
{
    public class MetarResults
    {
        public string airport { get; set; }

        public string conditions { get; set; }

        public int wind_speed { get; set; }

        public int temp_air { get; set; }
    }

}
