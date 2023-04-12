using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UshakovAviaSales.DataFD;

namespace UshakovAviaSales.Classes
{
    class DataClass
    {
        public static Entities1 context = new Entities1();
        public static int idDestinationel;
        public static int idClientBase;
        public static bool isManager;
    }
}
