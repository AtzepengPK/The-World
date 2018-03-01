using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Core.Abstractions;
using TheWorld.Core.Abstractions.Classes;
using TheWorld.Core.Abstractions.Interfaces;

namespace TheWorld.Core.Implementations
{
    public class Builder : AbstractProfession
    {
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

        public override string name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string name
        {
            get
            {
                return "Builder";
            }
        }
    }
}
