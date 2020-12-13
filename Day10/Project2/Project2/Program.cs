﻿using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
                if (orderID.StartsWith("B"))
                    
                    Console.WriteLine($"{orderID} is a potentially fraudulent order");
            else
                {
                    Console.WriteLine($"{orderID} transaction looks good");
                }
        }
    }
}