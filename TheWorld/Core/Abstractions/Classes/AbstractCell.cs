using System;
using System.Windows.Media;
using ConsoleApp4.Core.Interfaces;
using TheWorld.Core.Abstractions.Interfaces;
using TheWorld.Core.Abstractions.Classes;
using System.Collections.Generic;

namespace ConsoleApp4.Core.Abstractions
{
    /// <summary>
    /// Abstraction of an ICell. Here i can decide what MUST be implemented by the erediting classes as abstract
    /// </summary>
    /// <typeparam name="T">Generic that definens the 'type' of the cell. Ex: Natural,Artificial</typeparam>
    public abstract class AbstractCell : ICell
    {

        public AbstractCell()
        {
            Position = new position();
        }
        public position Position { get; set; }

        public abstract SolidColorBrush color { get; }

        public abstract void WorkCell(List<IHuman> workers);
    }
}
