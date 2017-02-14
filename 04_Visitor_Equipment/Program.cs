namespace _04_Visitor_Equipment
{
    internal class Program
    {
        private static void Main()
        {
        }
    }

    public abstract class EquipmentVisitor
    {
        public abstract void VisitFloppyDisk(FloppyDisk floppyDisk);
        public abstract void VisitCard(Card card);
        public abstract void VisitChassis(Chassis chassis);
        public abstract void VisitBus(Bus bus);
    }

    public class PricingVisitor : EquipmentVisitor
    {
        private double _currrent;
        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            _currrent += floppyDisk.GetNetPrice();
        }

        public override void VisitCard(Card card)
        {
            throw new System.NotImplementedException();
        }

        public override void VisitChassis(Chassis chassis)
        {
            throw new System.NotImplementedException();
        }

        public override void VisitBus(Bus bus)
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class Equipment
    {
        private string Name { get; }

        protected Equipment(string name)
        {
            Name = name;
        }

        public abstract double GetNetPrice();
        public abstract double GetDiscountPrice();
        public abstract void Accept(EquipmentVisitor visitor);
    }

    public class FloppyDisk : Equipment{
        public FloppyDisk(string name) : base(name)
        {
        }

        public override double GetNetPrice()
        {
            return 34.0;
        }

        public override double GetDiscountPrice()
        {
            return 30.0;
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitFloppyDisk(this);
        }
    }
    public class Card { }
    public class Chassis : Equipment {
        public Chassis(string name) : base(name)
        {
        }

        public override double GetNetPrice()
        {
            throw new System.NotImplementedException();
        }

        public override double GetDiscountPrice()
        {
            throw new System.NotImplementedException();
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
    public class Bus { }
}
