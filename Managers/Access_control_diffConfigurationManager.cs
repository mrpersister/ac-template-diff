using Access_control_diff.Plugin;
using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using VideoOS.Platform.AccessControl;
using VideoOS.Platform.AccessControl.Elements;
using VideoOS.Platform.AccessControl.Plugin;
using VideoOS.Platform.AccessControl.TypeCategories;

namespace Access_control_diff.Managers
{
    /// <summary>
    /// The configuration manager is responsible for getting and applying access control configuration.
    /// 
    /// 2 sets of configuration can be managed at one time (per instance), the running configuration and
    /// a new configuration.
    /// The new coniguration need to be accepted by the administrator before applied, and should NOT be 
    /// applied automatically.
    /// </summary>
    public class Access_control_diffConfigurationManager : ACConfigurationManager
    {
        private ISystem _system;

        #region property values

        // Suggestion: place your key properties here, like Address, username, password for your system

        #endregion

        internal Access_control_diffConfigurationManager(ISystem system, ACConfiguration configuration)
        {
            _system = system;

            // Store configurtion
        }

        public override void ApplyConfiguration(ACConfiguration configuration)
        {
            throw new NotImplementedException("ApplyConfiguration");
        }

        #region Fetch configuration

        /// <summary>
        /// When called the plugin should start a fetch configuration process. The call should be ignored if an existing 
        /// process is ongoing. 
        /// 
        /// The plugin should call the FireFetchConfigurationStatusChanged() method to signal changes to the fetch 
        /// configuration status (progress).
        /// 
        /// Note that call to this method is made independent of the Connect() and Disconnect() 
        /// calls to the connection manager, and should therefore be handle independently by the plugin.
        /// 
        /// When a new configuration has been fetched, the base method FireFetchConfigurationStatusChanged should be called 
        /// containing the new configuration. (Do NOT apply the configuration to your running instance).
        /// 
        /// If the administrator accepts the configuration, the ApplyConfiguration method is called, if he discards the configuration
        /// is just thrown away and current running instance is excepted to unchanged.
        /// 
        /// If the administrator decide to cancel the fetching, the CancelFetchConfiguration is called, and the background thread should 
        /// send one more FireFetchConfigurationStatusChanged() to indicate 
        /// </summary>
        public override void StartFetchConfiguration()
        {
            throw new NotImplementedException("StartFetchConfiguration");
            // Suggestion: start a new thread that connects to access control system and get configuration
        }

        public override void CancelFetchConfiguration()
        {
            throw new NotImplementedException("CancelFetchConfiguration");
            // Suggestion: set a flag to let the background thread stop its operation
        }

        #endregion

    }
}
