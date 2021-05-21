using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Presentation.Wpf;

namespace PlcHammer
{
    public class DriveSimViewModel : RenderableViewModel
    {
        public override object Model { get; set; } = new PlcHammer.DriveSim();
    }
}
