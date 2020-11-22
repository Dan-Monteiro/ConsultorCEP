using System;

namespace ConsultaCEP.Utils
{
    class CustomConsole
    {
        public static void WriteLine(string content)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(content);

        }

        public static void WriteError(string content)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(content);
        }

        internal static void DefaultWriteLine(string content)
        {
            Console.ResetColor();

            Console.WriteLine(content);
        }
    }
}