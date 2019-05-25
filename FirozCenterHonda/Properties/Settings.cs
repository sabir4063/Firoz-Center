namespace FirozCenterHonda.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = ((Settings) SettingsBase.Synchronized(new Settings()));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode, DefaultSettingValue("server=192.168.1.4;user id=root;password=101proof;persistsecurityinfo=True;database=firoz_center"), ApplicationScopedSetting]
        public string teConnectionString
        {
            get
            {
                return (string) this["teConnectionString"];
            }
        }
    }
}

