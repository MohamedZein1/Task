namespace FawryTask
{
    public class ShippingService
    {
        public static double Ship(List<IShippable> ShippedProducts)
        {
            double TotalPackageWeight = 0;
            Console.WriteLine("** Shipment notice **");
            foreach (var item in ShippedProducts)
            {
                Console.WriteLine($"{item.getName()}\t {item.getWeight()*1000}g");
                TotalPackageWeight += item.getWeight();
            }
            Console.WriteLine($"Total package weight: {TotalPackageWeight}kg");
            return TotalPackageWeight;
        }
    }
}
