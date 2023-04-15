using Access_control_diff.Plugin;
using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using VideoOS.Platform.AccessControl.Plugin;

namespace Access_control_diff.Managers
{
    /// <summary>
    /// Manages card holders, their credentials and card numbers.<br>
    /// A cache mechanism should be implemented, as the GetCredentialHolder will be called
    /// many times during Smart Client operations.<br>
    /// If the Access Control system has images of each card holder, these images should be 
    /// fetched and cached as well.  They will be displyed in the preview window when an event with a xx property is selected.
    /// </summary>
    public class Access_control_diffCredentialHolderManager : ACCredentialHolderManager
    {
        private ISystem _system;

        /// <summary>
        /// Return true to enable that credential holder images can be set/changed in the XProtect management client.
        /// </summary>
        public override bool CredentialHolderImageOverrideEnabled
        {
            get
            {
                throw new NotImplementedException("CredentialHolderImageOverrideEnabled");
            }
        }

        /// <summary>
        /// Return true if the plugin supports searching for credential holder.
        /// </summary>
        public override bool CredentialHolderSearchSupported
        {
            get
            {
                throw new NotImplementedException("CredentialHolderSearchSupported");
            }
        }

        internal Access_control_diffCredentialHolderManager(ISystem system)
        {
            _system = system;
        }

        /// <summary>
        /// Get specified credential holder.<br>
        /// This is usually the result of the FireCredentialHoldersChanged event,
        /// which is fired by the periodic credential holder update.
        /// Therefore the cache is always used to find the result.
        /// </summary>
        /// <param name="credentialHolderId"></param>
        /// <returns></returns>
        public override ACCredentialHolder GetCredentialHolder(string credentialHolderId)
        {
            throw new NotImplementedException("GetCredentialHolder");
        }

        /// <summary>
        /// Get the credential holder, that match the specified search string.
        /// The cache is updated, if it's more than a minute old.
        /// Normally the cache is only updated once every 10 minutes.
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="searchLimit"></param>
        /// <returns></returns>
        public override ACCredentialHolderSearchResults SearchCredentialHolders(string searchString, int searchLimit)
        {
            throw new NotImplementedException("SearchCredentialHolders");
        }

    }
}
