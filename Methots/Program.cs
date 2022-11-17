using Methots;

Product Product1 = new Product();
Product1.productName = "Apple";
Product1.price = 15.00;
Product1.aboutProduct = "amasya apple";

Product Product2 = new Product();
Product2.productName = "Watermelon";
Product2.price = 80;
Product2.aboutProduct = "Diyarbakır Watermelon";

Product[] products = new Product[] { Product1, Product2 };

// Type safe - veri tiipi belirtilmeli.

foreach (Product product in products)
{
    Console.WriteLine(product.productName);
    Console.WriteLine(product.price);
    Console.WriteLine(product.aboutProduct);
    Console.WriteLine("-------------------------");
}

Console.WriteLine("--------------------------------\nMethods:");

SepetManager sepetManager = new SepetManager();
sepetManager.Add(Product1);
sepetManager.Add(Product2);

sepetManager.add2("Armut", 12, "Yeşil armut", 10);
sepetManager.add2("elma", 14, "Amasya ekmasu", 9);
sepetManager.add2("Karpuz", 10, "diyarbakır karpuzu", 8);
