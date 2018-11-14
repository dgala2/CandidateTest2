using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMgmt.Domain;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
             // DI Container 
            TinyIoC.TinyIoCContainer.Current.Register<ICalculator, Calculator>();
            var calc = TinyIoC.TinyIoCContainer.Current.Resolve<ICalculator>();

            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "TestName1",  DateOfBirth = Convert.ToDateTime("12/12/2000"), Gender = "M"},
                new Customer {Name = "TestName2",  DateOfBirth = Convert.ToDateTime("12/12/2010"), Gender = "F"},
                new Customer {Name = "TestName3",  DateOfBirth = Convert.ToDateTime("12/12/1990"), Gender = "M"},
                new Customer {Name = "TestName4",  DateOfBirth = Convert.ToDateTime("12/12/1980"), Gender = "F"}

            };


            var avgAge = calc.CalculateAverageAge(customers);

            Console.WriteLine($"Average Age Of Customers: {avgAge}");
        }
    }
}
