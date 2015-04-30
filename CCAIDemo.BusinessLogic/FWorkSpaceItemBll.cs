using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FWorkSpaceItemBll : BaseMgr<FWorkSpaceItem>
	{
        private FWorkSpaceItemDataAccess _FWorkSpaceItemDataAccess;

        public FWorkSpaceItemBll()
        {
            _FWorkSpaceItemDataAccess = new FWorkSpaceItemDataAccess();
        }
    }
 
}



