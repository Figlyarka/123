using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class EmptyParameters : IParameters
    {
        public ParameterInfo[] GetDescription() => new ParameterInfo[0];

        public void SetValues(double[] values) {}
    }
}
