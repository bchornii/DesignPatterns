using System.Collections.Generic;
using System.Text;

namespace _02_CompositeGoF
{
    class Component : IBranchComponent
    {
        public string Name { get; set; }
        public List<IComponent> Components { get; private set; }
        public Component(string name)
        {
            Name = name;
            Components = new List<IComponent>();
        }
        public void Add(IComponent component)
        {
            Components.Add(component);
        }

        public string GatherData()
        {            
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<{0}>", Name));
            foreach (var component in Components)
            {
                sb.Append(component.GatherData());
            }
            sb.Append(string.Format("</{0}>", Name));
            return sb.ToString();
        }

        public IComponent GetChild(int index)
        {
            return Components[index];
        }

        public void Remove(IComponent component)
        {
            Components.Remove(component);
        }
    }
}
