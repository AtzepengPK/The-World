using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Core.Abstractions.Interfaces;
using TheWorld.Core.Implementations;

namespace TheWorld.Core.Abstractions.Classes
{
    public abstract class AbstractHuman : IHuman
    {



        public abstract int age { get; set; }
        public abstract string id { get; }
        public abstract string name { get; set; }
        //public abstract IProfession profession { get; }
        public abstract Stats stats { get; set; }
    }
}
