using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace PlcHammerConnector
{
    public class Entry
    {
        public static PlcHammer.PlcHammerTwinController PlcHammer { get; } = new PlcHammer.PlcHammerTwinController(Tc3ConnectorAdapter.Create(851));
    }
}
