﻿using System.ComponentModel;

namespace Data_Binding_6.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Ürün Adedi")]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
