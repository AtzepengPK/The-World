using ConsoleApp4.Core.Abstractions.Intarfaces;
using ConsoleApp4.Core.Intarfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp4.Core.Interfaces;
using ConsoleApp4.Implementations.Natural;
using ConsoleApp4.Implementations.Natural.TypeCell;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;

namespace ConsoleApp4.Core.Abstractions.Classes
{
    public abstract class Abstract3DMap<T> : I3DMap where T : Abstract3DConfiguration, new()
    {
        public ICell[,,] Map { get; set; }

        public I3DConfiguration Configuration { get; }

        public Abstract3DMap()
        {
            Configuration = new T();
            CreateNewMap();          
        }

        public virtual void assignTrees()
        {
            for (int i = 0; i < Configuration.numberOfTrees; i++)
            {
                position randomPos = PickRandom3DPosition();
                Map[randomPos.x, randomPos.y,randomPos.z] = new NaturalCell<Tree>();
            }
        }

        public virtual void assignWater()
        {
            for (int i = 0; i < Configuration.numberOfTWater; i++)
            {
                position randomPos = PickRandom3DPosition();
                Map[randomPos.x, randomPos.y, randomPos.z] = new NaturalCell<Water>();
            }
        }

        /// <summary>
        /// Pick 3 randoms ints between the Configuration range, and put them in position.x, position.y and position.z
        /// </summary>
        /// <returns>returns a free position from the Map</returns>
        public position PickRandom3DPosition()
        {
            Random _rand = new Random();
            position pos;
            do
            {
                pos.x = _rand.Next(0, Configuration.Width);
                pos.y = _rand.Next(0, Configuration.Height);
                pos.z = _rand.Next(0, Configuration.Depth);
            } while (Map[pos.x, pos.y,pos.z] != null);

            return pos;
        }

        public void CreateNewMap()
        {
            Map = new ICell[Configuration.Width, Configuration.Height,Configuration.Depth];
            assignTrees();
            assignWater();
        }

        public override string ToString()
        {
            string map = "";

            for (int i = 0; i < Configuration.Width; i++)
            {
                for (int j = 0; j < Configuration.Height; j++)
                {
                    for (int k = 0; k < Configuration.Depth; k++)
                    {
                        ICell ele = Map[i, j, k];
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
                    map += "\t";
                }
                map += "\n";
            }

            return map;
        }

    }
}
