
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class Bank : ModelBase
    {
        public Bank() { }

        public int Id { get; set; }
        public String Name { get; set; } // Наименование // БАРНАУЛЬСКИЙ ФИЛИАЛ ЗАО "ТУСАРБАНК"
        public String Bik { get; set; } // Банковский идентификационный код // 040173745
        public String CorrAccount { get; set; } // Корреспондентский счёт // 30101810800000000745
    }
}
