using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeff.BeerDrinkers.Domain.Types
{
    public class Beer
    {
        public string name { get; set; }
        public string kind { get; set; }
        public decimal percentage { get; set; }
    }
}
