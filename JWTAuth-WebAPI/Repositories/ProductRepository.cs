﻿using JWTAuth_WebAPI.Models;

namespace JWTAuth_WebAPI.Repositories
{
    public class ProductRepository
    {
        public static List<Product> Products = new List<Product>()
    {
      new Product() { ProductId = Guid.NewGuid(), ProductName = "Scented Candles", ProductPrice = 10 },
      new Product() { ProductId = Guid.NewGuid(), ProductName = "Bluetooth Speaker", ProductPrice = 20 },
      new Product() { ProductId = Guid.NewGuid(), ProductName = "Smart Watch", ProductPrice = 30 }
    };
    }
}