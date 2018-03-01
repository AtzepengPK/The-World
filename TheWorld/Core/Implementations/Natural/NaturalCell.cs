using System;
using System.Windows.Media;
using ConsoleApp4.Core.Abstractions.Natural;
using ConsoleApp4.Core.Interfaces.Natural;

namespace ConsoleApp4.Implementations.Natural
{
    /// <summary>
    /// A cell that has a natural related type. Ex: Forest,River ecc...
    /// </summary>
    /// <typeparam name="T">Eny class that implements INaturalTypeCell, defining the nature of the implementation</typeparam>
    public class NaturalCell<T> : AbstractNaturalCell<T> where T : INaturalTypeCell,new()
    {

        public override string ToString()
        {
            return typeof(T).ToString();
        }
    }


   
}
