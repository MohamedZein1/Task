namespace FawryTask
{
    public class Customer
    {
        private double Balance;
        private List<CustomerOrder> Cart = new List<CustomerOrder>();

        public Customer(int balance)
        {
            Balance = balance;            
        }
        public void AddProductToCart(Product product, int quantity)
        {            
            if (product.Quantity > quantity)
            {
                product.Quantity -= quantity;
                Cart.Add(new CustomerOrder(product, quantity));
            }
            else
                throw new Exception($"The requsted quantity for {product.Name} is greater than stock");
        }
        public double GetTotalPrice()
        {
            double TotalPrice = 0;
            foreach (var item in Cart)
            {
                TotalPrice += item.product.Price * item.Quantity;
            }
            return TotalPrice;
        }
        public List<IShippable> GetShippedProductsWithFees()
        {
            List<IShippable> shippedProducts = new List<IShippable>();
            
            foreach (var item in Cart)
                if (item.product is IShippable shipped && item.product.IsShippedProduct())
                    shippedProducts.Add(shipped);

            return shippedProducts;
        }
        public void Checkout()
        {
            if (Cart.Count is 0)
                throw new Exception("Your Cart is empty...!!");

            foreach (var item in Cart)
            {
                //re-checking the quantity in case the stock changed before checkout
                if (item.Quantity > item.product.Quantity)
                    throw new Exception($"The requsted quantity for {item.product.Name} is greater than stock");

                if (item.product.IsExpiredProduct())
                    throw new Exception($"The product {item.product.Name} is expired");
            }

            double SubTotal = GetTotalPrice();
            List<IShippable> ShippedProducts = GetShippedProductsWithFees();
            double PackageWeight = ShippingService.Ship(ShippedProducts);
            double total = SubTotal + (PackageWeight * 25);

            if (total > Balance)
                throw new Exception("Your Balance is Insufficient");

            Balance -= total;
            
            Console.WriteLine("");
            Console.WriteLine("** Checkout receipt **");
            foreach (var item in Cart)
            {
                Console.WriteLine($"{item.Quantity}x  {item.product.Name}\t {item.product.Price}");                
            }
            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine($"Sub total\t {SubTotal}");
            Console.WriteLine($"Total fees\t {(PackageWeight * 25):F2}");
            Console.WriteLine($"Paid amount\t {total}");
            Console.WriteLine($"Your Current balance\t {Balance}");


        }
    }
}
