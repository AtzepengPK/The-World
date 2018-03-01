using ConsoleApp4.Core.Abstractions.Intarfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations
{
    public abstract class Abstract3DConfiguration : AbstractConfiguration, I3DConfiguration
    {
        public abstract int Depth { get; }
    }
}
