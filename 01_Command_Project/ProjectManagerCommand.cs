using System.Collections.Generic;

namespace _01_Command_Project
{
    public class ProjectManagerCommand : ICommand
    {
        protected Team Team { get; set; }
        protected List<Requirement> Requirements { get; set; }

        public ProjectManagerCommand(Team team, List<Requirement> requerementList)
        {
            Team = team;
            Requirements = requerementList;
        }
        public void Execute()
        {
            Team.CompleterProject(Requirements);
        }
    }
}
