﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
