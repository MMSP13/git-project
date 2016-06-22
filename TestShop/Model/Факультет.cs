using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Model
{
    public class Факультет : Entity
    {
        private string название;
        public virtual string Название
        {
            get { return название; }
            set { название = value; }
        }


     private Университет IdУниверситет;
        public virtual Университет idУниверситет
        {
            get { return IdУниверситет; }
            set { IdУниверситет = value; }
        }
    }
}
