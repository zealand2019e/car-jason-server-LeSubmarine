using System;
using System.Collections.Generic;
using System.Text;
using ModelLib;

namespace OneLineCalc
{
    public static class ConsoleInquiries
    {
        static public Car GetCarObj()
        {
            return new Car(){Color = GetCarColor(),Model = GetCarModel(),RegNr = GetRegNr()};
        }
        static public string GetCarModel()
        {
            Console.WriteLine("What car model?");
            try
            {
                return Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry you have to write a car model.");
                return GetCarModel();
            }
        }

        static public string GetCarColor()
        {
            Console.WriteLine("What Color does the car have?");
            try
            {
                return Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry you have to write a color.");
                return GetCarColor();
            }
        }

        static public string GetRegNr()
        {
            //string[] states = new string[5]{"UT","NV","TX","AL","CA"};
            //for (int i = 0; i < states.Length; i++)
            //{
            //    if (state == states[i])
            //    {
            //        return state;
            //    }
            //}
            try
            {
                Console.WriteLine("What is your RegNr for your car?");
                string RegNr = Console.ReadLine();
                return RegNr;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry you have write a RegNr.");
                return GetRegNr();
            }
        }

        public static bool YesorNo(string question)
        {
            Console.WriteLine(question + " (y/n)");
            switch ((Console.ReadLine()).ToLower())
            {
                case ("y"):
                    return true;
                case ("yes"):
                    return true;
                case ("n"):
                    return false;
                case ("no"):
                default:
                    Console.WriteLine("Sorry you have to pick eiter yes or no.");
                    return YesorNo(question);
            }
        }

        //public static string GetItem()
        //{
            
        //    List<string> posAnswers = new List<string>(){"banana","lemon","apple","milk","meat"};
        //    string question = "Which item would you like?";
        //    question += " (";
        //    for (int i = 0; i < posAnswers.Count; i++)
        //    {
        //        question += posAnswers[i] + ", ";
        //    }
        //    question = question.Remove(question.Length - 1);
        //    question += ")";
        //    Console.WriteLine(question);
        //    string answer = Console.ReadLine().ToLower();

        //    for (int i = 0; i < posAnswers.Count; i++)
        //    {
        //        if (answer == posAnswers[i])
        //        {
        //            return answer;
        //        }
        //    }

        //    Console.WriteLine("Sorry you have to pick an available food.");
        //    return GetItem();
        //}
    }
}
