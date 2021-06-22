using PlcHammer;
using PlcHammerConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TcOpen.Inxton.Abstractions.Data;
using TcOpen.Inxton.MongoDb;

namespace HMI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            TcOpen.Inxton.TcoAppDomain.Current.Builder
                .SetUpLogger(new TcOpen.Inxton.Logging.SerilogAdapter())
                .SetDispatcher(TcoCore.Wpf.Threading.Dispatcher.Get);



            Entry.PlcHammer.Connector.ReadWriteCycleDelay = 200;
            Entry.PlcHammer.Connector.BuildAndStart();

            var mongoUri = "mongodb://localhost:27017";
            var databaseName = "Hammer";
            var collectionName = "HammerCollection";
            var mongoSettings = new MongoDbRepositorySettings<PlainStation001_ProductionData>(mongoUri,databaseName,collectionName);
            var repository = new MongoDbRepository<PlainStation001_ProductionData>(mongoSettings);
            Entry.PlcHammer.MAIN._app._station001._dataManager.InitializeRepository(repository);
        }
    }
}
