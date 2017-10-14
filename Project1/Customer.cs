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

        public string Name {
            set; get;
        }
    }
}
