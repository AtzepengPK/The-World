using ConsoleApp4.Core.Abstractions.Artificial;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace ConsoleApp4.Implementations.Artificial.TypeCell
{
    public class House : AbstractArtificialTypeCell
    {
        public override SolidColorBrush color
        {
            get
            {
                return Brushes.Silver;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
