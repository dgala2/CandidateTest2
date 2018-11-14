using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMgmt.Domain;

namespace CustomerManagement
{
    public class Calculator : ICalculator
    {
        public double CalculateAverageAge(List<Customer> customers)
        {
            return customers.Average(s => s.Age);
        }
    }

    public interface ICalculator
    {
        double CalculateAverageAge(List<Customer> customers);
       

    }
}
