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

List<ProductType> productType = new()
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

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }