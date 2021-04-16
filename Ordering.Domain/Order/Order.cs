using System.Collections.Generic;

namespace Ordering.Domain.Order
{
    public class Order
    {
        private long Id { get; }
        private List<OrderItem> OrderItems { get; }

        public Order(int id, List<OrderItem> orderItems)
        {
            Id = id;
            OrderItems = orderItems;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            this.OrderItems.Add(orderItem);
        }
    }
}
