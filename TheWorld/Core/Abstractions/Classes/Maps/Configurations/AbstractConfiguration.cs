using System;
using ConsoleApp4.Core.Intarfaces;

namespace ConsoleApp4.Core.Abstractions
{
    public abstract class AbstractConfiguration : IConfiguration
    {
        public abstract int Width { get; }
        public abstract int Height { get; }

        public abstract int numberOfTrees { get; }
        public abstract int numberOfTWater { get; }

        public int asInt(int ints, double dec)
        {
            return (int)(((double)ints) * dec);
        }
    }



    
}