﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSFlyMVCClient.Models
{
    public class Flight
    {
        public int FlightNo { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public double BasePrice { get; set; }
        public short? Seats { get; set; }
    }
}
