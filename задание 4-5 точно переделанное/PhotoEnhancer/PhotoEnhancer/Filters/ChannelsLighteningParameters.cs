using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ChannelsLighteningParameters : IParameters
    {
        [ParameterInfo(Name = "Коэффициент для красного канала",
                    MinValue = 0,
                    MaxValue = 10,
                    DefaultValue = 1,
                    Increment = 0.05)]
        public double CoefficientR {  get; set; }

        [ParameterInfo(Name = "Коэффициент для зеленого канала",
            MinValue = 0,
            MaxValue = 10,
            DefaultValue = 1,
            Increment = 0.05)]
        public double CoefficientG { get; set; }

        [ParameterInfo(Name = "Коэффициент для синего канала",
            MinValue = 0,
            MaxValue = 10,
            DefaultValue = 1,
            Increment = 0.05)]
        public double CoefficientB { get; set; }
    }
}
