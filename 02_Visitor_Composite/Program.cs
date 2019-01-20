using System;
using System.Collections.Generic;

namespace _02_Visitor_Composite
{
    internal class Program
    {
        private static void Main()
        {
            // Main composite
            var mcomposite = new Composite("Main composite");

            // First inner composite
            var fcomposite = new Composite("First inner composite");

            // Second inner composite
            var scomposite = new Composite("Second inner composite");
            
            // add f and s composites to m composite
            mcomposite.AddComponents(fcomposite);
            mcomposite.AddComponents(scomposite);

            // First composite's leafs 
            var leaf1 = new Leaf("First composite's leaf 1");
            var leaf2 = new Leaf("First composite's leaf 3");
            var leaf3 = new Leaf("First composite's leaf 3");            
            fcomposite.AddComponents(leaf1, leaf2, leaf3);

            // Second composite's leafs
            var leaf4 = new Leaf("Second composite's leaf 4");
            var leaf5 = new Composite("Second composite's composite");
            scomposite.AddComponents(leaf4, leaf5);

            // Visit whole composite tree
            var v = new DisplayVisitor();
            mcomposite.Accept(v);

            Console.ReadKey();
        }
    }

    public interface IVisitor
    {
        void VisitComponent(Component component);
    }

    public class DisplayVisitor : IVisitor
    {
        public void VisitComponent(Component component)
        {
            component.Display();
        }
    }

    public abstract class Component
    {
        public readonly string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Display();
        public abstract void Accept(IVisitor visitor);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Display() => 
            Console.WriteLine(Name);

        public override void Accept(IVisitor visitor)
        {            
            visitor.VisitComponent(this);
        }
    }

    public class Composite : Component
    {
        public List<Component> Components { get; }

        public Composite(string name) : base(name)
        {
            Components = new List<Component>();
        }

        public override void Display() => 
            Console.WriteLine(Name);

        public void AddComponents(params Component[] components)
        {
            Components.AddRange(components);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitComponent(this);
            foreach (var component in Components)
            {
                component.Accept(visitor);
            }            
        }
    }
}
