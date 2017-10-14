using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class BaseObject
    {
        public BaseObject(PrimaryKey primaryKey) {
            this.PrimaryKey = primaryKey;
        }

        public PrimaryKey PrimaryKey {
            get; set;
        }
    }
}
