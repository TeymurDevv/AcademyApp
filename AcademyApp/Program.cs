// See https://aka.ms/new-console-template for more information
using AcademyApp.Business.Services;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;
using System.Diagnostics;
using System.Text;
StudentService studentService = new StudentService();
Helpers.changeTextColor("                            _____                                                          \n     /\\                    |  __ \\                                   /\\                    \n    /  \\      ___    __ _  | |  | |   ___   _ __ ___    _   _       /  \\     _ __    _ __  \n   / /\\ \\    / __|  / _` | | |  | |  / _ \\ | '_ ` _ \\  | | | |     / /\\ \\   | '_ \\  | '_ \\ \n  / ____ \\  | (__  | (_| | | |__| | |  __/ | | | | | | | |_| |    / ____ \\  | |_) | | |_) |\n /_/    \\_\\  \\___|  \\__,_| |_____/   \\___| |_| |_| |_|  \\__, |   /_/    \\_\\ | .__/  | .__/ \n                                                         __/ |              | |     | |    \n                                                        |___/               |_|     |_|    ", Console.ForegroundColor = ConsoleColor.Yellow);
Helpers.changeTextColor("enter number: \n" +
    "1. Create a Group\n"+
    "2.Create a Student\n" +
    "3.getAllStudents\n" +
    "4. Get All Students in Notepad (a new txt file will be created when you choose this option \n" +
    "5. Quit",
    ConsoleColor.Yellow);
while (true)
{
    int menuChoice = int.Parse(Console.ReadLine());
	switch (menuChoice)
	{
        case 1:
            Console.WriteLine("1 secildi");
            break;

        case 2:
            Helpers.changeTextColor("Enter a Student Name",ConsoleColor.Yellow);
            string stuName =  Console.ReadLine();
            Helpers.changeTextColor("Enter a Student SurName", ConsoleColor.Yellow);
            string stuSurName =  Console.ReadLine() ;
            Helpers.changeTextColor("Enter a student Age", ConsoleColor.Yellow);
            int studentAge = int.Parse(Console.ReadLine());
            Helpers.changeTextColor("Enter a Student Group Name",ConsoleColor.Yellow);
            string studentGroup =  Console.ReadLine();

            Student existStudent = new() { Id = 1, Age = studentAge, Name = stuName, SurName = stuSurName, Group = Group.StaticGroup(), CreatedDate = DateTime.Now };
            studentService.Create(existStudent, "P518");
            Helpers.changeTextColor("Student was Succesfully Created", ConsoleColor.Green);
            Thread.Sleep(1000);
            Helpers.MainMenu();
            break;

		case 3:
            Console.Clear();
            List<Student> students = new List<Student>();
            Helpers.changeTextColor("Getting all Students from Database it can be take few Moments please be patient !", ConsoleColor.Green);
            Thread.Sleep(1000);
            Console.Clear() ;
            students = studentService.GetAll();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            break;

        case 4:
            Helpers.changeTextColor("A txt file Creating, it will Automaically will be opened when Ready...",ConsoleColor.Green);
            Thread.Sleep(1000);
            StringBuilder stringBuilder = new();
            List<Student> studentsList =  studentService.GetAll();
            foreach (Student student in studentsList)
            {
                stringBuilder.Append($"{student} \n");
            }
            string path = @"C:\Users\TeymurDevv\Desktop\AcademyApp\Files\students.txt";
            File.WriteAllText(path, stringBuilder.ToString());
            try 
            {
                Process.Start(new ProcessStartInfo(path) { UseShellExecute = true});
            } 
            catch(Exception ex)
            {
                Helpers.changeTextColor("There was a Problem while i was trying to open the txt Document: " + ex.Message,ConsoleColor.Red);
            }
            Console.Clear();
            Console.WriteLine(stringBuilder);
            Thread.Sleep(1000);
			break;

        case 5:
            Helpers.changeTextColor("Successfully Quited from The Academy App", ConsoleColor.Green); 
            System.Environment.Exit(0);
            break;
        default:
			break;
	}
}