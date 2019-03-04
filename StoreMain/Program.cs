using System;
using System.Collections.Generic;
using StoreLibrary;

namespace StoreMain
{
    class Program
    {
        string storeName = "HippoLand";
        double storeSize = 1994.41;

        static void Main(string[] args)
        {
            Adress adress = new Adress
            {
                City = "Sofia",
                StreetNameNumber = "Vidin",
                Postcode = "M204AL",
            };

            SellerInfo sellerInfo = new SellerInfo
            {
                SellerAge = 30,
                SellerName = "Ivan",
            };

            SellerExp sellerExp = new SellerExp
            {
                DaysCount = 24,
                MonthsCount = 12,
                YearsCount = 4,
            };

            // Creating a List of Products
            List<Product> Products = new List<Product>
            {
                new Product
                {
                    ProductName = "Bear",
                    ProductPrice = 22.30M ,
                    ProductWeight = 333.21 ,
                    ExpDate = new DateTime(2026, 3, 1, 7, 0, 0)
                },
                new Product
                {
                    ProductName = "Dino",
                    ProductPrice = 12.55M ,
                    ProductWeight = 310.52 ,
                    ExpDate = new DateTime(2022, 5, 5 , 1, 0, 0)
                }
            };

            Console.WriteLine("Here you can buy:");
            Console.WriteLine(Products[1].ProductName);
            Console.WriteLine("For the price of:");
            Console.WriteLine(Products[1].ProductPrice);
            Console.WriteLine("From our Seller: ");
            Console.WriteLine(sellerInfo.SellerName);

        }
    }
}