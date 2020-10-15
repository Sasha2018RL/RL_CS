using System;

namespace tasks
{
    public class t3_6 : Task
    {
        public t3_6()
        {
        }


        public void run()
        {
            int k, a, b, c, count = 0;
            Random random = new Random();
            k = random.Next(10, 16);
            a = random.Next(10, 21);
            b = random.Next(25, 41);
            c = random.Next(15, 31);
            Console.WriteLine($"Сгенерировано: \n    k = {k} \n    a = {a} \n    b = {b} \n    c = {c}");
            for (int i = 0; i < k; i++)
            {
                int n = random.Next(a, b + 1);
                if (n > c)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    count++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{n} ");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nПолучено чисел: {count}");

        }

        public void printTask()
        {
            Console.WriteLine("Одержати у програмі k випадкових цілих чисел у діапазоні від A до B та знайти кількість тих, що >C.\n"+
            "Числа A (10<=A<=20 ), B(25<=B<=40 ), C (15<=C<=30) та k (10<=k<=15) одержати випадковим чином.");
        }
    }
}