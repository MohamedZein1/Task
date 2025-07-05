namespace FawryTask
{
    public class ExpiredShippedProduct : Product , IShippable
    {
        private DateTime ProductExpiryDate;
        private double ProductWeight;

        public ExpiredShippedProduct(string name, double price, int quantity, DateTime ExpiryDate, double weight) : base(name, price, quantity)
        {
            ProductExpiryDate = ExpiryDate;
            ProductWeight = weight;
        }

        public override bool IsExpiredProduct()
        {
            return (this.ProductExpiryDate < DateTime.Now);
        }

        public override bool IsShippedProduct()
        {
            return true;
        }

        public string getName()
        {
            return this.Name;
        }

        public double getWeight()
        {
            return this.ProductWeight;
        }
    }
}
