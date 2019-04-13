using System;
using CRM_Project.Entities;

namespace CRM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { FirstName="Edvin", LastName="Hakobyan", CompanyName="Progresstech Armein", Position="PM", Country="Armenia", Email="ehakobyan@gmail.com"};
            Operations.Create(user);
            User gotUser = Operations.Read(1);
            Console.WriteLine("Firstname: "+gotUser.FirstName);
            Console.WriteLine("Lastname: "+gotUser.LastName);
            Console.WriteLine("Company name: " + gotUser.CompanyName);
            Console.WriteLine("Position: " + gotUser.Position);
            Console.WriteLine("Country: " + gotUser.Country);
            Console.WriteLine("Email: " + gotUser.Email);
            Console.ReadKey();
        }
    }
}
