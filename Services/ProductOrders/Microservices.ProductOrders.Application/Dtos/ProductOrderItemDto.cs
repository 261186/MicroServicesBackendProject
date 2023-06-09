﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.ProductOrders.Application.Dtos
{
    public class ProductOrderItemDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public Decimal Price { get; set; }
    }
}
