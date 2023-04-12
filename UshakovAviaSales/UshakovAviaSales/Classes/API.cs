using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UshakovAviaSales.Classes
{
    public static class API
    {
        public static readonly HotelClient Client = new HotelClient();

        public static List<Result> Results { get; set; }
    }
}
