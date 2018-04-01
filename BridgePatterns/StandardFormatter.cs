﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatterns
{
    class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}
