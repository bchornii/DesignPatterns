namespace _01_Flyweight_GoF
{
    public class ConcretteFlyweight2 : Flyweight
    {
        private int _allState;
        public override void Operation(int extrinsicState)
        {
            _allState = extrinsicState;
        }
    }
}
