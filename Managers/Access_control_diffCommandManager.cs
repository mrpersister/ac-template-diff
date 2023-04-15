using Access_control_diff.Plugin;
using Access_control_diff.Resources;
using System;
using VideoOS.Platform.AccessControl;
using VideoOS.Platform.AccessControl.Elements;
using VideoOS.Platform.AccessControl.Plugin;
using VideoOS.Platform.AccessControl.TypeCategories;

namespace Access_control_diff.Managers
{
    /// <summary>
    /// Handle command to control the Access Control system
    /// 
    /// The key function for this class is to execute commands being fired.
    /// 
    /// This template also suggest to have the definition of what commands are
    /// available in this class, and provide to the ConfigurationManager when needed.
    /// </summary>
    public class Access_control_diffCommandManager : ACCommandManager
    {
        private ISystem _system;

        internal Access_control_diffCommandManager(ISystem system)
        {
            _system = system;
        }

        public override ACCommandResult ExecuteCommand(string operationableInstanceId, string commandTypeId, string vmsUsername)
        {
            throw new NotImplementedException("ExecuteCommand");
        }

    }
}
