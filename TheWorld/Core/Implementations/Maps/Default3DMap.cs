using ConsoleApp4.Core.Abstractions.Classes;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Core.Implementations.Maps.Configurations
{
    class Default3DMap<T> : Abstract3DMap<T> where T : Abstract3DConfiguration, new()
    {
    }
}
