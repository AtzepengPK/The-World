using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Core.Abstractions.Classes;
using TheWorld.Core.Abstractions.Interfaces;

namespace TheWorld.Core.Implementations
{
    public class Human : AbstractHuman
    {

        String _name { get; set; }
        int _age { get; set; }
        Stats _stats { get; set; }

        public Human()
        {
            _stats = new Stats();
        }

        public Human(String name, int age)
        {
            _name = name;
            _age = age;
            _stats = new Stats();
        }

        public override int age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public override string id
        {
            get
            {
                return "sdfsds";
            }
        }

        public override string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public override IProfession profession
        {
            get
            {
                return new Builder();
            }
        }

        public override Stats stats
        {
            get
            {
                return _stats;
            }

            set
            {
                _stats = value;
            }
        }
    }
}
