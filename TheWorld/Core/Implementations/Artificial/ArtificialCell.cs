using ConsoleApp4.Core.Abstractions.Artificial;
using ConsoleApp4.Core.Intarfaces.Artificial;
using System;
using System.Collections.Generic;
using System.Text;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Implementations.Artificial
{
    public class ArtificialCell<T> : AbstractArtificialCell<T> where T : IArtificialTypeCell, new()
    {
       
    }
}
