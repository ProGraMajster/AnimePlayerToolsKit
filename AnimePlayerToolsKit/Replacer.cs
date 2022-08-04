using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerToolsKit
{
    public static class Replacer
    {
        public static string Names(string name)
        {
            return name.Replace(":", "_").Replace("?", "_").Replace("/", "_").Replace("\\", "_");
        }
    }
}
