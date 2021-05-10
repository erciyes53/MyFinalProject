﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(10,150))
            {
                Console.WriteLine("Ürün Adı="+product.ProductName+
                                  " Fiyat="+product.UnitPrice+
                                  " Stok Adedi="+product.UnitsInStock);
            }
        }
    }
}
