using System;

namespace _02_State_Order
{
    public class Order
    {
        #region private
        private IOrderState _orderState;
        #endregion

        #region public
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status => _orderState.Status;
        #endregion

        #region constructor
        public Order()
        {
            _orderState = new NewState();
        }

        #endregion

        #region public methods

        public bool CanCancel() => _orderState.CanCancel(this);

        public void Cancel()
        {
            if (CanCancel())
            {
                _orderState.Cancel(this);
            }
        }

        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }

        public void Ship()
        {
            if (CanShip())
            {
                _orderState.Ship(this);
            }
        }

        public void Change(IOrderState state)
        {
            _orderState = state;
        }

        #endregion

    }
}
