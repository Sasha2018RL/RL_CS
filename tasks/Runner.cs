﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace tasks
{
    public class Runner
    {

        public Runner()
        {
        }

        public void mainMenu()
        {
            Type l = Type.GetType("tasks.Task");
            List<Type> tasksTypes = new List<Type>();
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(Task))))
            {
                tasksTypes.Add(mytype);
            }

            Dictionary<int, List<Type>> tasks = new Dictionary<int, List<Type>>();
            foreach (var tasksType in tasksTypes)
            {
                string name = tasksType.Name;
                name = name.Replace("t", "");
                int page = Convert.ToInt32(name.Split('_')[1]);
                if (!tasks.ContainsKey(page))
                {
                    tasks[page] = new List<Type>();
                }

                tasks[page].Add(tasksType);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** Главное меню ****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Выберите номер темы");
            foreach (var key in tasks.Keys)
            {
                Console.WriteLine(key);
            }

            int tn = getThemeNumber(tasks.Keys);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            runTask(tn, tasks);

        }

        private int getThemeNumber(Dictionary<int, List<Type>>.KeyCollection keys)
        {
            int tn;
            try
            {
                tn = Helper.readInt("Номер темы");
            }
            catch (Exception e)
            {
                return getThemeNumber(keys);
            }
            
            if (keys.Contains(tn)) return tn;
            return getThemeNumber(keys);
        }

        private int getTaskNumber(List<Type> tasks)
        {
            int taskNumber = Helper.readInt("Номер задания: ");
            
            foreach (var task in tasks)
            {
                string name = task.Name;
                name = name.Replace("t", "");
                if (Convert.ToInt32(name.Split('_')[0]) == taskNumber) return taskNumber;
            }

            return getTaskNumber(tasks);
        }

        private void getAction(string className, int tn, Dictionary<int, List<Type>> tasks)
        {
            Console.Write("Выберите действие: ");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "c":
                    Process.Start($"https://github.com/Sasha2018RL/RL_CS/blob/master/tasks/t{className}.cs");
                    getAction(className, tn, tasks);
                    break;
                case "l":
                    runTask(tn, tasks);
                    break;
                case "m":
                    Console.Clear();
                    mainMenu();
                    break;
                case "e":
                    System.Environment.Exit(0);
                    break;
                default:
                    getAction(className, tn, tasks);
                    break;
            }
        }

        private void runTask(int tn, Dictionary<int, List<Type>> tasks)
        {
            Console.WriteLine($"**** Выбрана тема {tn} ****");
            Console.ResetColor();
            Console.WriteLine("Выберите номер задания для проверки");
            foreach (var value in tasks[tn])
            {
                string name = value.Name;
                name = name.Replace("t", "");
                Console.WriteLine(Convert.ToInt32(name.Split('_')[0]));
            }

            int taskNumber = getTaskNumber(tasks[tn]);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"**** Запуск задания {tn}_{taskNumber} ****");
            Console.WriteLine($"Текст задания: ");
            Console.ResetColor();

            Type t = Type.GetType($"tasks.t{taskNumber}_{tn}");
            if (t == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Произошла ошибка.");
                Console.ResetColor();
                this.mainMenu();
            }

            Task task = (Task) Activator.CreateInstance(t);
            task.printTask();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат работы задания:");
            Console.ResetColor();
            task.run();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выполнение задания завершено.");
            Console.ResetColor();
            Console.WriteLine("c - просмотреть код задания (откроется в браузере)");
            Console.WriteLine("m - вернуться в главное меню");
            Console.WriteLine("l - вернуться к списку заданий");
            Console.WriteLine("e - выйти из приложения");
            getAction($"{taskNumber}_{tn}", tn, tasks);
        }
    }
}