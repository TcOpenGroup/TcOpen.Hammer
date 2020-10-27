using PlcHammerConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI
{
    public class MainWindowViewModel
    {
        public PlcHammer.PlcHammerTwinController PlcHammer { get { return Entry.PlcHammer; } }
    }
}
