﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string PointOfContact { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCityZip { get; set; }

        public IList<Project> Projects { get; set; }

    }


}
