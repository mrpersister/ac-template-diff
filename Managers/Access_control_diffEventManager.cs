using Access_control_diff.Plugin;
using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VideoOS.Platform;
using VideoOS.Platform.AccessControl.Elements;
using VideoOS.Platform.AccessControl.Plugin;
using VideoOS.Platform.AccessControl.TypeCategories;

namespace Access_control_diff.Managers
{
    public delegate void AccessControllerConnectedStateChange(Uri uri, bool connected);

    /// <summary>
    /// All events coming from the Access Control System should be converted to a ACEvent using the 
    /// available ACEventTypes.
    /// </summary>
    public class Access_control_diffEventManager : ACEventManager
    {
        private ISystem _system;

        internal Access_control_diffEventManager(ISystem system)
        {
            _system = system;

            //Sugestion: start your background thread here to receive events from your 
            //      access control system (perhaps controlled by the connection manager?)

            // All new events should be converted into ACEvent, and forwarded into the MIP AC framework
            //      via a call to the base method:
            //         protected void FireEventsOccurred(IEnumerable<ACEvent> acEvents)

        }

    }
}
