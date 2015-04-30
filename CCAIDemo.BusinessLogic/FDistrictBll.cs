using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDistrictBll : BaseMgr<FDistrict>
	{
        private FDistrictDataAccess _FDistrictDataAccess;

        public FDistrictBll()
        {
            _FDistrictDataAccess = new FDistrictDataAccess();
        }
    }
 
}



