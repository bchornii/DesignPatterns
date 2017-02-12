namespace _03_Mediator_Tomatos
{
    public class ConcretteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }
        public override void Send(string msg, Collegue collegue)
        {
            if (collegue == Farmer)
            {
                Cannery.MakeKetchup(msg);
            }
            else if (collegue == Cannery)
            {
                Shop.SellKetchup(msg);
            }
        }
    }
}