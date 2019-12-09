using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class InstrumentClient
    {
        public IEnumerable<Client> clients { get; set; }
        public IEnumerable<Instrument> instruments { get; set; }
    }
}