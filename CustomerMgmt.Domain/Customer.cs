using System;

namespace CustomerMgmt.Domain
{
    public class Customer
    {
        public string Name { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
          
        }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }
    }
}
