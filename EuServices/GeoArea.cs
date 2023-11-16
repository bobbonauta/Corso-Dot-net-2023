using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuServices
{
    internal class GeoArea:MainState
    {
        public class Territory: State
        {
            protected string _nameTerritory;

            public Territory(string NameTerritory,
                             string FlagColour,
                             string Currency, 
                             string Army, 
                             string Constitution,
                             string Borders) 
                            :base(FlagColour,Currency,Army,Constitution,Borders)
            {
                _nameTerritory = NameTerritory;
            }
            public string NameTerritory { get { return _nameTerritory; } }

        }
    }
}
