using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.API.Shared
{
    public class MetarExResult
    {
        public int next_offset { get; set; }
        public MetarResults[] metar { get; set; }
    }
}
