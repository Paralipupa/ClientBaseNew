
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class Client : ModelBase
    {
        public Client() { }

        public int Id { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }
        public Opf Opf { get; set; } // Организационно-правовая форма
        public String Inn { get; set; } // Идентификационный номер налогоплательщика
        public String Kpp { get; set; } //
        public String Ogrn { get; set; } // Основной государственный регистрационный номер
        public City City { get; set; }
        public Bank Bank { get; set; }
        public String BankRS { get; set; } // Расчётный счёт
        public String Note { get; set; }
    }
}
