using ConsoleApp4.Core.Intarfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Core.Abstractions.Intarfaces
{
    public interface I3DConfiguration : IConfiguration
    {
        int Depth { get; }
    }
}
