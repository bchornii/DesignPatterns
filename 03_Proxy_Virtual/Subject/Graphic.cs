namespace _03_Proxy_Virtual
{
    public abstract class Graphic
    {
        public string FileName { get; set; }
        public abstract void Draw();
        public abstract void Load();
        public Image PictureToShow { get; set; }
    }
}