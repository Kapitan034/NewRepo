using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaProect
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Otchestvo { get; set; }
        public DateTime BirthDate { get; set; }
        public Int64 PasportNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Room Room { get; set; }
    }
}
