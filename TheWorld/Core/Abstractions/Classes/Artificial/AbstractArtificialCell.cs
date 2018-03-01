using ConsoleApp4.Core.Intarfaces.Artificial;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Abstractions.Artificial
{
    public abstract class AbstractArtificialCell<T> : AbstractCell, IArtificialCell where T : IArtificialTypeCell, new()
    {
        public IArtificialTypeCell Type { get; }

        public AbstractArtificialCell()
        {
            Type = new T();
        }

        public int Work()
        {
            Console.WriteLine("Work");
            return 0;
        }

        public override void WorkCell(List<IHuman> workers)
        {
            Work();
        }


        public override SolidColorBrush color
        {
            get
            {
                return Type.color;
            }
        }
    }
}
