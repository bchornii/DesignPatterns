using System;

namespace _02_State_Order
{
    public class CancelledState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Cannot ship, already cancelled.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Already cancelled.");
        }

        public OrderStatus Status => OrderStatus.Cancelled;
    }
}
