using System.Collections.Generic;

namespace _01_Command_Project
{
    public class Customer
    {
        protected List<ICommand> Commands { get; set; }

        public Customer()
        {
            Commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void SignContractWithBoss()
        {
            Commands.ForEach(cmd => cmd.Execute());
        }
    }
}
