using EFCoreLab1;
using EFCoreLab1.Models;
using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

// 1. Retrieve All Products
var products = await context.Products.ToListAsync();
Console.WriteLine("\nAll Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

// 2. Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\nFound: {product?.Name}");

// 3. FirstOrDefault with condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\nExpensive: {expensive?.Name}");
