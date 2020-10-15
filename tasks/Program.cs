using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace tasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Task t1_6 = new t1_6();
            // t1_6.run();
            // Task t2_6 = new t2_6();
            // t2_6.run();
            // Task t3_6 = new t3_6();
            // t3_6.run();
            // Task t4_6 = new t4_6();
            // t4_6.run();
            // Task t5_6 = new t5_6();
            // t5_6.run();
            // Task t0_6 = new t0_6();
            // t0_6.run();
           Runner runner = new Runner();
           runner.mainMenu();
        }
    }
}