using CoffeeSystemDemo.Abstract;
using CoffeeSystemDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystemDemo.Adaptors
{
	public class MernisServiceAdaptor : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
			Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNumber), customer.FirstName, customer.LastName, customer.DateofBirth.Year);
			return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
		}
	}
}
