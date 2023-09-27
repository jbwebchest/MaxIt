using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using static MaxIt.Tools;
using static MaxIt.Enumerations;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace MaxIt
{
    internal class Players
    {
        #region Public events

        internal delegate void PlayerListChangedEventHandler(object sender);
        internal event PlayerListChangedEventHandler? PlayerListChanged;

        private void RaisePlayerListChanged(bool saveList)
        {
            if (saveList) SavePlayerList();
            PlayerListChanged?.Invoke(this);
        }

        #endregion Public events

        private readonly string filename = LocalAppDataFolder + "Players.lst";
        private readonly PropertyInfo[] properties = typeof(Player).GetProperties();

        internal List<Player> PlayerList { get; set; } = new List<Player>();

        internal Players()
        {
            Load();
        }

        internal void Load()
        {
            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            if (File.Exists(filename))
            {
                try
                {
                    var doc = new XmlDocument();
                    doc.Load(filename);

                    var root = doc.DocumentElement;
                    if (root is null)
                    {
                        AddDefaultPlayer();
                        return;
                    }

                    var players = root.SelectNodes("Player");
                    if (players is null) AddDefaultPlayer(false);
                    else
                    {
                        foreach (var item in players)
                        {
                            var playerData = (XmlElement)item;
                            if (playerData.HasAttribute("Id"))
                            {
                                var player = new Player();
                                //foreach (var property in properties)
                                //{
                                //    if (playerData.HasAttribute(property.Name)) player
                                //}


                                player.Id = Convert.ToInt32(playerData.GetAttribute("Id"));
                                player.Name = playerData.HasAttribute("Name") ? playerData.GetAttribute("Name") : "Anonym";
                                player.AiLevel = playerData.HasAttribute("AiLevel") ? Convert.ToInt32(playerData.GetAttribute("AiLevel")) : 0;
                                player.TimerState = playerData.HasAttribute("TimerState") ? Convert.ToInt32(playerData.GetAttribute("TimerState")) : 0;
                                player.Language = playerData.HasAttribute("Language") ? Convert.ToInt32(playerData.GetAttribute("Language")) : 0;
                                player.EasyGamesPlayed = playerData.HasAttribute("EasyGamesPlayed") ? Convert.ToInt32(playerData.GetAttribute("EasyGamesPlayed")) : 0;
                                player.EasyGamesWon = playerData.HasAttribute("EasyGamesWon") ? Convert.ToInt32(playerData.GetAttribute("EasyGamesWon")) : 0;
                                player.EasyGamesLost = playerData.HasAttribute("EasyGamesLost") ? Convert.ToInt32(playerData.GetAttribute("EasyGamesLost")) : 0;
                                player.EasyGamesDrawed = playerData.HasAttribute("EasyGamesDrawed") ? Convert.ToInt32(playerData.GetAttribute("EasyGamesDrawed")) : 0;
                                player.EasyMaxScoreWon = playerData.HasAttribute("EasyMaxScoreWon") ? Convert.ToInt32(playerData.GetAttribute("EasyMaxScoreWon")) : 0;
                                player.EasyMaxScoreLost = playerData.HasAttribute("EasyMaxScoreLost") ? Convert.ToInt32(playerData.GetAttribute("EasyMaxScoreLost")) : 0;
                                player.EasyTotalTime = playerData.HasAttribute("EasyTotalTime") ? Convert.ToInt32(playerData.GetAttribute("EasyTotalTime")) : 0;
                                player.EasyBestTime = playerData.HasAttribute("EasyBestTime") ? Convert.ToInt32(playerData.GetAttribute("EasyBestTime")) : 0;
                                player.MediumGamesPlayed = playerData.HasAttribute("MediumGamesPlayed") ? Convert.ToInt32(playerData.GetAttribute("MediumGamesPlayed")) : 0;
                                player.MediumGamesWon = playerData.HasAttribute("MediumGamesWon") ? Convert.ToInt32(playerData.GetAttribute("MediumGamesWon")) : 0;
                                player.MediumGamesLost = playerData.HasAttribute("MediumGamesLost") ? Convert.ToInt32(playerData.GetAttribute("MediumGamesLost")) : 0;
                                player.MediumGamesDrawed = playerData.HasAttribute("MediumGamesDrawed") ? Convert.ToInt32(playerData.GetAttribute("MediumGamesDrawed")) : 0;
                                player.MediumMaxScoreWon = playerData.HasAttribute("MediumMaxScoreWon") ? Convert.ToInt32(playerData.GetAttribute("MediumMaxScoreWon")) : 0;
                                player.MediumMaxScoreLost = playerData.HasAttribute("MediumMaxScoreLost") ? Convert.ToInt32(playerData.GetAttribute("MediumMaxScoreLost")) : 0;
                                player.MediumTotalTime = playerData.HasAttribute("MediumTotalTime") ? Convert.ToInt32(playerData.GetAttribute("MediumTotalTime")) : 0;
                                player.MediumBestTime = playerData.HasAttribute("MediumBestTime") ? Convert.ToInt32(playerData.GetAttribute("MediumBestTime")) : 0;
                                player.HardGamesPlayed = playerData.HasAttribute("HardGamesPlayed") ? Convert.ToInt32(playerData.GetAttribute("HardGamesPlayed")) : 0;
                                player.HardGamesWon = playerData.HasAttribute("HardGamesWon") ? Convert.ToInt32(playerData.GetAttribute("HardGamesWon")) : 0;
                                player.HardGamesLost = playerData.HasAttribute("HardGamesLost") ? Convert.ToInt32(playerData.GetAttribute("HardGamesLost")) : 0;
                                player.HardGamesDrawed = playerData.HasAttribute("HardGamesDrawed") ? Convert.ToInt32(playerData.GetAttribute("HardGamesDrawed")) : 0;
                                player.HardMaxScoreWon = playerData.HasAttribute("HardMaxScoreWon") ? Convert.ToInt32(playerData.GetAttribute("HardMaxScoreWon")) : 0;
                                player.HardMaxScoreLost = playerData.HasAttribute("HardMaxScoreLost") ? Convert.ToInt32(playerData.GetAttribute("HardMaxScoreLost")) : 0;
                                player.HardTotalTime = playerData.HasAttribute("HardTotalTime") ? Convert.ToInt32(playerData.GetAttribute("HardTotalTime")) : 0;
                                player.HardBestTime = playerData.HasAttribute("HardBestTime") ? Convert.ToInt32(playerData.GetAttribute("HardBestTime")) : 0;
                                PlayerList.Add(player);
                            }

                            
                        }
                    }

                    RaisePlayerListChanged(false);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else AddDefaultPlayer();
        }

        private void AddDefaultPlayer(bool raiseEvent = true)
        {
            PlayerList.Add(new Player { Id = 1, Name = "HUMAN" });
            if (raiseEvent) RaisePlayerListChanged(true);
        }

        private void SavePlayerList()
        {
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"));
            
            var root = doc.CreateElement("Players");
            var nodeContent = doc.CreateElement("Player");
            foreach (var player in PlayerList)
            {
                foreach (var property in properties)
                {
                    var node = doc.CreateElement("Option");
                    var value = property.GetValue(player, null);
                    if (value is null) continue;
                    node.SetAttribute("key", property.Name);
                    node.SetAttribute("value", value.ToString());
                    nodeContent.AppendChild(node);
                }
            }
            root.AppendChild(nodeContent);
            doc.AppendChild(root);
            doc.Save(filename);
        }
    }
}
