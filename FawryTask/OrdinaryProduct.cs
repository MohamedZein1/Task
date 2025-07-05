namespace FawryTask
{
    public class OrdinaryProduct : Product
    {
        public OrdinaryProduct(string name, double price, int quantity) : base(name, price, quantity)
        {
        }

        public override bool IsExpiredProduct()
        {
            return false;
        }

        public override bool IsShippedProduct()
        {
            return false;
        }
    }
}
