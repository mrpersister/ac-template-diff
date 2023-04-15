using Access_control_diff.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using VideoOS.Platform.AccessControl.Plugin;

namespace Access_control_diff.Plugin
{
    /// <summary>
    /// The ACPlugin contains identification and static information about one 
    /// Access Control plugin.
    /// 
    /// When new instances of a Plugin is created, this class will assist with relevant 
    /// system level properties, and validate them after user entry.
    /// 
    /// The Properties defined in this class are presented in the management client/administrator 
    /// when adding and modifying access control systems.
    /// </summary>
    public class Access_control_diffPlugin : ACPlugin
    {
        #region Fields
        private List<ACPropertyDefinition> _propertyDefinitions = new List<ACPropertyDefinition>();
        private List<ACCategoryInfo> _categories = new List<ACCategoryInfo>();
        private List<ACIconInfo> _icons = new List<ACIconInfo>();
        #endregion

        #region Properties
        public override Guid Id
        {
            get { return new Guid("1e69870a-5ef0-46b2-84c5-239e0736ebf4"); }
        }

        public override string Name
        {
            get { return AssemblyInfo.ProductNameShort; }
        }

        public override Version Version
        {
            get { return new Version(AssemblyInfo.Version); }
        }

        public override string VersionText
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

        public override Image Icon
        {
            get { return null; }
        }
        #endregion

        /// <summary>
        /// Initialize static information relevant for this plugin, e.g. the access control systems supported by this plugin.
        /// 
        /// Implementing Icons and Categories is optional, but the property definition is required.
        /// 
        /// Could be something like:
        /// <code>            
        ///     _propertyDefinitions = new List<ACPropertyDefinition>()
        ///                               {
        ///                                   new ACPropertyDefinition("Address", "Address of my access control system",
        ///                                                            "1.2.3.4", ACImportance.Required, false,
        ///                                                            StringResources.AddressToolTip,
        ///                                                            ACValueTypes.StringType, new List<ACProperty>()),
        ///                                   new ACPropertyDefinition("Port", "Port", "80",
        ///                                                            ACImportance.Required, false,
        ///                                                            StringResources.PortToolTip, ACValueTypes.IntType,
        ///                                                            new List<ACProperty>()),
        ///                                   new ACPropertyDefinition("Username", "Username",
        ///                                                            "john", ACImportance.Required, false,
        ///                                                            StringResources.UserNameToolTip,
        ///                                                            ACValueTypes.StringType, new List<ACProperty>()),
        ///                                   new ACPropertyDefinition("Password", "Password",
        ///                                                            "doe", ACImportance.Required, false,
        ///                                                            StringResources.PasswordToolTip,
        ///                                                            ACValueTypes.PasswordStringType,
        ///                                                            new List<ACProperty>())
        ///                               };
        /// </code>
        /// </summary>
        public override void Init()
        {
            throw new NotImplementedException("Init");
        }

        public override void Close()
        {
            throw new NotImplementedException("Close");
        }

        /// <summary>
        /// Return icons to be used on maps
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ACIconInfo> GetIcons()
        {
            return new ReadOnlyCollection<ACIconInfo>(_icons);
        }

        /// <summary>
        /// The extra categories defined in this plugin.<br>
        /// Categories are used to make event to action mapping easier.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ACCategoryInfo> GetCategories()
        {
            return new ReadOnlyCollection<ACCategoryInfo>(_categories);
        }

        /// <summary>
        /// Return the definition of the properties required to connect to the Access Control
        /// system supported by this plugin.
        /// 
        /// Some of the properties can be defined as required (in the Importance field), and will
        /// be displayed as the administartor add a system.<br>
        /// Other properties can be defined as optional, and will appear on on the system setup tab after
        /// the system has been added.
        /// 
        /// Field validation can defined to some degree on each property, field validation can also
        /// be implemented in the ValidateProperties in this class.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ACPropertyDefinition> GetPropertyDefinitions()
        {
            return new ReadOnlyCollection<ACPropertyDefinition>(_propertyDefinitions);
        }

        /// <summary>
        /// Validates the properties entered by the administrator, and provide feedback.
        /// 
        /// Simple field validation can be defined together with the field, while 
        /// validation of relation between multiple fields can be done in this method.
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        public override ACPropertyValidationResult ValidateProperties(IEnumerable<ACProperty> properties)
        {
            throw new NotImplementedException("ValidateProperties");
        }

        /// <summary>
        /// Create a new ACSystem with all managers.
        /// The content of the classes at this point is empty.
        /// 
        /// The content will be provided on the class's Init methods. This can be an old configuration from last
        /// execution, or an empty one when create a new one.
        /// </summary>
        /// <remarks>Multiple Access Control system can be created by the administrator.</remarks>
        /// <returns>An empty container for Access_control_diff type of access control system.</returns>
        public override ACSystem GenerateAccessControlSystem()
        {
            return new Access_control_diffSystem();
        }

    }
}
