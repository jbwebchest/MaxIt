using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MaxIt
{
    internal static class Tools
    {
        internal static void SetLabelCentered(Label label, string text, string font = "Arial", float size = 18, int top = 0,  Color? color = null)
        {
            label.Font = new Font(font, size);
            label.ForeColor = color ?? Color.Black;
            label.Text = text;
            label.Top = top;
            label.Left = (label.Parent.Width - label.Width) / 2;
        }
    }
}
