using CoffeeSystemDemo.Abstract;
using CoffeeSystemDemo.Adaptors;
using CoffeeSystemDemo.Concrete;

namespace CoffeeSystemDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new CafeNeroCustomerManager(new MernisServiceAdaptor());
			customerManager.Save(new Entities.Customer { DateofBirth = new DateTime(1990, 8, 15), FirstName = "ss", LastName = "sss", IdentityNumber = "1111111" });

			Console.ReadLine();
		}
	}
}