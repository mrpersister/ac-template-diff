using Access_control_diff.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Access_control_diff.Plugin
{
    /// <summary>
    /// By explicitly implementing this interface, implementation of the abstract ACSystem can expose the actual
    /// implementations of the abstract managers, avoid unneccesary type casts.
    /// </summary>
    internal interface ISystem
    {
        Access_control_diffCommandManager CommandManager { get; }
        Access_control_diffConfigurationManager ConfigurationManager { get; }
        Access_control_diffConnectionManager ConnectionManager { get; }
        Access_control_diffCredentialHolderManager CredentialHolderManager { get; }
        Access_control_diffEventManager EventManager { get; }
        Access_control_diffStateManager StateManager { get; }
    }
}
