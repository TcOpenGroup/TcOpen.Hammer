using PlcHammerConnector;
using Vortex.Presentation;

namespace PlcHammer.Hmi
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            SwiftRecorderViewModel = new TcOpen.Inxton.Swift.Wpf.SwiftRecorderViewModel(PlcHammer.TECH_MAIN._app._station001);
        }
        public PlcHammer.PlcHammerTwinController PlcHammer { get { return Entry.PlcHammer; } }

        public TcOpen.Inxton.Swift.Wpf.SwiftRecorderViewModel SwiftRecorderViewModel { get; }
    }
}
