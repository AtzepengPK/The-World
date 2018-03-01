using System;
using System.Collections.Generic;
using ConsoleApp4.Core.Abstractions;
using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Implementations;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;

namespace ConsoleApp4
{
    public class Default2DMapConfiguration : Abstract2DConfiguration
    {
        public override int Width => 10;
        public override int Height => 10;

        public override int numberOfTrees => asInt((Width*Height),0.30d);
        public override int numberOfTWater => asInt((Width * Height), 0.15d);
    }
}