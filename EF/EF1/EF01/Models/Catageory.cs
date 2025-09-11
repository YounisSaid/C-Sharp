using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Models
{
    public class Catageory
    {
        public int CatageoryId { get; set; }
        public string CatageoryName { get; set; }

        public ICollection<Proudct> Proudcts { get; set; }
    }
}
