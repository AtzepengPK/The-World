using ConsoleApp4.Core.Interfaces.Natural;
using ConsoleApp4.Core.Abstractions;
using System;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Interfaces;
using System.Collections.Generic;
using TheWorld.Core.Abstractions.Classes;

namespace ConsoleApp4.Core.Abstractions.Natural
{
    /// <summary>
    /// Abstraction of an ICell. Here i can decide what MUST be implemented by the erediting classes as abstract
    /// </summary>
    /// <typeparam name="T">Generic that definens the 'type' of the cell. Ex: Tree,Water</typeparam>
    public abstract class AbstractNaturalCell<T> : AbstractCell, INaturalCell where T : INaturalTypeCell,new()
    {      
        public INaturalTypeCell Type { get; }
        public AbstractNaturalCell()
        {
            Type = new T();
        }

        public override SolidColorBrush color
        {
            get
            {
                return Type.color;
            }
        }
        /// <summary>
        /// Mine all the resources in this cell
        /// </summary>
        /// <returns>To be defined</returns>
        public int MineCell(List<IHuman> workers)
        {
            return Type.MineResources(workers);
        }

        public override void WorkCell(List<IHuman> workers)
        {
            MineCell(workers);
        }
    }
}
