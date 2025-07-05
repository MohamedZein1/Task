namespace FawryTask
{
    public class ShippedProduct : Product, IShippable
    {
        private double ProductWeight;
        public ShippedProduct(string name, double price, int quantity, double weight) : base(name, price, quantity)
        {
            this.ProductWeight = weight;
        }

        public string getName()
        {
            return this.Name;
        }

        public double getWeight()
        {
            return this.ProductWeight;
        }

        public override bool IsExpiredProduct()
        {
            return false;
        }

        public override bool IsShippedProduct()
        {
            return true;
        }
    }
}
