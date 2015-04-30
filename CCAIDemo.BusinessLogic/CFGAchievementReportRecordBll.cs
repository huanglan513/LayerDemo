using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGAchievementReportRecordBll : BaseMgr<CFGAchievementReportRecord>
	{
        private CFGAchievementReportRecordDataAccess _CFGAchievementReportRecordDataAccess;

        public CFGAchievementReportRecordBll()
        {
            _CFGAchievementReportRecordDataAccess = new CFGAchievementReportRecordDataAccess();
        }
    }
 
}



