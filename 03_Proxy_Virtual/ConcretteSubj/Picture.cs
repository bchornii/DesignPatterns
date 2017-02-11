using System;

namespace _03_Proxy_Virtual
{
    public class Picture : Graphic
    {
        public Picture(string fileName)
        {
            FileName = fileName;
        }
        public override void Draw()
        {
            PictureToShow = Image.FromFile(FileName);
        }

        public override void Load()
        {
            throw new InvalidOperationException();
        }
    }
}