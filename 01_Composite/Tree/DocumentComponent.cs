using System.Collections.Generic;
using System.Text;

namespace _01_Composite
{
    class DocumentComponent : IDocumentComponent
    {
        public string Name { get; set; }
        public List<IDocumentComponent> DocumentComponents { get; private set; }
        public DocumentComponent(string name)
        {
            Name = name;
            DocumentComponents = new List<IDocumentComponent>();
        }

        public string GatherData()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Format("<{0}>\n", Name));
            foreach (var component in DocumentComponents)
            {               
                stringBuilder.Append(component.GatherData());
            }
            stringBuilder.Append(string.Format("</{0}>\n", Name));
            return stringBuilder.ToString();
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            DocumentComponents.Add(documentComponent);
        }
    }
}
