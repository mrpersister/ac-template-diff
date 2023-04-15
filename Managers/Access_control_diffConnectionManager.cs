using Access_control_diff.Plugin;
using System;
using VideoOS.Platform.AccessControl.Plugin;

namespace Access_control_diff.Managers
{
    /// <summary>
    /// This class is used when a configuration is received, checked and saved by the administrator.
    /// 
    /// It it NOT used when updating the configuration via the ConfigurationManager, as the 
    /// ACConfigurationManager is entirely used for trying to get new configurations.
    /// 
    /// Make sure to keep the accepted live systems apart from the temporary systems fetched via the ACConfigurationManager,
    /// as you may have live connections running to a system, while the administrator tries to update, but then discard the updated configuration set.
    /// </summary>
    public class Access_control_diffConnectionManager : ACConnectionManager
    {
        private ISystem _system;

        internal Access_control_diffConnectionManager(ISystem system)
        {
            _system = system;
        }

        /// <summary>
        /// When called the plugin should create the nessesary connection to the access control system in order to receive event, state changes, execute commands etc.
        /// </summary>
        public override void Connect()
        {
            throw new NotImplementedException("Connect");
        }

        /// <summary>
        /// When called the plugin should close the connection to the access control system.
        /// </summary>
        public override void Disconnect()
        {
            throw new NotImplementedException("Connect");
        }
    }
}
