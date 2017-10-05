using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class Customer {
        
        public Customer(string name, int id) {
            this.Name = name;
            this.Id = id;
        }

        public string Name {
            set; get;
        }

        public int Id {
            set; get;
        }
    }
}
