﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Command
    {
        public String CommandWord { get; set; }
        public String SecondWord { get; set; }
        public Boolean IsUnknown { get { return (CommandWord == null); } }
    }
}
