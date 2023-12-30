using System;

using BepInEx.Configuration;

namespace LC_ChaosMod
{
    [Serializable]
    internal class PluginConfig
    {
        private readonly ConfigFile _configFile;

        internal bool Plugin_Enabled { get; set; }

        internal PluginConfig(ConfigFile configFile)
        {
            _configFile = configFile;
        }

        private T ConfigEntry<T>(string section, string key, T defaultValue, string description)
            => _configFile.Bind(section, key, defaultValue, description).Value;

        internal void InitBindings()
        {
            var mainSection = "Main";
            Plugin_Enabled = ConfigEntry(mainSection, "Enable Mod", true, "Turns this mod on or off.");
        }
    }
}
