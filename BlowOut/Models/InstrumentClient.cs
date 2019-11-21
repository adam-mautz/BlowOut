using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class InstrumentClient
    {
        public Client client { get; set; }
        public Instrument instrument { get; set; }
    }
}