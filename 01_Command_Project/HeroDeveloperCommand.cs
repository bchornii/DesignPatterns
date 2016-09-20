namespace _01_Command_Project
{
    public class HeroDeveloperCommand : ICommand
    {
        protected HeroDeveloper Dev { get; set; }
        protected string ProjectName { get; set; }

        public HeroDeveloperCommand(HeroDeveloper dev, string projectName)
        {
            Dev = dev;
            ProjectName = projectName;
        }

        public void Execute()
        {
            Dev.DoAllHardWork(ProjectName);
        }
    }
}
