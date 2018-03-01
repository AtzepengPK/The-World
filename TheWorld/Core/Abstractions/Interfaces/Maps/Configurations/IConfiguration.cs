using System;

namespace ConsoleApp4.Core.Intarfaces
{
    public interface IConfiguration
    {
        int Width { get; }
        int Height { get; }

        int numberOfTrees { get; }
        int numberOfTWater { get; }  
    }
}