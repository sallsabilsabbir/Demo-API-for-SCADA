using System;
using System.Collections.Generic;

namespace JplApi.Models
{
    public partial class SavingsAndProfit
    {
        public DateTime? Time { get; set; }
        public float? GrossProfit { get; set; }
        public float? RobintexSavings { get; set; }
        public float? Co2Savings { get; set; }
    }
}
