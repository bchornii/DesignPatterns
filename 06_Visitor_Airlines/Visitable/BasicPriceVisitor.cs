namespace _06_Visitor_Airlines
{
    public class BasicPriceVisitor : IVisitor
    {
        public int TaxtToPay { get; private set; }
        public int TotalPrice { get; private set; }
        public void Visit(Book book)
        {
            var calculatedTax = book.Price * 10 / 100;
            TotalPrice += book.Price + calculatedTax;
            TaxtToPay += calculatedTax;            
        }

        public void Visit(Car car)
        {
            var calculatedTax = car.Price * 30 / 100;
            TotalPrice += car.Price + calculatedTax;
            TaxtToPay += calculatedTax;
        }

        public void Visit(Wine wine)
        {
            var calculatedTax = wine.Price * 32 / 100;
            TotalPrice += wine.Price + calculatedTax;
            TaxtToPay += calculatedTax;
        }
    }
}