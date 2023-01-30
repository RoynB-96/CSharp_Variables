using System;
namespace CSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            Console.Write("Input your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Input your birth date: ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine()); //Only for MM/dd/yyyy format
            byte age = Convert.ToByte(DateTime.Now.Year - birthdate.Year);
            Console.Write("Input your phone number: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Input your country code: ");
            string code = Console.ReadLine();
            Console.Write("Input your marriage status: ");
            bool status = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Full Name: " + name + " " + surname);
            Console.WriteLine("Birth Date: " + birthdate.ToString("dd.MM.yyyy"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + code + number);
            Console.WriteLine("Marriage Status: " + status);
        }
    }
}