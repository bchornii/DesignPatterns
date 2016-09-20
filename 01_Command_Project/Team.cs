using System;
using System.Collections.Generic;

namespace _01_Command_Project
{
    public class Team
    {
        public string TeamName { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
        }

        public void CompleterProject(List<Requirement> requirements)
        {
            foreach (var requirement in requirements)
            {
                Console.WriteLine($"User Story ({requirement.Description}) has been completed");
            }
        }
    }
}
