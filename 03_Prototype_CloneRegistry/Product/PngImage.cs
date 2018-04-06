namespace _03_Prototype_CloneRegistry
{
    [ImageType(Type = ImageType.Png)]
    public class PngImage : Image
    {        
        public override Image Clone()
        {
            return this;
        }
    }
}