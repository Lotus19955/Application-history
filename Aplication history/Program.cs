using System;
using System.Collections;
using System.Collections.Generic;


namespace Aplication_history
{
    class Program
    {
        public static Stack<string> History = new Stack<string>();
        public static Stack<string> ForwardHistory = new Stack<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1) Add url");
                Console.WriteLine("2) Go back");
                Console.WriteLine("3) Go forward");
                Console.WriteLine("4) Show history");
                string choise = Console.ReadLine();
                int.TryParse(choise, out int number);
                switch (number)
                {
                    case 1:
                        AddUrl(History);
                        break;
                    case 2:
                        Back(History);
                        break;
                    case 3:
                        Forward(ForwardHistory);
                        break;
                    case 4:
                        DisplayHistory(History);
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
        }
        public static void AddUrl(Stack<string> obj)
        {
            Console.Clear();
            Console.Write("Url: ");
            string url = Console.ReadLine();
            obj.Push(url);
        }
        public static void DisplayHistory(Stack<string> obj)
        {
            Console.Clear();
            int number = 1;
            foreach (var item in obj)
            {
                Console.WriteLine(number + ")" + item);
                number++;
            }
        }
        public static Stack<string> Back(Stack<string> obj)
        {
            Console.Clear();
            if (obj.Count != 0)
            {
                Console.WriteLine("You on site " + obj.Peek());
                ForwardHistory.Push(obj.Pop());
            }
            else { Console.WriteLine("Back history empty"); }
            return ForwardHistory;
        }
        public static Stack<string> Forward(Stack<string> obj)
        {
            Console.Clear();
            if (obj.Count != 0)
            {
                Console.WriteLine("You on site " + obj.Peek());
                History.Push(obj.Pop());
            }
            else { Console.WriteLine("Forward history empty"); }
            return History;
        }
    }
}
