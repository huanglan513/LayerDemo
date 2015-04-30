using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGUniversalDictionaryBll : BaseMgr<CFGUniversalDictionary>
	{
        private CFGUniversalDictionaryDataAccess _CFGUniversalDictionaryDataAccess;

        public CFGUniversalDictionaryBll()
        {
            _CFGUniversalDictionaryDataAccess = new CFGUniversalDictionaryDataAccess();
        }
    }
 
}



