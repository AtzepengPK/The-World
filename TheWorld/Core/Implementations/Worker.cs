//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TheWorld.Core.Abstractions.Interfaces;
//using TheWorld.Core.Implementations;

//namespace TheWorld.Core.Abstractions.Classes
//{
//    public class Worker : AbstractWorker<Builder>
//    {
//        //public int age
//        //{
//        //    get
//        //    {
//        //        return 0;
//        //    }

//        //    set
//        //    {
//        //        age = value;
//        //    }
//        //}
//        //bool _isLiterate;

//        Stats _stats { get; set; }
//        string _name { get; set; }

//        public Worker(string name)
//        {
//            this._name = name;
//            _stats = new Stats();
//        }

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

//        //public bool isLiterate { get { return _isLiterate; }
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
//        public override string name
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }

//            set
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public override Stats stats
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }

//            set
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }
//}
