using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class NickNames
    {
        public List<Nick> ListNicks = new List<Nick>();
        public void AddNick(string nick, string url)
        {
            Nick rnick = new Nick(nick, url);
            ListNicks.Add(rnick);
        }
        public void RemoveNick(Nick nick)
        {
            ListNicks.Remove(nick);
        }
    }
}
