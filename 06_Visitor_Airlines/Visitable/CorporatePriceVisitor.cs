namespace _06_Visitor_Airlines
{
    public class CorporatePriceVisitor : IVisitor
    {
        public int TaxtToPay { get; private set; }
        public int TotalPrice { get; private set; }
        public void Visit(Book book)
        {
            var calculatedTax = book.Price * 7 / 100;
            TotalPrice += book.Price + calculatedTax;
            TaxtToPay += calculatedTax;
        }

        public void Visit(Car car)
        {
            var calculatedTax = car.Price * 20 / 100;
            TotalPrice += car.Price + calculatedTax;
            TaxtToPay += calculatedTax;
        }

        public void Visit(Wine wine)
        {
            var calculatedTax = wine.Price * 20 / 100;
            TotalPrice += wine.Price + calculatedTax;
            TaxtToPay += calculatedTax;
        }
    }
}