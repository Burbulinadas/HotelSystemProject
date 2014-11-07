using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemProgramShell.Classes
{
    class CommonData
    {
        static CommonData()
        {
            Context = new HotelDBEntities();
        }
        public static HotelDBEntities Context { get; set; }
    }
}
