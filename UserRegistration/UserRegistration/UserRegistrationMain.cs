using System;

namespace UserRegistration
{
    class UserRegistrationMain
    {
        static void Main(string[] args)
        {
            UserDetails validateDetails = new UserDetails();
            Console.WriteLine("Welcome to User Registration Simulation");
            
            Console.WriteLine("Enter THe First Name");
            string firstName = Console.ReadLine();
            validateDetails.FirstNameValidation(firstName);
        }
    }
}
