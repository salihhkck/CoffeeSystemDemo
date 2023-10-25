using CoffeeSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystemDemo.Abstract
{
	public interface ICustomerService
	{
		void Save(Customer customer);
	}
}
