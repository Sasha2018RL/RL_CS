using System;

namespace tasks
{
    public class t2_6 : Task
    {
        public t2_6()
        {
        }

        public void run()
        {
            int n, x, y, b;
            n = Helper.readInt("Введите n");
            x = Helper.readInt("Введите x");
            y = Helper.readInt("Введите y");
            b = Helper.readInt("Введите b");
            
            //нормализация ввода
            if (x > y)
            {
                int t = y;
                y = x;
                x = t;
            }

            int foundNumber = 0, foundIndex = -1;
            for (int i = 0; i < n; i++)
            {
                int number = Helper.readInt("Введите число");
                if (number >= x && number <= y && number % b == 0)
                {
                    foundIndex = i+1;
                    foundNumber = number;
                }
            }
            if (foundIndex > 0)
            {
                Console.WriteLine($"Найдено число {foundNumber} под номером {foundIndex}");
            }
            else
            {
                Console.WriteLine("Число не найдено.");
            }
        }

        public void printTask()
        {
            Console.WriteLine(
                "Введіть з клавіатури n цілих чисел. Знайти серед цих чисел останнє число, яке належить інтервалу [x, y] та кратне b та його порядковий номер. Якщо таких чисел немає, то вивести NO.");
        }
    }
}