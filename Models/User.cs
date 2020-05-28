
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBase
{
    class User : BaseModel
    {
        public User() { }

        public String Login { get; set; }
        public String Password { get; set; }
    }
}
