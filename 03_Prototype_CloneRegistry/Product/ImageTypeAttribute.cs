using System;

namespace _03_Prototype_CloneRegistry
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ImageTypeAttribute : Attribute
    {
        public ImageType Type { get; set; }
    }
}