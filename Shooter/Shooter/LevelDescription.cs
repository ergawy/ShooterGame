﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter
{
    class LevelDescription
    {
        // Time a level lasts in seconds.
        public double Time { get; set; }

        public string LevelFile { get; set; }

        public string LevelName { get; set; }
    }
}
