using System;
namespace Ordering.Domain.Order
{
    public class OrderItem
    {
        private long Id { get; }
        private string Name { get; }

        public OrderItem(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
