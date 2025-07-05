using System.Collections.Generic;

namespace FawryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpiredShippedProduct cheese = new ExpiredShippedProduct("Cheese", 100, 10, DateTime.Now.AddDays(7),2.5); 
            ExpiredShippedProduct biscuits = new ExpiredShippedProduct("Biscuits", 150, 15, DateTime.Now.AddDays(5),1); 
            ShippedProduct tv = new ShippedProduct("TV",2500,4,15);
            OrdinaryProduct MobileScratchCard = new OrdinaryProduct("MobileScratchCard", 900, 7);


            Customer customer = new Customer(30000);
            customer.AddProductToCart(cheese, 2);
            customer.AddProductToCart(biscuits, 6);
            customer.AddProductToCart(MobileScratchCard, 1);
            customer.AddProductToCart(tv, 2);
            customer.Checkout();
        }
    }
}
