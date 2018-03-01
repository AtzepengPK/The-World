using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Core.Implementations.Maps.Configurations
{
    class Default3DMapConfiguration : Abstract3DConfiguration
    {
        public override int Depth => 10;
        public override int Width => 10;
        public override int Height => 10;

        public override int numberOfTrees => asInt(Depth * Width * Height, 0.25d);
        public override int numberOfTWater => asInt(Depth * Width * Height, 0.40d);
    }
}
