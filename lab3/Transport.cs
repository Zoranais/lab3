using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class Transport
    {
        public string Name { get; private set; }
        public Transport(string name)
        {
            Name = name;
        }

        public virtual string Show()
        {
            return $"Name: {Name}";
        }

        public abstract int GetPrice();
    }
}
