using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIt
{
    internal class Localization
    {
        internal int Id { get; set; } = -1;
        internal string Name { get; set; } = string.Empty;
        internal string NativeName { get; set; } = string.Empty;
        internal Dictionary<string, string> Text { get; set; } = new();
    }
}
