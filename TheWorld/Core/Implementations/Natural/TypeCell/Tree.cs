using System;
using System.Collections.Generic;
using System.Windows.Media;
using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using ConsoleApp4.Core.Abstractions.Natural;
using ConsoleApp4.Core.Implementations.Natural;

namespace ConsoleApp4.Implementations.Natural.TypeCell
{
    /// <summary>
    /// A NaturalTypeCell that rappresents a tree
    /// </summary>
    public class Tree : AbstractNaturalTypeCell
    {
        public override List<IResource> Resources { get; set; }

        public override SolidColorBrush color
        {
            get
            {
                return Brushes.Green;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Tree()
        {
            Resources = new List<IResource>()
            {
                new Wood()
            };
        }
    }
}
