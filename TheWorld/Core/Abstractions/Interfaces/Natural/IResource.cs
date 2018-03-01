using System;
using System.Collections.Generic;
using System.Text;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Abstractions.Intarfaces.Natural
{
    /// <summary>
    /// Defines the properties of all Resources
    /// </summary>
    public interface IResource
    {
        string name { get; }
        int quantity { get; set; }

        IResource Mine(List<IHuman> workers);
    }
}
