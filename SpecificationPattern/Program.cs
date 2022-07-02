using SpecificationPattern.Enums;
using SpecificationPattern.Interfaces;
using SpecificationPattern.Specifications;

namespace SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // store's products
            var apple = new Product("Apple", Color.Red, Size.Small);
            var bike = new Product("Bike", Color.Green, Size.Medium);
            var car = new Product("Car", Color.Green, Size.Medium);
            var house = new Product("House", Color.Green, Size.Large);
            var tree = new Product("Tree", Color.Brown, Size.Large);

            Product[] products = { apple, bike, car, house, tree };

            System.Console.WriteLine("All Products");
            foreach (var p in products)
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            ProductFilter productFilter = new ProductFilter();

            #region Case 1 - Search products by color

            // Case 1 - Search products by color
            //
            // Problem:
            // The client wants to provide to his clients some filters to make easier to search for products
            // The filter needed to be implemented is by color
            //
            // To do that using specification, you have to create a Color Specification
            // and use like this:            

            System.Console.WriteLine("Green Products");
            foreach (var p in productFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            #endregion

            #region Case 2 - New filter: Size

            // Case 2 - New filter: Size
            //
            // The boss now wants you to implement a product filter by size, so the user can search 
            // by color or by size
            //
            // To do that, you'll have to create a new Specification (Size)
            //
            // The result is:

            System.Console.WriteLine("Large Products");
            foreach (var p in productFilter.Filter(products, new SizeSpecification(Size.Large)))
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            #endregion

            #region Case 3 - Filter by color AND by size

            // Since the app has two filters, the boss wants to provide the option to users to use both filters
            // at the same time
            //
            // To provide such functionality you need another specification that accepts two criterias
            //
            // The result is:

            System.Console.WriteLine("Medium Green Products");
            foreach (var p in productFilter.Filter(products, new AndSpecification(
                new ColorSpecification(Color.Green), new SizeSpecification(Size.Medium))))
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            #endregion            
        }
    }
}
