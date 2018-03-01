using ConsoleApp4.Core.Abstractions.Classes.Natural;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp4.Core.Abstractions.Intarfaces.Natural;
using TheWorld.Core.Abstractions.Interfaces;

namespace ConsoleApp4.Core.Implementations.Natural
{
    public class Wood : AbstractResource
    {
        public override string name => "Wood";
        public override int quantity { get { return 1000; } set { quantity = value; } }

        public override IResource Mine(List<IHuman> workers)
        {
            foreach (var worker in workers)
            {
                Console.WriteLine("WORKER " + worker.name + " MINING");
                Console.WriteLine("\tAGE " + worker.age);
                Console.WriteLine("\tPROFESSION " + worker.profession.name);
            }
            return this;

        }
    }
}
