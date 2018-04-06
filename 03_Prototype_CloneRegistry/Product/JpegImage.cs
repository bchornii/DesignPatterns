namespace _03_Prototype_CloneRegistry
{
    [ImageType(Type = ImageType.Jpeg)]
    public class JpegImage : Image
    {
        public override Image Clone()
        {
            return this;
        }
    }
}