using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajós
{
    internal class Kerdes
    {
        public string KérdésSzöveg { get; set; } = string.Empty;
        public string Válasz1 { get; set; }
        public string Válasz2 { get; set; }
        public string Válasz3 { get; set; }
        public string URL { get; set; }
        public int HelyesVálasz { get; set; }
        public int HelyesVálaszokSzáma { get; set; }
    }
}
