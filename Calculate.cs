using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    class Calculate
    {
        private const int Megabyte = 1024;
        private double Rate;
        public double CalculateRate(double price, double volume)
        {
            Rate = price / (volume * Megabyte);
            return Rate;
        }
    }
}
