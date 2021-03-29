using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class Nick
    {
        public string nick;

        public Nick(string nick, string url)
        {
            this.nick = nick;
            Url = url;
        }

        public string Name { get; set; }
        public string Url { get; set; }
    }
}
