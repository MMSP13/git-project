using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Model
{
    public class Университет : Entity
    {
        private string название;
        public virtual string Название
        {
            get { return название; }
            set { название = value; }
        }

        private ISet<Факультет> Факультеты = new HashSet<Факультет>();
        public virtual ISet<Факультет> факультеты
        {
            get { return Факультеты; }
            set { Факультеты = value; }
        }
    }
}
