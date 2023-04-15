using Access_control_diff.Plugin;
using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using VideoOS.Platform;
using VideoOS.Platform.AccessControl;
using VideoOS.Platform.AccessControl.Elements;
using VideoOS.Platform.AccessControl.Plugin;
using VideoOS.Platform.AccessControl.TypeCategories;

namespace Access_control_diff.Managers
{
    /// <summary>
    /// All state management are handled in this class.  
    /// This includes providing current state, and change to current state.
    /// 
    /// The state changes are forwarded from this class to the MIP AC Framework.
    /// 
    /// Typical state handling could be a change in server up/down, 
    /// changes in door transition between open/closed/locked/unlocked
    /// 
    /// State changes are forwarded to the MIP AC Framework by calling the base method:
    /// <code>
    ///     ACState acState = new ACState("Door120", new List<string> { "DoorOpenId" }, ACBuiltInIconKeys.DoorOpen, null);
    ///     List<ACState> acStates = new List<ACState>() { acState };
    ///     FireStatesChanged(acStates);
    /// </code>
    /// </summary>
    public class Access_control_diffStateManager : ACStateManager
    {
        private ISystem _system;

        internal Access_control_diffStateManager(ISystem system)
        {
            _system = system;

            // Suggestion: consider to start a background thread updating states, or link with the EventManager
            //      to extract this information.
            //

        }

        /// <summary>
        /// Called by system to get the initial state for a given set of units.
        /// </summary>
        /// <param name="operationableInstanceIds"></param>
        /// <returns></returns>
        public override IEnumerable<ACState> GetStates(IEnumerable<string> operationableInstanceIds)
        {
            throw new NotImplementedException("GetStates");
        }

    }
}
