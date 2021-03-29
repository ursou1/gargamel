using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class MobilePhone : IPhone
    {

        public string Number { get; set; }

        public string GetTypeName(string Number)
        {
            return "мобильный телефон";
        }
    }
}
