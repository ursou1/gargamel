using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class TownPhone : IPhone
    {
        public string Number { get; set; }

        public string GetTypeName(string Number)
        {
            return "Городской телефон";
        }
    }
}
