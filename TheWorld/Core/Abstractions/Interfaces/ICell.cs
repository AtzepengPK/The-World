using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Interfaces
{
    /// <summary>
    /// The base of everything on the map. If it is on the map it MUST be an ICell
    /// </summary>
    public interface ICell
    {
        position Position { get; set; }
        SolidColorBrush color { get; }

        void WorkCell(List<IHuman> workers);
    }

    public struct position
    {
        public int x;
        public int y;
        public int z;
    }
}
