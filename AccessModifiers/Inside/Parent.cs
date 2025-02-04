using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Parent : GrantParent
    {
        private int PrivateParentNumber = 30;

        protected int ProtectedParentNumber = 40;

        internal int InternalParentNumber =50;

        public int ProtectedInternalGrandParentNumberOut{
                  get{return ProtectedInternalNumber;}
        }

        public int GrandParentInternalOut{
            get{return InternalGrandParentNUmber;}
        }
    }
}