using SpecificationPattern.Enums;

namespace SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // store's products
            // Obs: The Size property was included when the "Case 2" happened;
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

            #region Case 1 - Search products by color

            // Case 1 - Search products by color
            //
            // Problem:
            // The client wants to provide to his clients some filters to make easier to search for products
            // The filter needed to be implemented is by color
            //
            // To do that, you don't want to implement all the logic here, so you decide to create a 
            // ProductFilter class, wich will receive the color and filter the products
            // the return will be all the products that matched the criteria
            //
            // The result is:
            ProductFilter productFilter = new ProductFilter();
            var greenProducts = productFilter.FilterByColor(products, Color.Green);

            System.Console.WriteLine("Green Products");
            foreach (var p in greenProducts)
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
            // To do that, you just need to copy paste the FilterByColor, change the names, use anoter enum
            // and...
            //
            // The result is:
            
            var largeProducts = productFilter.FilterBySize(products, Size.Large);

            System.Console.WriteLine("Large Products");
            foreach (var p in largeProducts)
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            #endregion

            #region Case 3 - Filter by color AND by size

            // Since the app has two filters, the boss wants to provide the option to users to use both filters
            // at the same time
            //
            // So you need to implement a FilterByColorAndBySize option and return the correct products
            // Once more, copy paste the FilterBy method, add a third argument
            // go through all the products, if the color and the size match, return the product
            //
            // The result is:

            var mediumGreenProducts = productFilter.FilterByColorAndBySize(products, Color.Green, Size.Medium);

            System.Console.WriteLine("Medium Green Products");
            foreach (var p in mediumGreenProducts)
            {
                System.Console.WriteLine($" - {p.Name}");
            }

            #endregion            
        }
    }
}
