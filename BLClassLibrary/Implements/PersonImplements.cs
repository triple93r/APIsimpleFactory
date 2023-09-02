using BLClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLClassLibrary.Implements
{
    public class PersonImplements : IPersons, IHike
    {
        public string GetFirstName(string firstName)
        {
            firstName = firstName + " DonBoscho School";
            return firstName;
        }
        public string GetLastName(string lastName)
        {
            return lastName;
        }

        public decimal GetIncrement(int amount)
        {
            return amount = (int)Convert.ToDecimal(amount + (amount * 0.10));
        }

    }
}
