using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Project
    {
        private static int nextId = 1;
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public Client Client { get; set; }

        //default constructor
        public Project()
        {
            ProjectId = nextId;
            nextId++;
        }
    }
}
