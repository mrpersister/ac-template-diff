using Access_control_diff.Plugin;
using System;
using System.Collections.Generic;
using System.Globalization;
using VideoOS.Platform;
using VideoOS.Platform.AccessControl.Plugin;

namespace Access_control_diff
{
    /// <summary>
    /// The ACPLuginDefinition contains identification information about the plugin, 
    /// as well as provide a list of the actual Access Control plugins supported
    /// by this module.
    /// 
    /// Multiple Access Control systems can be supported within one ACPluginDefinition.
    /// Each ACPlugin has identification information in their classes.
    /// </summary>
    public class Access_control_diffACPluginDefinition : ACPluginDefinition
    {
        private List<ACPlugin> _accessControlPlugins = new List<ACPlugin>();

        /// <summary>
        /// The Guid identifying this ACPluginDefinition
        /// </summary>
        public override Guid Id
        {
            get { return new Guid("15417f36-538f-4f29-9f23-e7dde6ebbb3e"); }
        }

        /// <summary>
        /// Name of the plugin
        /// </summary>
        public override string Name
        {
            get { return AssemblyInfo.ProductNameShort; }
        }

        /// <summary>
        /// Company owning the plugin
        /// </summary>
        public override string Manufacturer
        {
            get { return AssemblyInfo.CompanyName; }
        }

        /// <summary>
        /// Version of the plugin
        /// </summary>
        public override string VersionString
        {
            get
            {
                // Create revision letter (1 = a, 2 = b, etc.)
                int revision;
                return (int.TryParse(AssemblyInfo.Revision, out revision) && revision > 0 && revision < 27)
                    ? string.Format(CultureInfo.InvariantCulture, "{0}.{1}{2}", AssemblyInfo.Major, AssemblyInfo.Minor, (char)('a' + revision - 1))
                    : string.Format(CultureInfo.InvariantCulture, "{0}.{1}", AssemblyInfo.Major, AssemblyInfo.Minor);
            }
        }

        /// <summary>
        /// One or more plugins provided by this dll.
        /// 
        /// If an access control system exists in different versions that e.g. require different communication methods.
        /// It could be an idea to split it into multiple plugins, and let the administrator select the correct one.
        /// </summary>
        public override List<ACPlugin> ACPlugins
        {
            get { return _accessControlPlugins; }
        }

        /// <summary>
        /// Initialize the plugin definition.
        /// </summary>
        /// <remarks>Each plugin is initialized at some later point</remarks>
        public override void Init()
        {
            _accessControlPlugins.Add(new Access_control_diffPlugin());
        }

        public override void Close()
        {
            _accessControlPlugins.Clear();
        }
    }
}
