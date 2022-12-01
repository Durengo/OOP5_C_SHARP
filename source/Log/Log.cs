using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP5.source.Log
{
    using System.Diagnostics;

    public static class Log
    {
        //ERROR
        public static void ERROR(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{text}");

            Console.ResetColor();
        }

        public static void ERROR(bool state)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{state}");

            Console.ResetColor();
        }

        public static void ERROR(string text, bool state)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{text} {state}");

            Console.ResetColor();
        }

        public static void ERROR(int number)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{number}");

            Console.ResetColor();
        }

        public static void ERROR(string text, int number)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{text} {number}");

            Console.ResetColor();
        }

        public static void ERROR(string text, Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{text} {e}");

            Console.ResetColor();
        }

        public static void ERROR(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{e}");

            Console.ResetColor();
        }

        //ERROR
        //WARN
        public static void WARN(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{text}");

            Console.ResetColor();
        }

        public static void WARN(bool state)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{state}");

            Console.ResetColor();
        }

        public static void WARN(string text, bool state)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{text} {state}");

            Console.ResetColor();
        }

        public static void WARN(int number)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{number}");

            Console.ResetColor();
        }

        public static void WARN(string text, int number)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{text} {number}");

            Console.ResetColor();
        }

        //WARN
        //INFO
        public static void INFO(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{text}");

            Console.ResetColor();
        }

        public static void INFO(bool state)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{state}");

            Console.ResetColor();
        }

        public static void INFO(string text, bool state)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{text} {state}");

            Console.ResetColor();
        }

        public static void INFO(int number)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{number}");

            Console.ResetColor();
        }

        public static void INFO(string text, int number)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{text} {number}");

            Console.ResetColor();
        }

        //INFO
        //TRACE
        public static void TRACE(string text)
        {
            Console.WriteLine($"{text}");

            Console.ResetColor();
        }

        public static void TRACE(bool state)
        {
            Console.WriteLine($"{state}");

            Console.ResetColor();
        }

        public static void TRACE(string text, bool state)
        {
            Console.WriteLine($"{text} {state}");

            Console.ResetColor();
        }

        public static void TRACE(int number)
        {
            Console.WriteLine($"{number}");

            Console.ResetColor();
        }

        public static void TRACE(string text, int number)
        {
            Console.WriteLine($"{text} {number}");

            Console.ResetColor();
        }

        //TRACE
        //FATAL
        public static void FATAL(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Debug.Assert(false, $"{text}");

            Console.ResetColor();
        }

        public static void FATAL(bool state)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Debug.Assert(false, $"{state}");

            Console.ResetColor();
        }

        public static void FATAL(bool state, string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Debug.Assert(state, $"{text}");

            Console.ResetColor();
        }
        //FATAL
    }
}
