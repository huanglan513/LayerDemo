using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGDictionarySettingBll : BaseMgr<CFGDictionarySetting>
	{
        private CFGDictionarySettingDataAccess _CFGDictionarySettingDataAccess;

        public CFGDictionarySettingBll()
        {
            _CFGDictionarySettingDataAccess = new CFGDictionarySettingDataAccess();
        }
    }
 
}



