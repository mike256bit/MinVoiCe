﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public Client Client { get; set; }
    }
}