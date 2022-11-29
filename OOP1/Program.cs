using OOP1;

Product Product1 = new Product();
Product1.Id = 1;
Product1.CategoryId = 2;   
Product1.ProductName = "Masa";
Product1.UnitPrice = 500;
Product1.UnitInStock = 3;

Product product2 = new Product { Id= 2, CategoryId = 5, UnitInStock= 5, ProductName = "kalem", UnitPrice = 35};

ProductManager productManager = new ProductManager();
productManager.Add(product2);
productManager.Add(Product1);

