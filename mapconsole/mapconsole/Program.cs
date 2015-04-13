using NETMapnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorTile vt = new VectorTile(1, 0, 0);
            vt.AddGeoJSON("{}", "layer0");
        }
    }
}
