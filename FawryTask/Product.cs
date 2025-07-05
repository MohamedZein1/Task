namespace FawryTask
{
    public abstract class Product
    {        
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; set; }

        protected Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public abstract bool IsExpiredProduct();
        public abstract bool IsShippedProduct();
    }
}
