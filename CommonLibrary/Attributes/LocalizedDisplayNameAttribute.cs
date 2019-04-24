using System.ComponentModel;
using System.Threading;
using System.Globalization;

namespace CommonLibrary.Attributes
{
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        private readonly string resourceName;
        public LocalizedDisplayNameAttribute(string resourceName)
            : base()
        {
            this.resourceName = resourceName;
        }

        public override string DisplayName
        {
            get
            {
                return Resources.Localization.Language.ResourceManager.GetString(resourceName);
            }
        }
    }
}
