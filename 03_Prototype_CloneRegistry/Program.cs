namespace _03_Prototype_CloneRegistry
{
    internal class Program
    {
        private static void Main()
        {
            var registry = ImageRegistry.Instance;
            var jpeg1 = registry.GetImage(ImageType.Jpeg);
            var jpeg2 = registry.GetImage(ImageType.Jpeg);
        }
    }
}
