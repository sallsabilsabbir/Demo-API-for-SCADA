using System;
using System.Collections.Generic;

namespace JplApi.Models
{
    public partial class TodayPlantTotalEnergy
    {
        public DateTime? Time { get; set; }
        public float? TptEnergy { get; set; }
    }
}
