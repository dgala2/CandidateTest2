using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMgmt.Domain;
using NUnit.Framework;

namespace CustomerMgmt.Tests
{
    [TestFixture]
    public class CustomerTests
    {


        [Test]
        public void Test_Age_Calcualtor()
        {
            //Arrange
            var cust = new Customer {Name = "TestName1", DateOfBirth = Convert.ToDateTime("12/12/1974"), Gender = "M"};

            //Act
            var actualAge = cust.Age;

            //Assert

            Assert.AreEqual(actualAge, 44);


        }

        [Test]
        public void Test_Average_Age_Of_FeMale_Customers()
        {

            // Arrange
            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "TestName1",  DateOfBirth = Convert.ToDateTime("12/12/2000"), Gender = "M"},
                new Customer {Name = "TestName2",  DateOfBirth = Convert.ToDateTime("12/12/2010"), Gender = "F"},
                new Customer {Name = "TestName3",  DateOfBirth = Convert.ToDateTime("12/12/1990"), Gender = "M"},
                new Customer {Name = "TestName4",  DateOfBirth = Convert.ToDateTime("12/12/1980"), Gender = "F"}

            };

            //Act


            //Assert


        }


        [Test]
        public void Test_Average_Age_Of_Male_Customers()
        {
            
        }
    }
}
