using System;
using System.Collections.Generic;

namespace Ordering.API.Models
{
    public class OrderVo
    {
        public long Id { get; set; }
        public List<OrderItemVo> OrderItems { get; set; }

        public OrderVo(long id, List<OrderItemVo> orderItems)
        {
            Id = id;
            OrderItems = orderItems;
        }
    }
}