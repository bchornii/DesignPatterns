namespace _03_Mediator_Tomatos
{
    public abstract class Collegue
    {
        protected Mediator Mediator;

        protected Collegue(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}