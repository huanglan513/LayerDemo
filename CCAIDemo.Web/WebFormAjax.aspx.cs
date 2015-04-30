using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace CCAIDemo.Web
{
    public partial class WebFormAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.Utility.RegisterTypeForAjax(typeof(WebFormAjax));
            
        }
        [Ajax.AjaxMethod]//这句一定要有，如果你是Ajaxpro.dll就写成[AjaxPro.AjaxMethod] 
        public string getValue(int a, int b)
        {
            Thread.Sleep(3000);
            //该方法我们将实现从客户端传入两个数，在服务器端相加计算后返回到客户端。这里可以写在原来的页后台中也可以单独写一个类。 
            return Convert.ToString(a + b);//这里返回的就是前台得到的值，反正参数已经进CS文件了，想怎么操作就怎么操作，包括读库都可以。 
        }

        [Ajax.AjaxMethod]
        public string Test(string EmpName)
        {
            Thread.Sleep(3000);
            if (lblEmpNo != null)
            {
                lblEmpNo.Text = EmpName + "123";
            }
            return EmpName + "abc";
        }
    }
}