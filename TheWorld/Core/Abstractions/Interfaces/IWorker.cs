using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Core.Abstractions.Classes;

namespace TheWorld.Core.Abstractions.Interfaces
{
    public interface IWorker<T> where T :IProfession, new()
    {
        string id { get; }
        string name { get; set; }
        int age { get; set; }
        Stats stats { get; set; }

        T profession { get; }
    }  
}
