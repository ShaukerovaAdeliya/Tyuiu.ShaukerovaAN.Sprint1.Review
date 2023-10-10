using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaukerovaAN.Sprint1.TaskReview.V21.Lib
{
    public class DataService : ISprint1Task7V21 
    {
        public double Calculate(double x, double y)
        {
            double res = ((Math.Pow(x, y)) / ((Math.Cos(x) - x / 3))) + (((Math.Sin(Math.Pow(2, x)) + Math.Cos(y)) / ((Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y)));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
