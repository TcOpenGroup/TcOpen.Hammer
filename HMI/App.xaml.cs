using PlcHammerConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HMI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Entry.PlcHammer.Connector.BuildAndStart().ReadWriteCycleDelay = 75;
                
        }
    }
}
