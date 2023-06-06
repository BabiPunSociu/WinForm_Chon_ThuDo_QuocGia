using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Trang71
{
    internal class Country_Capital
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public Country_Capital(string country,string capital)
        {
            Country = country;
            Capital = capital;
        }
    }
}
