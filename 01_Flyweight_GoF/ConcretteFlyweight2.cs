namespace _01_Flyweight_GoF
{
    public class ConcretteFlyweight2 : Flyweight
    {
        int allState;
        public override void Operation(int extrinsicState)
        {
            allState = extrinsicState;
        }
    }
}
