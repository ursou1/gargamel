using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    public interface IPhone
    {
        public string Number { get; set; }

        public string GetTypeName(string Number);
    }
}
