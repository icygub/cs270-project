using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class Customer : BaseObject {

        public Customer(string name, int id) : base(id) {
            this.Name = name;
        }

        public Customer(string name, int id, Address address, string email) : base(id) {
            this.Name = name;
            this.Address = address;
            this.Email = email;
        }

        public string Name {
            set; get;
        }

        public Address Address {
            get; set;
        }

        public string Email {
            get; set;
        }
    }

    public class Address {
        public Address(string street, string city, string state, int zipCode) {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public string Street {
            get; set;
        }

        public string City {
            get; set;
        }

        public string State {
            get; set;
        }

        public int ZipCode {
            get; set;
        }
    }
}
