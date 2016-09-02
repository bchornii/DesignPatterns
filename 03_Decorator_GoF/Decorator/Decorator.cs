namespace _03_Decorator_GoF
{
    abstract class Decorator : Component
    {
        public Component Component { protected get; set; }
        public override void Operation()
        {
            if(Component != null)
            {
                Component.Operation();
            }
        }
    }
}
