using System.Collections.Generic;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Classes;
using TheWorld.Core.Abstractions.Interfaces;
using TheWorld.Core.Implementations;

namespace ConsoleApp4.Core.Interfaces.Natural
{
    /// <summary>
    /// All the cells that has a 'Natural' nature
    /// </summary>
    public interface INaturalCell : ICell
    {
        INaturalTypeCell Type { get; }

        int MineCell(List<IHuman> workers);
    }
}