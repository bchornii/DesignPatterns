using System;
using System.Collections.Generic;
using System.Text;

namespace _02_CompositeGoF
{
    public class Composite : IComponent
    {
        public string Name { get; set; }
        public IList<IComponent> Components { get; }
        public Composite(string name)
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
            var sb = new StringBuilder();
            sb.Append($"<{Name}>");
            sb.Append(Environment.NewLine);
            foreach (var component in Components)
            {
                sb.Append(component.GatherData());
                sb.Append(Environment.NewLine);
            }
            sb.Append($"</{Name}>");
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
