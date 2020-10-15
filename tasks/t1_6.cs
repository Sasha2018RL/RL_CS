using System;

namespace tasks
{
    public class t1_6 : Task
    {
        public t1_6()
        {
        }

        public void run()
        {
            int n;
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int foundNumber = 0, foundIndex = -1;
            for (int i = 0; i < n; i++)
            {
                int number = Math.Abs(Helper.readInt("Введите число"));
                if (number >= 10 && number < 100)
                {
                    if (number % 10 != number / 10 % 10)
                    {
                        if (foundIndex < 0)
                        {
                            foundIndex = i + 1;
                            foundNumber = number;
                        }
                    }
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
            Console.WriteLine("Введіть з клавіатури n цілих чисел. Знайти серед цих чисел перше двозначне число, яке складається з різних цифр та його порядковий номер. Якщо таких чисел немає, то вивести NO.");
        }
    }
}