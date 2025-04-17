using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Buildder
{
    public class Customer
    {
        private string name;
        private string phone;
        private string address;
        private string city;
        private string state;
        private string zip;

        public string Name {  get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public string Zip { get { return zip; } set { zip = value; } }

    }
}
