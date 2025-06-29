using System;

public class Product
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
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(3, "Phone", "Electronics"),
            new Product(1, "Shoes", "Fashion"),
            new Product(2, "Laptop", "Electronics"),
            new Product(5, "Book", "Education"),
            new Product(4, "Watch", "Accessories")
        };

        // Linear Search
        Product result1 = LinearSearch(products, 2);
        Console.WriteLine(result1 != null ? "Linear: " + result1.ProductName : "Linear: Not Found");

        // Sort array for Binary Search
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

        // Binary Search
        Product result2 = BinarySearch(products, 2);
        Console.WriteLine(result2 != null ? "Binary: " + result2.ProductName : "Binary: Not Found");
    }

    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }
}