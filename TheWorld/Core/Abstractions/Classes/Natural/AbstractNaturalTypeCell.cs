using ConsoleApp4.Core.Interfaces.Natural;
using System;
using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using System.Collections.Generic;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Abstractions.Natural
{
    /// <summary>
    /// Abstraction of an INaturalTypeCell. Here i can decide what MUST be implemented by the erediting classes as abstract
    /// </summary>
    public abstract class AbstractNaturalTypeCell : INaturalTypeCell
    {
        public abstract SolidColorBrush color { get; set; }

        public abstract List<IResource> Resources { get; set; }

        public IResource MineResource(List<IHuman> workers,IResource resource)
        {
            return resource.Mine(workers);
        }

        public int MineResources(List<IHuman> workers)
        {
            foreach (var resource in Resources)
            {
                MineResource(workers,resource);
            }

            return 0;
        }
    }
}
