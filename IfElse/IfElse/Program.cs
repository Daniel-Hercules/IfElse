using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean PasswordEntered = false;
            while(!(PasswordEntered)){

                Console.WriteLine("Hello! Please enter your password :  ");
                String input = Console.ReadLine();

                if (input.Equals("Daniel"))
                {
                    Console.WriteLine("Correct Password Inserted! Welcome Back Daniel");
                    PasswordEntered = true;
                }
                else if (input.Equals("Exit")) 
                {
                    Console.WriteLine("Exiting System \n Goodbye!");
                    PasswordEntered = true;
                }
                else
                {
                    Console.WriteLine("Incorrect Password Inserted Please Try again");
                }
            }
        }
    }
}
