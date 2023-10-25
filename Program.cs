using CoffeeSystemDemo.Abstract;
using CoffeeSystemDemo.Adaptors;
using CoffeeSystemDemo.Concrete;

namespace CoffeeSystemDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdaptor());
			customerManager.Save(new Entities.Customer { DateofBirth = new DateTime(1998, 8, 15), FirstName = "Büşra", LastName = "Küçük", IdentityNumber = "70663020172" });

			Console.ReadLine();
		}
	}
}