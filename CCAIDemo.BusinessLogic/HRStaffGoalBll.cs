using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class HRStaffGoalBll : BaseMgr<HRStaffGoal>
	{
        private HRStaffGoalDataAccess _HRStaffGoalDataAccess;

        public HRStaffGoalBll()
        {
            _HRStaffGoalDataAccess = new HRStaffGoalDataAccess();
        }
    }
 
}



