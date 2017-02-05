namespace _01_Flyweight_GoF
{
    public class ConcretteFlyweight1 : Flyweight
    {
        private int _instrinsicState1;
        public override void Operation(int extrinsicState)
        {
            _instrinsicState1 = extrinsicState;
        }
    }
}
