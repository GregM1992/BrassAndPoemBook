using System.Security.Claims;

List<Product> products = new()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 4326.00m,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Greg's Big Book of Poems and Other Atrocities",
        Price = 205.00m,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "French Horn",
        Price = 4000.00m,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Whispers of the Wind Beyond the Trees",
        Price = 333.00m,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Tuba",
        Price = 2500.00m,
        ProductTypeId = 1,
    }
};

List<ProductType> productTypes = new()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },
   new ProductType()
    {
        Title = "Book",
        Id = 2,
    }
};

void Greeting()
{
    Console.WriteLine("Welcome to Brass & Poem!");
}
void DisplayMenu()
{
   Console.WriteLine(@"Please choose one of the following options.
1. Display all products
2. Delete a product
3. Add a product
4. Update a product
5. Exit
");
    int userChoice = Convert.ToInt32(Console.ReadLine());
    switch(userChoice)
    {
        case 1:
            DisplayAllProducts();
            break;
        case 2: 
            DeleteProduct();    
            break;
        case 3:
            AddProduct();  
            break;
        case 4:
            UpdateProduct();
            break;
        case 5:
            Console.WriteLine("Thanks for visiting! Goodbye!");
            Environment.Exit(0);
            break;
        default: Console.WriteLine("That is not an option please try again.");
            DisplayMenu();
            break;
    }
}

string GetProductTypeName(int productTypeId, List<ProductType> productTypes)
{
    ProductType productType = productTypes.Find(pt => pt.Id == productTypeId);
    return productType != null ? productType.Title : "Unknown";
}

void DisplayAllProducts()
{
    int index = 1;
    
    
    foreach (Product product in products)
    {
        Console.WriteLine($@"{index++}. Product: {product.Name} 
   Price: ${product.Price} 
   Type: {GetProductTypeName(product.ProductTypeId, productTypes)}
");
    }
}

void DeleteProduct()
{
    
    Console.WriteLine("Please choose product number you would like to delete.");
    DisplayAllProducts();
    int userChoice = Convert.ToInt32(Console.ReadLine());
    if (userChoice > 0 && userChoice <= products.Count)
    {
        products.RemoveAt(userChoice - 1);
        Console.WriteLine("Product deleted!");
        DisplayAllProducts();
    }
    else
    {
        Console.WriteLine("This is not a valid selection please try again");
        DeleteProduct();
    }
    

}

void AddProduct()
{
    {
        int index = 1;
        Console.WriteLine("Enter the name of the product you're adding:  ");
        string name = Console.ReadLine();

        
        Console.WriteLine("Enter the price of the product you're adding (example: 120.00) :  ");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        

        foreach (ProductType productType in productTypes)
        {
            Console.WriteLine($"{index++}. {productType.Title}");
        }
        Console.WriteLine("Select the product type # of the new product:  ");
        int productTypeId = Convert.ToInt32(Console.ReadLine());

        Product newProduct = new()
        {
            Name = name,
            Price = price,
            ProductTypeId = productTypeId
        };

        products.Add(newProduct);
        Console.WriteLine(@"New product successfully added!");
        DisplayAllProducts();
    };
}

void UpdateProduct()
{
    {
        int index = 1;
        foreach (Product product in products)
        {
            Console.WriteLine($@"{index++}. Product: {product.Name}   
Price: ${product.Price}  
Type: {GetProductTypeName(product.ProductTypeId, productTypes)}
");
        }
        Console.WriteLine("Please select the # of the product you wish to update:  ");
        string userSelection = Console.ReadLine();



        if (!string.IsNullOrEmpty(userSelection) && Convert.ToInt32(userSelection) >= 1 && Convert.ToInt32(userSelection) <= products.Count)
        {
            int updateChoice = Convert.ToInt32(userSelection);
            index = 1;
            int productIndex = updateChoice - 1;
            Product productBeingUpdated = products[productIndex];

            if (productBeingUpdated != null && updateChoice <= products.Count)
            {
                Console.WriteLine($"You selected the {productBeingUpdated.Name}");
                Console.WriteLine("Enter a new name for the product, or press Enter to keep current name:  ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName))
                {
                    productBeingUpdated.Name = newName;
                }

               
                Console.WriteLine("Enter a new price (example: 20.00), or press Enter to keep current price:  ");
                string newPrice = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPrice))
                {
                    productBeingUpdated.Price = Convert.ToDecimal(newPrice);
                }

                
                foreach (ProductType productType in productTypes)
                {
                    Console.WriteLine($"{index++}. {productType.Title}");
                }


                
                Console.WriteLine("Select the new product type # of the new product, or press Enter to keep current selection:  ");
                string newProductTypeId = Console.ReadLine();
                if (!string.IsNullOrEmpty(newProductTypeId))
                {
                    productBeingUpdated.ProductTypeId = Convert.ToInt32(newProductTypeId);
                }


                Console.WriteLine("Product update successful! Here is the updated products list: \n");
                DisplayAllProducts();
            }

        }

        else
        {
            Console.WriteLine("Your selection is invalid, press Enter to try again.");
            Console.ReadLine();
            UpdateProduct();
        }
    }
    };
Greeting();
DisplayMenu();
// don't move or change this!
public partial class Program { }