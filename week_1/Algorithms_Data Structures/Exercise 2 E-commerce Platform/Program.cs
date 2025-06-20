using System;

public class Product : IComparable<Product>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public int CompareTo(Product other)
    {
        return this.ProductId.CompareTo(other.ProductId);
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

public class Program
{
    public static Product LinearSearch(Product[] products, int id)
    {
        foreach (var product in products)
        {
            if (product.ProductId == id)
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, int id)
    {
        int left = 0, right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (products[mid].ProductId == id)
                return products[mid];
            else if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    public static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "T-Shirt", "Clothing"),
            new Product(103, "Smartphone", "Electronics"),
            new Product(104, "Shoes", "Footwear"),
            new Product(105, "Book", "Education"),
        };

        Console.Write("Enter Product ID to search: ");
        int id = int.Parse(Console.ReadLine());
        
        var linearResult = LinearSearch(products, id);
        Console.WriteLine("\nLinear Search Result:");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found");

        Array.Sort(products);
        var binaryResult = BinarySearch(products, id);
        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found");
    }
}