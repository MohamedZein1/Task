namespace FawryTask
{
    public class ExpiredProduct : Product
    {
        public DateTime ProductExpiryDate { get; }
        public ExpiredProduct(string name, double price, int quantity, DateTime ExpiryDate) : base(name, price, quantity)
        {
            ProductExpiryDate = ExpiryDate;
        }        
        public override bool IsExpiredProduct()
        {
            return (this.ProductExpiryDate < DateTime.Now);
        }
        public override bool IsShippedProduct()
        {
            return false;
        }
    }
}
