using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Core.Abstractions.Intarfaces
{
    interface I3DMap : IMap
    {
        ICell[,,] Map { get; set; }
        I3DConfiguration Configuration { get; }
    }
}
