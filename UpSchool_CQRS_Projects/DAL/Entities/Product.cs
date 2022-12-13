﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UpSchool_CQRS_Projects.DAL.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }    
        public string Brand { get; set; }    
        public int Stock { get; set; }    
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }    
        public decimal Cost { get; set; }    
        public string Storage { get; set; }    
        public string Supplier { get; set; }    
        public string Description { get; set; }    
        public string SizeType { get; set; }    
        public decimal Size { get; set; }    
        public DateTime ProduceofDate { get; set; }
        public DateTime EndofDate { get; set; }
        public bool Status { get; set; }
    }
}
