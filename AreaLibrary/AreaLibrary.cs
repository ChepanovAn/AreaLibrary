using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public static class AreaLibrary
    {
        public static double RectangleArea (double firstvalue, double secondvalue, double thirdvalue)
        {
            double p = (firstvalue + secondvalue + thirdvalue) / 2;
            return Math.Sqrt(p * (p - firstvalue) * (p - secondvalue) * (p - thirdvalue));
        }
        public static double CircleArea(double firstvalue)
        {
            return 3.14 * firstvalue;
        }
    }
}
