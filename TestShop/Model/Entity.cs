using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Model
{
    public class Entity
    {
        private long id;
        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }
    } 

}
