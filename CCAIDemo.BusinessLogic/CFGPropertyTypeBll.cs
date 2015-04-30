using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGPropertyTypeBll : BaseMgr<CFGPropertyType>
	{
        private CFGPropertyTypeDataAccess _CFGPropertyTypeDataAccess;

        public CFGPropertyTypeBll()
        {
            _CFGPropertyTypeDataAccess = new CFGPropertyTypeDataAccess();
        }
    }
 
}



