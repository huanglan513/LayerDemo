using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using CCAIDemo.Utility;

namespace CCAIDemo.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exp = Server.GetLastError();
           // string strE = "内部错误:" + exp.InnerException.ToString() + "\r\n堆栈：" + exp.StackTrace + "\r " + "Message:" + exp.Message + "\r 来源:" + exp.Source;

            // 在事件日志中记录异常信息
            LogHelper.LogError(exp);
            Server.ClearError();
            Server.Transfer("ErrorPage.htm", false);
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

      
    }
}