using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Core.Abstractions.Interfaces;

namespace TheWorld.Core.Abstractions.Classes
{
    public abstract class AbstractProfession : IProfession
    {

        public AbstractProfession()
        {

        }
        public int id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public abstract string name { get; }
    }
}
