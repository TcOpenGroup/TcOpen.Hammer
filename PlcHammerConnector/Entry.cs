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
        const string AmsId = "172.20.10.2.1.1";

        public static PlcHammer.PlcHammerTwinController PlcHammer { get; } = new PlcHammer.PlcHammerTwinController(Tc3ConnectorAdapter.Create(AmsId, 851, true));
    }
}
