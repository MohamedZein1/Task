namespace FawryTask
{
    public class CustomerOrder
    {
        public Product product { get; }
        public int Quantity { get; }
        public CustomerOrder(Product product, int quantity)
        {
            this.product = product;
            Quantity = quantity;
        }
    }
}
