
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class Opf : ModelBase
    {
        public Opf() { }

        public int Id { get; set; }
        public String ShortName { get; set; } // Краткое наименование // ОАО
        public String Name { get; set; } // Полное наименование // ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО
    }
}
