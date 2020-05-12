using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoILWeaving
{
    public static class Helper
    {
        [EnableTimerForThisMethod]
        public static void ALongMethod(int value)
        {
            Thread.Sleep(5000);
            System.Console.WriteLine("Method completed!");
        }
    }
}