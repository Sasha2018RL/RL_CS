using System;

namespace tasks
{
    public class t4_6 : Task
    {
        public t4_6()
        {
        }


        public void run()
        {
            const int n = 20;
            const int a = 50;
            const int b = 150;
            int min3 = -1, max2 = -1;
            int[] numbers = new int[n];
            Random random = new Random();

            Console.Write("Сгенерировано: ");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(a, b + 1);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (is2Digit(numbers[i]))
                {
                    if (max2 == -1 || numbers[i] >= numbers[max2])
                    {
                        max2 = i;
                    }
                }

                if (is3Digit(numbers[i]))
                {
                    if (min3 == -1 || numbers[i] <= numbers[min3])
                        min3 = i;
                }
            }
            
            if(max2 == -1)
                Console.WriteLine("Не найдены двузначные числа");
            else 
                Console.WriteLine($"Найдено максимальное двузначное число {numbers[max2]} под номером {max2+1} (нумерация с 1)");
                
            if(min3 == -1)
                Console.WriteLine("Не найдены трехзначные числа");
            else 
                Console.WriteLine($"Найдено минимальное трехзначное число {numbers[min3]} под номером {min3+1} (нумерация с 1)");
        }

        private bool is2Digit(int n)
        {
            return Math.Abs(n) >= 10 && Math.Abs(n) <= 99;
        }
        
        private bool is3Digit(int n)
        {
            return Math.Abs(n) >= 100 && Math.Abs(n) <= 999;
        }

        public void printTask()
        {
            Console.WriteLine("Одержати випадковим чином 20 цілих чисел (від 50 до150) та вивести їх на екран. Знайти серед них найменше тризначне число та найбільше двозначне число. Якщо є декілька таких чисел, то визначте порядкові номери останніх з них. Якщо немає таких чисел, то вивести повідомлення.");
        }
    }
}