using System;
using ConsoleApp4.Core.Abstractions.Natural;
using System.Collections.Generic;
using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using System.Windows.Media;

namespace ConsoleApp4.Implementations.Natural.TypeCell
{
    /// <summary>
    /// A NaturalTypeCell that rappresents water
    /// </summary>
    public class Water : AbstractNaturalTypeCell
    {
        public override SolidColorBrush color
        {
            get
            {
                return Brushes.Blue;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override List<IResource> Resources { get; set; }
    }
}
