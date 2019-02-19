using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public IList<Worktime> Worktimes { get; set; }
    }
}
