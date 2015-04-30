using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSFeedBackBll : BaseMgr<SYSFeedBack>
	{
        private SYSFeedBackDataAccess _SYSFeedBackDataAccess;

        public SYSFeedBackBll()
        {
            _SYSFeedBackDataAccess = new SYSFeedBackDataAccess();
        }
    }
 
}



