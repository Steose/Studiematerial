# 📦 Lagerhantering med Collections

## Beskrivning av övningen

Kombinera List och Dictionary för att skapa ett lagerhanteringssystem. Detta visar hur olika collections kan arbeta tillsammans för att lösa komplexa problem.

## Uppgift

Skapa ett lagerhanteringssystem för en butik som kan:
1. Hantera produkter med namn, pris och antal i lager
2. Lägga till nya produkter
3. Uppdatera lagersaldo
4. Söka produkter
5. Visa lagerstatistik
6. Hantera lågt lagersaldo

## Kodmall

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
    public int MinStockLevel { get; set; }
    
    public Product(int id, string name, double price, int stock, string category, int minStock = 5)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
        Category = category;
        MinStockLevel = minStock;
    }
    
    public override string ToString()
    {
        string stockStatus = Stock <= MinStockLevel ? "⚠️ LÅGT LAGER" : "✅";
        return $"{Id}: {Name} - {Price:C} (Lager: {Stock}) {stockStatus}";
    }
}

class Program
{
    static Dictionary<int, Product> inventory = new Dictionary<int, Product>();
    static Dictionary<string, List<Product>> productsByCategory = new Dictionary<string, List<Product>>();
    static int nextProductId = 1001;
    
    static void Main(string[] args)
    {
        // Lägg till testprodukter
        AddProduct("iPhone 14", 12999.0, 15, "Elektronik", 3);
        AddProduct("Samsung TV", 8999.0, 8, "Elektronik", 2);
        AddProduct("Kaffe", 49.90, 25, "Mat", 10);
        AddProduct("Mjölk", 16.90, 12, "Mat", 5);
        AddProduct("T-shirt", 199.0, 20, "Kläder", 5);
        AddProduct("Jeans", 599.0, 7, "Kläder", 3);
        
        Console.WriteLine("=== LAGERHANTERINGSSYSTEM ===");
        
        ShowAllProducts();
        
        // Testa olika funktioner
        SearchProduct("iPhone");
        UpdateStock(1001, -5); // Sälj 5 iPhones
        UpdateStock(1003, 10);  // Fyll på kaffe
        
        ShowProductsByCategory("Elektronik");
        ShowLowStockProducts();
        ShowInventoryStats();
    }
    
    static void AddProduct(string name, double price, int stock, string category, int minStock = 5)
    {
        // Implementera här
    }
    
    static void SearchProduct(string searchTerm)
    {
        // Implementera här - sök på namn
    }
    
    static void UpdateStock(int productId, int changeAmount)
    {
        // Implementera här - positiva tal lägger till, negativa drar av
    }
    
    static void ShowAllProducts()
    {
        // Implementera här
    }
    
    static void ShowProductsByCategory(string category)
    {
        // Implementera här
    }
    
    static void ShowLowStockProducts()
    {
        // Implementera här - visa produkter under min-nivå
    }
    
    static void ShowInventoryStats()
    {
        // Implementera här - totalt värde, antal produkter, etc.
    }
}
```

#### Förväntad output

```
=== LAGERHANTERINGSSYSTEM ===

Alla produkter i lagret:
1001: iPhone 14 - 12 999,00 kr (Lager: 15) ✅
1002: Samsung TV - 8 999,00 kr (Lager: 8) ✅
1003: Kaffe - 49,90 kr (Lager: 25) ✅
1004: Mjölk - 16,90 kr (Lager: 12) ✅
1005: T-shirt - 199,00 kr (Lager: 20) ✅
1006: Jeans - 599,00 kr (Lager: 7) ✅

Söker efter 'iPhone'...
Hittade 1 matchande produkter:
1001: iPhone 14 - 12 999,00 kr (Lager: 15) ✅

Uppdaterade lager för iPhone 14: 15 → 10
Uppdaterade lager för Kaffe: 25 → 35

Produkter i kategorin 'Elektronik':
1001: iPhone 14 - 12 999,00 kr (Lager: 10) ✅
1002: Samsung TV - 8 999,00 kr (Lager: 8) ✅

⚠️ PRODUKTER MED LÅGT LAGER:
1002: Samsung TV - 8 999,00 kr (Lager: 8) ⚠️ LÅGT LAGER

📊 LAGERSTATISTIK:
Totalt antal produkttyper: 6
Totalt lagervärde: 315 526,50 kr
Genomsnittligt produktpris: 3 692,50 kr
Kategorier: Elektronik (2), Mat (2), Kläder (2)
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
    public int MinStockLevel { get; set; }
    
    public Product(int id, string name, double price, int stock, string category, int minStock = 5)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
        Category = category;
        MinStockLevel = minStock;
    }
    
    public override string ToString()
    {
        string stockStatus = Stock <= MinStockLevel ? "⚠️ LÅGT LAGER" : "✅";
        return $"{Id}: {Name} - {Price:C} (Lager: {Stock}) {stockStatus}";
    }
}

class Program
{
    static Dictionary<int, Product> inventory = new Dictionary<int, Product>();
    static Dictionary<string, List<Product>> productsByCategory = new Dictionary<string, List<Product>>();
    static int nextProductId = 1001;
    
    static void Main(string[] args)
    {
        // Lägg till testprodukter
        AddProduct("iPhone 14", 12999.0, 15, "Elektronik", 3);
        AddProduct("Samsung TV", 8999.0, 8, "Elektronik", 2);
        AddProduct("Kaffe", 49.90, 25, "Mat", 10);
        AddProduct("Mjölk", 16.90, 12, "Mat", 5);
        AddProduct("T-shirt", 199.0, 20, "Kläder", 5);
        AddProduct("Jeans", 599.0, 7, "Kläder", 3);
        
        Console.WriteLine("=== LAGERHANTERINGSSYSTEM ===");
        
        ShowAllProducts();
        
        // Testa olika funktioner
        SearchProduct("iPhone");
        UpdateStock(1001, -5); // Sälj 5 iPhones
        UpdateStock(1003, 10);  // Fyll på kaffe
        
        ShowProductsByCategory("Elektronik");
        ShowLowStockProducts();
        ShowInventoryStats();
    }
    
    static void AddProduct(string name, double price, int stock, string category, int minStock = 5)
    {
        var product = new Product(nextProductId++, name, price, stock, category, minStock);
        inventory[product.Id] = product;
        
        // Lägg till i kategoriserad lista
        if (!productsByCategory.ContainsKey(category))
        {
            productsByCategory[category] = new List<Product>();
        }
        productsByCategory[category].Add(product);
        
        Console.WriteLine($"Lade till produkt: {product.Name}");
    }
    
    static void SearchProduct(string searchTerm)
    {
        Console.WriteLine($"\nSöker efter '{searchTerm}'...");
        var matchingProducts = inventory.Values
            .Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()))
            .ToList();
        
        if (matchingProducts.Any())
        {
            Console.WriteLine($"Hittade {matchingProducts.Count} matchande produkter:");
            foreach (var product in matchingProducts)
            {
                Console.WriteLine($"  {product}");
            }
        }
        else
        {
            Console.WriteLine("Inga matchande produkter hittades.");
        }
        Console.WriteLine();
    }
    
    static void UpdateStock(int productId, int changeAmount)
    {
        if (inventory.ContainsKey(productId))
        {
            var product = inventory[productId];
            int oldStock = product.Stock;
            product.Stock += changeAmount;
            
            if (product.Stock < 0)
            {
                product.Stock = 0;
                Console.WriteLine($"⚠️ Varning: Försökte dra av mer än vad som finns i lager för {product.Name}");
            }
            
            Console.WriteLine($"Uppdaterade lager för {product.Name}: {oldStock} → {product.Stock}");
            
            if (product.Stock <= product.MinStockLevel)
            {
                Console.WriteLine($"⚠️ VARNING: {product.Name} har lågt lagersaldo ({product.Stock} kvar)!");
            }
        }
        else
        {
            Console.WriteLine($"Produkt med ID {productId} finns inte i lagret.");
        }
        Console.WriteLine();
    }
    
    static void ShowAllProducts()
    {
        Console.WriteLine("\nAlla produkter i lagret:");
        if (inventory.Count == 0)
        {
            Console.WriteLine("Lagret är tomt.");
        }
        else
        {
            foreach (var product in inventory.Values.OrderBy(p => p.Id))
            {
                Console.WriteLine($"  {product}");
            }
        }
        Console.WriteLine();
    }
    
    static void ShowProductsByCategory(string category)
    {
        Console.WriteLine($"Produkter i kategorin '{category}':");
        if (productsByCategory.ContainsKey(category))
        {
            foreach (var product in productsByCategory[category])
            {
                Console.WriteLine($"  {product}");
            }
        }
        else
        {
            Console.WriteLine($"Inga produkter i kategorin '{category}'.");
        }
        Console.WriteLine();
    }
    
    static void ShowLowStockProducts()
    {
        var lowStockProducts = inventory.Values
            .Where(p => p.Stock <= p.MinStockLevel)
            .OrderBy(p => p.Stock)
            .ToList();
        
        Console.WriteLine("⚠️ PRODUKTER MED LÅGT LAGER:");
        if (lowStockProducts.Any())
        {
            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"  {product}");
            }
        }
        else
        {
            Console.WriteLine("  Alla produkter har tillräckligt lagersaldo. ✅");
        }
        Console.WriteLine();
    }
    
    static void ShowInventoryStats()
    {
        Console.WriteLine("📊 LAGERSTATISTIK:");
        Console.WriteLine($"Totalt antal produkttyper: {inventory.Count}");
        
        if (inventory.Count > 0)
        {
            double totalValue = inventory.Values.Sum(p => p.Price * p.Stock);
            double avgPrice = inventory.Values.Average(p => p.Price);
            
            Console.WriteLine($"Totalt lagervärde: {totalValue:C}");
            Console.WriteLine($"Genomsnittligt produktpris: {avgPrice:C}");
            
            var categoryStats = productsByCategory
                .Select(kvp => new { Category = kvp.Key, Count = kvp.Value.Count })
                .OrderByDescending(x => x.Count);
            
            Console.Write("Kategorier: ");
            Console.WriteLine(string.Join(", ", categoryStats.Select(c => $"{c.Category} ({c.Count})")));
        }
        Console.WriteLine();
    }
}
```

</details>