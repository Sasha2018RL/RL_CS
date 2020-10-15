using System;

namespace tasks
{
    public class t5_6 : Task
    {
        public t5_6()
        {
        }

        public void run()
        {
            int a, b, count = 0, t;
            a = Helper.readInt("Введите A");
            b = Helper.readInt("Введите B");
            t = a;
            Console.Write("Получены числа: ");
            while (count <= 10)
            {
                t++;
                if (getNOD(t, b) == 1)
                {
                    count++;
                    Console.Write(t+" ");
                }
            }
        }

        private int getNOD(int a, int b)
        {
            if (b > a) {var temp = a; a = b; b = temp;}
            while (true) {
                if (b == 0) return a;
                a %= b;
                if (a == 0) return b;
                b %= a;
            }
        }

        public void printTask()
        {
            Console.WriteLine("Дано два натуральних числа A та В. Знайти перші 10 натуральних чисел, що більше за А та взаємно прості з В.");
        }
    }
}