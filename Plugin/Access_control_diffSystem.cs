using Access_control_diff.Managers;
using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using VideoOS.Platform.AccessControl.Plugin;

namespace Access_control_diff.Plugin
{
    /// <summary>
    /// A container class for all other key classes.
    /// </summary>
    public class Access_control_diffSystem : ACSystem, ISystem
    {
        #region Fields
        private Access_control_diffConnectionManager _connectionManager;
        private Access_control_diffConfigurationManager _configurationManager;
        private Access_control_diffCredentialHolderManager _credentialHolderManager;
        private Access_control_diffCommandManager _commandManager;
        private Access_control_diffStateManager _stateManager;
        private Access_control_diffEventManager _eventManager;
        private List<ACExternalCommand> _externalCommands = new List<ACExternalCommand>();
        #endregion

        #region ACSystem Properties
        public override ACConnectionManager ConnectionManager
        {
            get { return _connectionManager; }
        }
        public override ACConfigurationManager ConfigurationManager
        {
            get { return _configurationManager; }
        }
        public override ACCredentialHolderManager CredentialHolderManager
        {
            get { return _credentialHolderManager; }
        }
        public override ACCommandManager CommandManager
        {
            get { return _commandManager; }
        }
        public override ACStateManager StateManager
        {
            get { return _stateManager; }
        }
        public override ACEventManager EventManager
        {
            get { return _eventManager; }
        }
        public override IEnumerable<ACExternalCommand> ExternalCommands
        {
            get { return _externalCommands; }
        }
        #endregion

        #region ISystem Members
        // Explicit interface implementation (not returning the base class) avoids typecasts by consumer
        Access_control_diffConnectionManager ISystem.ConnectionManager
        {
            get { return _connectionManager; }
        }
        Access_control_diffConfigurationManager ISystem.ConfigurationManager
        {
            get { return _configurationManager; }
        }
        Access_control_diffCredentialHolderManager ISystem.CredentialHolderManager
        {
            get { return _credentialHolderManager; }
        }
        Access_control_diffCommandManager ISystem.CommandManager
        {
            get { return _commandManager; }
        }
        Access_control_diffStateManager ISystem.StateManager
        {
            get { return _stateManager; }
        }
        Access_control_diffEventManager ISystem.EventManager
        {
            get { return _eventManager; }
        }
        #endregion

        /// <summary>
        /// Initialize the system, with an old configuration, saved from last execution, or an almost empty one when
        /// new system is created.
        /// </summary>
        /// <param name="configuration"></param>
        public override void Init(ACConfiguration configuration)
        {
            _connectionManager = new Access_control_diffConnectionManager(this);
            _configurationManager = new Access_control_diffConfigurationManager(this, configuration);
            _credentialHolderManager = new Access_control_diffCredentialHolderManager(this);
            _commandManager = new Access_control_diffCommandManager(this);
            _stateManager = new Access_control_diffStateManager(this);
            _eventManager = new Access_control_diffEventManager(this);
        }

        public override void Close()
        {
            throw new NotImplementedException("Close");
        }

        /// <summary>
        /// This method sets the properties relevant for connecting to an Access Control system.
        /// If any properties are incorrect, Exception can be thrown.
        /// </summary>
        /// <param name="properties"></param>
        public override void SetProperties(IEnumerable<ACProperty> properties)
        {
            throw new NotImplementedException("SetProperties");
        }
    }
}
