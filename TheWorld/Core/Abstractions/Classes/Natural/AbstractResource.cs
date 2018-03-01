using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using System;
using System.Collections.Generic;
using System.Text;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Abstractions.Classes.Natural
{
    public abstract class AbstractResource : IResource
    {
        public abstract string name { get; }
        public abstract int quantity { get; set; }

        public abstract IResource Mine(List<IHuman> workers);
    }
}
