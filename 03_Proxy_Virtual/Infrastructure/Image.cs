namespace _03_Proxy_Virtual
{
    public class Image
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public static Image GetSmallImage() => new Image();
        public static Image FromFile(string fileName) => new Image();
    }
}