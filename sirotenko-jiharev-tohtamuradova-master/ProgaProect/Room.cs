using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgaProect
{
    public class Room
    {
        public int id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        //public double Price { get; set; }//цена, вероятно, не нужна
        public bool Zanat { get; set; }
    }
}
