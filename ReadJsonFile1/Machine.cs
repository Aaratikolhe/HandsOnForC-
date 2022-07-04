using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonFile1
{
    public class Machine
    {
        public string Name { get; set; }
        public List<PossibleActions> PossibleActions { get; set; }
        public Machine(string name, List<PossibleActions> possibleActions)
        {
            Name = name;
            PossibleActions = possibleActions;
        }
    }
}
