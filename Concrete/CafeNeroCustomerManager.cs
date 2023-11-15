using CoffeeSystemDemo.Abstract;
using CoffeeSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystemDemo.Concrete
{
	public class CafeNeroCustomerManager :BaseCustomerManager
	{
		ICustomerCheckService _customerCheckService;

		public CafeNeroCustomerManager(ICustomerCheckService customerCheckService)
		{
			_customerCheckService = customerCheckService;
		}

		public override void Save(Customer customer)
		{
			if (_customerCheckService.CheckIfRealPerson(customer))
			{
				base.Save(customer);
			}
			else
			{
				throw new Exception("Not a valid person");
			}
		}
	}
}
