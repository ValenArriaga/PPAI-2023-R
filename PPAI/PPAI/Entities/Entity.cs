using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public abstract class Entity
    {
        protected int id;

        public int Id { get => id; set => id = value; }
    }
}
