using System.Configuration;
using System.Linq;
using System.Reflection;
using WinLossRecorder.Properties;

namespace WinLossRecorder
{
    internal class AppUtils
    {
        public static ExtendedVersion.ExtendedVersion GetVersion()
        {
            var attribute =
                (AssemblyInformationalVersionAttribute) Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false).FirstOrDefault();
            var version = new ExtendedVersion.ExtendedVersion(attribute.InformationalVersion);

            return version;
        }

        public static void InitializeSettings()
        {
            Settings.Default.Upgrade();
            var provider = new PortableSettingsProvider();
            Settings.Default.Providers.Add(provider);
            foreach (SettingsProperty property in Settings.Default.Properties)
            {
                property.Provider = provider;
            }
        }
    }
}