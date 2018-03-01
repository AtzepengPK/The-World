using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Interfaces.Natural
{
    /// <summary>
    /// The behavior of all NaturalTypeCells
    /// </summary>
    public interface INaturalTypeCell
    {
        List<IResource> Resources { get; set; }
        SolidColorBrush color { get; set; }

        int MineResources(List<IHuman> workers);
        IResource MineResource(List<IHuman> workers,IResource resource);
    }
}
