
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class City : BaseModel
    {
        public City() { }

        public int Id { get; set; }
        public String Name { get; set; }
    }
}
