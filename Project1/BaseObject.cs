using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class BaseObject
    {
        public BaseObject(int primaryKey) {
            PrimaryKey = primaryKey;
        }

        public int PrimaryKey {
            get; set;
        }
    }
}
