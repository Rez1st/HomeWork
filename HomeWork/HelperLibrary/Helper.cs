using System;

namespace HelperLibrary
{
    public static class Helper
    {
        public static void PrintWithColor(string message, ConsoleColor color, bool newLine)
        {
            var s = newLine ? "\n" : "";
            Console.ForegroundColor = color;
            Console.Write($"{message} {s}");
            Console.ResetColor();
        }
    }
}
