using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class Customer {
        private string name;
        private int id;

        public Customer(string name, int id) {
            this.name = name;
            this.id = id;
        }

        public string Name {
            set; get;
        }

        public int Id {
            set; get;
        }
    }
}
