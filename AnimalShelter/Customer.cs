using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;

       public Customer(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this._Age = age;

            this._IsQualified = age >= 18;
        }

        public int Age
        {
            get { return _Age; }
            set 
            {
                _Age = value;
                _IsQualified = value >= 18;
            }
        }

        public bool IsQualified
        {
            get 
            { 
                return _IsQualified; 
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
