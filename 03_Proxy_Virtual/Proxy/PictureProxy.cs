namespace _03_Proxy_Virtual
{
    public class PictureProxy : Graphic
    {
        private Picture _picture;

        public PictureProxy(string fileName)
        {
            FileName = fileName;
            PictureToShow = Image.GetSmallImage();
        }

        public override void Draw()
        {
            if (_picture == null)
            {
                _picture = new Picture(FileName);
            }
            _picture.Draw();
        }

        public override void Load()
        {
            var p = _picture;
        }
    }
}