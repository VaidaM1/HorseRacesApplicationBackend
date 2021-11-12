﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Entities
{
    public class Better
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Bet { get; set; }
        public int? HorseId { get; set; }
        public Horse Horse { get; set; }

    }
}
