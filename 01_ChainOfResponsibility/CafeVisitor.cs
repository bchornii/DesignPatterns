namespace _01_ChainOfResponsibility
{
    public abstract class CafeVisitor
    {
        public CafeVisitor Visitor { get; set; }
        protected CafeVisitor(CafeVisitor cafeVisitor)
        {
            Visitor = cafeVisitor;
        }
        public virtual void HandleFood(Food food)
        {
            if(Visitor != null)
            {
                Visitor.HandleFood(food);
            }
        }
    }
}
