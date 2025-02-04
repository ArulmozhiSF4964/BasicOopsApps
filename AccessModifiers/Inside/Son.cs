using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Son : Parent //inheriting parent
    {
        //default private
        //public
        public int PublicNumber=10;
        //private
        private int PrivateNumber = 20;
        //accessing these private variable using the method
        public int  PrivateOutNumber{
            get{return PrivateNumber;}

        }

        public int PrivateParentOut{
            get{return PrivateParentNumber;}
        }
        public int protectedParentOut{
            get{return ProtectedParentNumber;}
        }

        
    }
}