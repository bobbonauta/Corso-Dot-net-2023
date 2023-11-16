using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuServices
{
    internal class EuRegion:MainState
    {
        public class EuRegionLocal:State
        {
            public EuRegionLocal(
                string FlagColour,
                string Currency,
                string Army,
                string Constitution,
                string Borders)
              : base(FlagColour, Currency, Army, Constitution, Borders)
            {

            }
        }
        

    }
}
