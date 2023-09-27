using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static MaxIt.Tools;

namespace MaxIt
{
    internal class Settings
    {
        #region Public events

        internal delegate void ConfigChangedEventHandler(object sender);
        internal event ConfigChangedEventHandler? ConfigChanged;

        private void RaiseConfigChanged()
        {
            //SaveSettings();
            ConfigChanged?.Invoke(this);
        }

        #endregion Public events

        #region Private properties

        //private const string _appName = "MaxIt";
        //private readonly string configFile = LocalAppDataFolder + _appName + ".set";
        //private readonly string localExtension = ".loc";
        //private readonly string attrFormat = "//Option[@key='{0}']";
        //private const string _defaultLangCode = "en-US";
        //private const string _defaultLangName = "English (US)";
        //private const string _author = "Eugen Beresenkow";
        //private const string _description = "English (US)";
        //private const string _version = "1.0";
        //private const bool _rightToLeft = false;

        //#endregion Private properties

        //#region Public properties
        //internal string AppName { get; private set; } = _appName;
        //internal string DefaultLangCode { get; private set; } = _defaultLangCode;
        //internal string DefaultLangName { get; private set; } = _defaultLangName;
        //internal bool DefaultRightToLeft { get; private set; } = _rightToLeft;
        //internal string Author { get; private set; } = _author;
        //internal string Description { get; private set; } = _description;
        //internal string Version { get; private set; } = _version;
        //internal string LangCode { get; private set; } = _defaultLangCode;
        //internal string LangName { get; private set; } = _defaultLangName;
        //internal bool RightToLeft { get; private set; } = _rightToLeft;
        //internal List<Player> Players { get; set; } = new();

        //#endregion Public properties

        //#region Private methods

        //private void DefaultSettings()
        //{
        //    SetDefaultOptions(false);
        //    SetDefaultPlayers(false);
        //    RaiseConfigChanged();
        //}

        //private void SetDefaultOptions(bool raiseEvent = true)
        //{
        //    AppName = _appName;
        //    DefaultLangCode = _defaultLangCode;
        //    DefaultLangName = _defaultLangName;
        //    DefaultRightToLeft = _rightToLeft;
        //    Author = _author;
        //    Description = _description;
        //    Version = _version;
        //    LangCode = _defaultLangCode;
        //    LangName = _defaultLangName;
        //    RightToLeft = _rightToLeft;
        //    if (raiseEvent) RaiseConfigChanged();
        //}

        //private void SetDefaultPlayers(bool raiseEvent = true)
        //{
        //    Players = new();
        //    if (raiseEvent) RaiseConfigChanged();
        //}

        //private void LoadSettings()
        //{
        //    if (File.Exists(configFile))
        //    {
        //        try
        //        {
        //            var doc = new XmlDocument();
        //            doc.Load(configFile);

        //            var root = doc.DocumentElement;
        //            if (root is null)
        //            {
        //                DefaultSettings();
        //                return;
        //            }

        //            AppName = GetStringOptionOrDefault(doc, nameof(AppName), _appName);
        //            DefaultLangCode = GetStringOptionOrDefault(doc, nameof(DefaultLangCode), _defaultLangCode);
        //            DefaultLangName = GetStringOptionOrDefault(doc, nameof(DefaultLangName), _defaultLangName);
        //            DefaultRightToLeft = GetBooleanOptionOrDefault(doc, nameof(DefaultRightToLeft), _rightToLeft);
        //            Author = GetStringOptionOrDefault(doc, nameof(Author), _author);
        //            Description = GetStringOptionOrDefault(doc, nameof(Description), _description);
        //            Version = GetStringOptionOrDefault(doc, nameof(Version), _version);
        //            LangCode = GetStringOptionOrDefault(doc, nameof(LangCode), _defaultLangCode);
        //            LangName = GetStringOptionOrDefault(doc, nameof(LangName), _defaultLangName);
        //            RightToLeft = GetBooleanOptionOrDefault(doc, nameof(RightToLeft), _rightToLeft);

        //            var stats = root.SelectNodes("Stats");
        //            if (stats is null || stats[0] is not XmlElement statistics) SetDefaultPlayers(false);
        //            else
        //            {
        //                var players = statistics.SelectNodes("Player");
        //                if (players is null) SetDefaultPlayers(false);
        //                else
        //                {
        //                    foreach (var item in players)
        //                    {
        //                        var playerData = (XmlElement)item;
        //                        var player = new Player();
        //                        player.Name = playerData.HasAttribute("Name") ? playerData.GetAttribute("Name") : "Anonym";
        //                        player.Rang = playerData.HasAttribute("Rang") ? Convert.ToInt32(playerData.GetAttribute("Rang")) : 0;
        //                        player.Time = playerData.HasAttribute("Time") ? Convert.ToInt32(playerData.GetAttribute("Time")) : 0;
        //                        player.Games = playerData.HasAttribute("Games") ? Convert.ToInt32(playerData.GetAttribute("Games")) : 0;
        //                        player.Points = playerData.HasAttribute("Points") ? Convert.ToInt32(playerData.GetAttribute("Points")) : 0;
        //                        Players.Add(player);
        //                    }
        //                }
        //            }

        //            RaiseConfigChanged();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //    else DefaultSettings();
        //}

        //private bool GetBooleanOptionOrDefault(XmlDocument doc, string optionName, bool defaultValue)
        //{
        //    var attr = string.Format(attrFormat, optionName);
        //    var node = doc.SelectSingleNode(attr);
        //    if (node is not null)
        //    {
        //        var element = (XmlElement)node;
        //        if (element is not null && element.HasAttribute("value"))
        //        {
        //            var value = element.GetAttribute("value").Replace("\\n", "\n");
        //            if (!string.IsNullOrWhiteSpace(value)) return Convert.ToBoolean(value);
        //        }
        //    }
        //    return defaultValue;
        //}

        //private string GetStringOptionOrDefault(XmlDocument doc, string optionName, string defaultValue)
        //{
        //    var attr = string.Format(attrFormat, optionName);
        //    var node = doc.SelectSingleNode(attr);
        //    if (node is not null)
        //    {
        //        var element = (XmlElement)node;
        //        if (element is not null && element.HasAttribute("value"))
        //        {
        //            var value = element.GetAttribute("value").Replace("\\n", "\n");
        //            if (!string.IsNullOrWhiteSpace(value)) return value;
        //        }
        //    }
        //    return defaultValue;
        //}



        //private void SaveSettings()
        //{
        //    //throw new NotImplementedException();
        //}

        //#endregion Private methods

        //#region Public methods

        //internal void Load()
        //{
        //    LoadSettings();
        //}

        //internal void Save()
        //{
        //    SaveSettings();
        //}

        //#endregion Public methods

        //#region Constructor

        //internal Settings()
        //{
        //    DefaultSettings();
        //}

        #endregion Constructor
    }
}
