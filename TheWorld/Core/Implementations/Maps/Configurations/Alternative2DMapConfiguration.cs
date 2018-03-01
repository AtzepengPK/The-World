using System;
using ConsoleApp4.Core.Abstractions;
using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;

namespace ConsoleApp4.Implementations
{
    public class Alternative2DMapConfiguration : Abstract2DConfiguration
    {
        public override int Width => 5;
        public override int Height => 5;

        public override int numberOfTrees => asInt((Width * Height), 0.30d);
        public override int numberOfTWater => asInt((Width * Height), 0.40d);
    }
}