using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.RelationShips
{
    public class Departement
    {
    }
    public class University
    {
        public List<Departement> Departements { get; set; } // Aggregation

    }
}
