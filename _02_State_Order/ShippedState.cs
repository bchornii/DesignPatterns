using System;

namespace _02_State_Order
{
    public class ShippedState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Already shipped.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Already shipped, cannot cancel.");
        }

        public OrderStatus Status => OrderStatus.Shipped;
    }
}
