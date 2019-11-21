using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlowOut.Models;

namespace BlowOut.DAl
{
    //ADDED BOTH MODELS TO DBCONTEXT 
    public class ClientInstrumentContext : DbContext
    {
        public ClientInstrumentContext() : base("ClientInstrumentContext")
        {
        }

        public DbSet<Client> client { get; set; }
        public DbSet<Instrument> instrument { get; set; }
    }
}