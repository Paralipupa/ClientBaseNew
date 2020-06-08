
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class Region : ModelBase
    {
        public Region() { }

        public int Id { get; set; }
        public int Number { get; set; }
        public String Name { get; set; }
    }
}
