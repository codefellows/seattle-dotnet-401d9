using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Diplodocus : PlantEater, IHibernate
    {

        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public bool LikesLeafs { get; private set;  } = true;
        public override bool LikeLeafs { get; set; } = true;

        public bool Hibernate()
        {
            bool leafs = false;
            if (LikeLeafs == true)
            {
                leafs = true;
                Console.WriteLine("I am hibernating");
                return leafs;
            }
            else
                return
                    leafs;
        }
    }
}