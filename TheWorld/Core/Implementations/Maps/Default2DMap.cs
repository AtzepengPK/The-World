using System;
using ConsoleApp4.Core.Abstractions;
using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Core.Interfaces;
using ConsoleApp4.Implementations.Natural;
using ConsoleApp4.Implementations.Natural.TypeCell;
using ConsoleApp4.Core.Abstractions.Intarfaces;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;

namespace ConsoleApp4.Implementations
{
    public class Default2DMap<T> : Abstract2DMap<T> where T : Abstract2DConfiguration, new()
    {

    }
}