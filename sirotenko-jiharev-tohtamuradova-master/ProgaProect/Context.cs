using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace ProgaProect
{
    public class Context: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
