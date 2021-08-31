using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap004.Models
{
    public class GiaiPhuongTrinh
    {
        public double SoA(get; set;)
        public double SoB(get; set;)
            public double GiaiPhuongTrinh(double SoA, double SoB)
        {
            double x = 0;
            x = -SoB / SoA;
            return x;
        }


    }
}