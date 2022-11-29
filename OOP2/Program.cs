using OOP2;

Individual_customer customer1 = new Individual_customer();
customer1.CustomerId = "12345";
customer1.Id = 1;
customer1.Name = "Hasan";
customer1.LastName = "Akcan";
customer1.Id_number = "1234324365";

Coorporate_customer customer2 = new Coorporate_customer();
customer2.CampnyName = "Kodlama Io";
customer2.Id = 2;
customer2.TaxNo = "1423423253";
customer2.CustomerId = "132142";

Customer customer3 = new Individual_customer();
Customer customer4 = new Coorporate_customer();

CustomerManager customer_manager = new CustomerManager();
