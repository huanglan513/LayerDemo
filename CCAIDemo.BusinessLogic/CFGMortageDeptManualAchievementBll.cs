using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGMortageDeptManualAchievementBll : BaseMgr<CFGMortageDeptManualAchievement>
	{
        private CFGMortageDeptManualAchievementDataAccess _CFGMortageDeptManualAchievementDataAccess;

        public CFGMortageDeptManualAchievementBll()
        {
            _CFGMortageDeptManualAchievementDataAccess = new CFGMortageDeptManualAchievementDataAccess();
        }
    }
 
}



