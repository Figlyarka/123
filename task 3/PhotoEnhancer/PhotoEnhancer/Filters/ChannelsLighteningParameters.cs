using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ChannelsLighteningParameters : IParameters
    {
        public double CoefficientR { get; set; }
        public double CoefficientG { get; set; }
        public double CoefficientB { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Коэффициент для красного канала",
                    MinValue = 0,
                    MaxValue =10,
                    DefaultValue = 1,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Коэффициент для зеленого канала",
                    MinValue = 0,
                    MaxValue =10,
                    DefaultValue = 1,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Коэффициент для синего канала",
                    MinValue = 0,
                    MaxValue =10,
                    DefaultValue = 1,
                    Increment = 0.05
                }
            };
        }

        public void SetValues(double[] values)
        {
            CoefficientR = values[0];
            CoefficientG = values[1];
            CoefficientB = values[2];
        }
    }
}
