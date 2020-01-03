using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls.Adapters;

namespace testO
{
    class conditionOfTheContainer_CO
    {
        public String C_O()
        {
            string s = File.ReadAllText(@"C:\Users\pliki\source\repos\testO\stan.txt");
            return s;
        }
        public String temp()
        {
            string z = File.ReadAllText(@"C:\Users\pliki\source\repos\testO\temp.txt");
            return z;
        }
    }
}
