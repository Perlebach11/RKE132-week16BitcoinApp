﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16BitcoinApp
{
    public class BitCoinRate
    {
        public bpi bpi { get; set; }
    }


    public class bpi
    {
        public EUR EUR { get; set; }
    }


    public class EUR
    {
         public string code {  get; set; }
        public float rate_float { get; set; }
    }
}
