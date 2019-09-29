using System;
using System.Collections.Generic;

namespace Lesson_1_2
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static Func<String, String, int, String> FuncStringDelegate;

        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description,
                                           int age)
        {
            Console.WriteLine(FuncStringDelegate(name, description, age));
        }

        /// <summary>
        /// Возвращает строку, оформленную по формату Format на основании переданных параметров
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="description">Описание</param>
        /// <param name="age">Возраст</param>
        /// <returns></returns>
        private static string GetString(string name, string description, int age)
        {
            return String.Format(Format, name, description, Address, age);
        }

        private static void MakeAction(Action action)
        {
            string methodName = action.Method.Name;
            FuncStringDelegate = GetString;
            Console.WriteLine("Начало работы метода {0}", methodName);
            action();
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }

        private static List<Action> GetActionSteps()
        {
            return new List<Action>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }

        static void Main(string[] args)
        {
            List<Action> actions = GetActionSteps();
            foreach (var action in actions)
            {
                MakeAction(action);
            }

            Console.ReadLine();
        }
    }
}
