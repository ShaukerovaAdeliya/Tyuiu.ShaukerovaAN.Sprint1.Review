using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint1.TaskReview.V21.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint1.TaskReview.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -2.486 ;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
