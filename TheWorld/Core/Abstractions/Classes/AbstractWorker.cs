//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TheWorld.Core.Abstractions.Interfaces;

//namespace TheWorld.Core.Abstractions.Classes
//{
//    public abstract class AbstractWorker : IWorker<IProfession> 
//    {
//        public IProfession Type { get; }

//        //public int age
//        //{
//        //    gets
//        //    {
//        //        return 0;
//        //    }

//        //    set
//        //    {
//        //        age = value;
//        //    }
//        //}
//        //bool _isLiterate;

//        //Stats _stats { get; set; }
//        //string _name { get; set; }

//        //public Worker(string name)
//        //{
//        //    this._name = name;
//        //    _stats = new Stats();
//        //}

//        //public Worker()
//        //{
//        //    _name = "def";
//        //    _stats = new Stats();
//        //}


//        //public string id
//        //{
//        //    get
//        //    {
//        //        Guid g = Guid.NewGuid();
//        //        return g.ToString();
//        //    }
//        //}

//        //public bool isLiterate
//        //{
//        //    get { return _isLiterate; }
//        //    set
//        //    {
//        //        _isLiterate = value;
//        //        stats.statsBoost = _isLiterate ? stats.maxBoost : stats.minBoost;
//        //    }
//        //}

//        //public T profession
//        //{
//        //    get
//        //    {
//        //        return new T();
//        //    }

//        //    set
//        //    {
//        //        profession = value;
//        //    }
//        //}

//        //string IWorker<T>.name
//        //{
//        //    get
//        //    {
//        //        return _name;
//        //    }

//        //    set
//        //    {
//        //        this._name = value;
//        //    }
//        //}

//        //public Stats stats
//        //{
//        //    get
//        //    {
//        //        return _stats;
//        //    }

//        //    set
//        //    {
//        //        this._stats = value;
//        //    }
//        //}


//        public AbstractWorker()
//        {
//            age = 8;
//            Type = new T();
//        }

//        public int age { get; set; }
//        public string id { get { return ""; } }
//        public abstract string name { get; set; }
//        public abstract Stats stats { get; set; }

//        public IProfession profession
//        {
//            get
//            {
//                return Type;
//            }
//        }
//    }
//}
