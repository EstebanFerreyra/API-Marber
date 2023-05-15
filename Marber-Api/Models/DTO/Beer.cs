using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class Beer
    {
        public int Id { get; set; }
        public string BeerName { get; set;}
        public string BeerStyle { get; set; }
        public string BeerPrice { get; set; }
    }
}
