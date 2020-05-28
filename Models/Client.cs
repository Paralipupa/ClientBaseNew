
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class Client : BaseModel
    {
        public Client() { }

        public int Id { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }
        public String Opf { get; set; } // Код
        public String Inn { get; set; }
        public String Kpp { get; set; }
        public String Orgn { get; set; }
        public City City { get; set; }
        public String Bank { get; set; } // Код
        public String Note { get; set; }
        // БанкРС?
    }
}
