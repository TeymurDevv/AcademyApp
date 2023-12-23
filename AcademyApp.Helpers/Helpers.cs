using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Helpers
{
    public class Helpers
    {
        public static void changeTextColor(string word,ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }

        public static void MainMenu()
        {
            changeTextColor("                            _____                                                          \n     /\\                    |  __ \\                                   /\\                    \n    /  \\      ___    __ _  | |  | |   ___   _ __ ___    _   _       /  \\     _ __    _ __  \n   / /\\ \\    / __|  / _` | | |  | |  / _ \\ | '_ ` _ \\  | | | |     / /\\ \\   | '_ \\  | '_ \\ \n  / ____ \\  | (__  | (_| | | |__| | |  __/ | | | | | | | |_| |    / ____ \\  | |_) | | |_) |\n /_/    \\_\\  \\___|  \\__,_| |_____/   \\___| |_| |_| |_|  \\__, |   /_/    \\_\\ | .__/  | .__/ \n                                                         __/ |              | |     | |    \n                                                        |___/               |_|     |_|    ", Console.ForegroundColor = ConsoleColor.Yellow);
            changeTextColor("enter number:" +
                "1.createStudent\n" +
                "2.getAllStudents\n" +
                "3. Get All Students in Notepad (a new txt file will be created when you choose this option \n" +
                "4. Quit",
                ConsoleColor.Yellow);
        }
    }
}
