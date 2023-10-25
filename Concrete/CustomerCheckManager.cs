using CoffeeSystemDemo.Abstract;
using CoffeeSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystemDemo.Concrete
{
	public class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;
		}
	}
}
