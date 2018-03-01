using ConsoleApp4.Core.Intarfaces.Artificial;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace ConsoleApp4.Core.Abstractions.Artificial
{
    public abstract class AbstractArtificialTypeCell : IArtificialTypeCell
    {
        public abstract SolidColorBrush color { get; set; }
    }
}
