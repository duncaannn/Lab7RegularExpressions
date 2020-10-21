using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Lab7RegExpressions

// create a pattern that validates name input. use regex to return all letters
// create string that returns phone number input in a method

{
    class Program
    {
        static void Main(string[] args)

        {
            //Get Username and validate it for Uppercase, Lowercase and 30 characters
            while (true)
            {
                string userName = GetUserInput("What is your name?");

                Regex u = new Regex(@"([A-Z][a-zA-Z]{1,30})$");
                string[] validate = { userName };
                {
                    foreach (string weep in validate)
                    {
                        Console.WriteLine("{0} ", u.IsMatch(weep) ? "Great!" : "This is unnacceptable. Please try again.");

                    }

                }

                string email = GetUserInput("What is your email?");
                bool validEmail = ValidateEmail(email);
               
                    if (validEmail)
                    {
                        Console.WriteLine("Totally excellent!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Thats not a valid email. Try again.");
                        validEmail = false;

                        string email2 = GetUserInput("What is your email?");
                    }   
                
                string phoneNumber = GetUserInput("What is your phone number? No spaces please.");
                bool validPhonenumber = ValidatePhoneNumber(phoneNumber);
                if (validPhonenumber)
                {
                    Console.WriteLine("That is a fantastic phone number you have");
                }

                string getDate = GetUserInput("What is the date today? mm/dd/yy");
                bool validDate = ValidateDate(getDate);
                if (validDate)
                {
                    Console.WriteLine("Wow, you're a real calendar, aren't you!");
                }
                
            }
        }

        public static bool ValidateEmail(string email)
        {
            Regex e = new Regex(@"([A-z0-9]{5,30})[@]([A-z0-9]{5,10})[.]([A-z0-9]{2,3})$");

            if (e.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex p = new Regex(@"([1-9]{3}[-1-9]{3,4}[-1-9]{4,5})$");


            if (p.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool ValidateDate(string date)
        {
            Regex d = new Regex(@"([1-9]{2,3}[/][1-9]{3,4}[/][1-9]{3,4})$");
            if (d.IsMatch(date))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            return response;
        }
    }
}















