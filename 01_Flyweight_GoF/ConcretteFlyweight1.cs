namespace _01_Flyweight_GoF
{
    public class ConcretteFlyweight1 : Flyweight
    {
        int instrinsicState1;
        public override void Operation(int extrinsicState)
        {
            instrinsicState1 = extrinsicState;
        }
    }
}
