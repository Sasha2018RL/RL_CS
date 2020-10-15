using System;

namespace tasks
{
    public class t0_6 : Task
    {
        public t0_6()
        {
        }

        public void run()
        {
            int a = -10, b = 10;
            double step = 2.5;
            for (double x = a; x <= b; x += step)
            {
                double y;
                if (x >= 0 && x <= 10)
                {
                    y = Math.Sqrt(x) + 1;
                    y = y / (Math.Pow(x, 2)+2);
                }
                else
                {
                    y = Math.Abs(2 + x) + 1;
                    y = y / (3 * x);
                }
                Console.WriteLine($"F({x:F2}) = {y:F2}");
            }
        }

        public void printTask()
        {
            Console.WriteLine("Область значений функции на промежутке [-10, 10] с интервалом 2,5");
        }
    }
}