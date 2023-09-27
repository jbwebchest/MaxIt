using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Xml;

namespace MaxIt
{
    internal static class Tools
    {
        internal static string AppName { get; private set; } = "MaxIt";
        
        private static readonly string attrFormat = "//Option[@key='{0}']";

        private static string _appDataFolder = string.Empty;
        internal static string AppDataFolder
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_appDataFolder))
                {
                    _appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("file:\\", "") + "\\" + AppName + "\\";
                    if (!Directory.Exists(_appDataFolder))
                        Directory.CreateDirectory(_appDataFolder);
                }
                return _appDataFolder;
            }
        }

        private static string _localAppDataFolder = string.Empty;
        internal static string LocalAppDataFolder
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_localAppDataFolder))
                {
                    _localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).Replace("file:\\", "") + "\\" + AppName + "\\";
                    if (!Directory.Exists(_localAppDataFolder))
                        Directory.CreateDirectory(_localAppDataFolder);
                }
                return _localAppDataFolder;
            }
        }

        internal static void OpenFolderInExplorer(string path)
        {
            Process.Start("explorer.exe", path);
        }

        internal static void SetLabelCentered(Label label, string text, string font = "Arial", float size = 18, int top = 0,  Color? color = null, Size clientSize = default)
        {
            label.Font = new Font(font, size);
            label.ForeColor = color ?? Color.Black;
            label.Text = text;
            label.Top = top;
            label.Left = (clientSize.Width - label.Width) / 2;
        }

        internal static void LabelAlignCenter(ActiveLabel label)
        {
            label.Left = (label.Parent.Width - label.Width) / 2;
        }

        internal static void TwoLabelsAlignCenter(ActiveLabel label1, ActiveLabel label2)
        {
            var center = label1.Parent.Width / 2;
            label1.Left = center - label1.Width;
            label2.Left = center;
        }

        internal static bool ValueOrDefaultFromXml(XmlDocument doc, string optionName, bool defaultValue)
        {
            var attr = string.Format(attrFormat, optionName);
            var node = doc.SelectSingleNode(attr);
            if (node is not null)
            {
                var element = (XmlElement)node;
                if (element is not null && element.HasAttribute("value"))
                {
                    var value = element.GetAttribute("value").Replace("\\n", "\n");
                    if (!string.IsNullOrWhiteSpace(value)) return Convert.ToBoolean(value);
                }
            }
            return defaultValue;
        }

        internal static string ValueOrDefaultFromXml(XmlDocument doc, string optionName, string defaultValue)
        {
            var attr = string.Format(attrFormat, optionName);
            var node = doc.SelectSingleNode(attr);
            if (node is not null)
            {
                var element = (XmlElement)node;
                if (element is not null && element.HasAttribute("value"))
                {
                    var value = element.GetAttribute("value").Replace("\\n", "\n");
                    if (!string.IsNullOrWhiteSpace(value)) return value;
                }
            }
            return defaultValue;
        }

        internal static int ValueOrDefaultFromXml(XmlDocument doc, string optionName, int defaultValue)
        {
            var attr = string.Format(attrFormat, optionName);
            var node = doc.SelectSingleNode(attr);
            if (node is not null)
            {
                var element = (XmlElement)node;
                if (element is not null && element.HasAttribute("value"))
                {
                    var value = element.GetAttribute("value").Replace("\\n", "\n");
                    if (!string.IsNullOrWhiteSpace(value)) return Convert.ToInt32(value);
                }
            }
            return defaultValue;
        }

        internal static void InitializePanel(Panel panel, Size clientSize)
        {
            panel.Left = 0;
            panel.Top = 0;
            panel.Width = clientSize.Width;
            panel.Height = clientSize.Height;
            panel.Visible = false;
        }
    }
}
