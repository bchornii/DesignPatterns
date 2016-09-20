using System;
using System.Collections.Generic;

namespace _01_Command_Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer();
            var team = new Team("X");
            var reqs = new List<Requirement>
            {
                new Requirement {Description = "Cool web site"},
                new Requirement {Description = "Ability to book beer on site"}
            };
            var commandX = new ProjectManagerCommand(team, reqs);
            var heroDev = new HeroDeveloper();
            var commandA = new HeroDeveloperCommand(heroDev, "A");
            customer.AddCommand(commandX);
            customer.AddCommand(commandA);

            customer.SignContractWithBoss();

            Console.Read();
        }
    }
}
