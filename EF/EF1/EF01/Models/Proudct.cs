using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Models
{
    public class Proudct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Catageory Catageory { get; set; }
    }
}
