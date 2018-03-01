using System;
using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Core.Interfaces;
using ConsoleApp4.Implementations.Natural;
using ConsoleApp4.Implementations.Natural.TypeCell;
using ConsoleApp4.Core.Abstractions.Intarfaces;
using ConsoleApp4.Core.Abstractions.Classes;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;

namespace ConsoleApp4.Core.Abstractions
{
    public class Abstract2DMap<T> : I2DMap where T : Abstract2DConfiguration, new()
    {
        public ICell[,] Map { get; set; }
        public I2DConfiguration Configuration { get; }

        public Abstract2DMap()
        {
            Configuration = new T();
            CreateNewMap();
        }

        public virtual void assignTrees()
        {
            for (int i = 0; i < Configuration.numberOfTrees; i++)
            {
                position randomPos = PickRandom2DPosition();
                Map[randomPos.x, randomPos.y] = new NaturalCell<Tree>();
            }
        }

        public virtual void assignWater()
        {
            for (int i = 0; i < Configuration.numberOfTWater; i++)
            {
                position randomPos = PickRandom2DPosition();
                Map[randomPos.x, randomPos.y] = new NaturalCell<Water>();
            }
        }

        /// <summary>
        /// Pick 2 randoms ints between the Configuration range, and put them in position.x and position.y
        /// </summary>
        /// <returns>returns a free position from the Map</returns>
        public position PickRandom2DPosition()
        {
            Random _rand = new Random();
            position pos = new position();
            do
            {
                pos.x = _rand.Next(0, Configuration.Width);
                pos.y = _rand.Next(0, Configuration.Height);
            } while (Map[pos.x, pos.y] != null);

            return pos;
        }

        public override string ToString()
        {
            string map = "";

            for (int i = 0; i < Configuration.Width; i++)
            {
                for (int j = 0; j < Configuration.Height; j++)
                {
                    ICell ele = Map[i, j];
                    if (ele == null)
                    {
                        map += "0";
                    }
                    else
                    {
                        if (ele is NaturalCell<Tree>)
                        {
                            map += "?";
                        }
                        else { map += "@"; }
                    }
                    map += " ";
                }
                map += "\n";
            }

            return map;
        }

        public void CreateNewMap()
        {
            Map = new ICell[Configuration.Width, Configuration.Height];
            assignTrees();
            assignWater();
        }
    }
}