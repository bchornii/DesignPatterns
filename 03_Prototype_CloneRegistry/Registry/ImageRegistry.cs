using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _03_Prototype_CloneRegistry
{
    public class ImageRegistry
    {
        private readonly List<Image> _imageRegistry = new List<Image>();

        public static ImageRegistry Instance { get; set; }
        private ImageRegistry() { }
        static ImageRegistry()
        {
            Instance = new ImageRegistry();
        }

        public Image GetImage(ImageType imageType)
        {
            var imageInstance = _imageRegistry
                .FirstOrDefault(i => i.GetType().GetCustomAttribute<ImageTypeAttribute>().Type == imageType);    
            
            if (imageInstance == null)
            {                
                var typeOfInstance = GetType().Assembly.GetTypes()
                    .First(t => t.GetCustomAttribute<ImageTypeAttribute>()?.Type == imageType);
                imageInstance = (Image) Activator.CreateInstance(typeOfInstance);
                _imageRegistry.Add(imageInstance);
            }            
            return imageInstance.Clone();
        }
    }
}