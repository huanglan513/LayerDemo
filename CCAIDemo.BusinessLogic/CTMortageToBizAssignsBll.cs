using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTMortageToBizAssignsBll : BaseMgr<CTMortageToBizAssigns>
	{
        private CTMortageToBizAssignsDataAccess _CTMortageToBizAssignsDataAccess;

        public CTMortageToBizAssignsBll()
        {
            _CTMortageToBizAssignsDataAccess = new CTMortageToBizAssignsDataAccess();
        }
    }
 
}



