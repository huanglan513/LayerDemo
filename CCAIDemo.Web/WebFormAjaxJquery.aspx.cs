using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace CCAIDemo.Web
{
    public partial class WebFormAjaxJquery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Method"] != null && Request.QueryString["Method"].ToString() == "Test")
            {
                Test();
            }
        }

        public void Test()
        {
            Thread.Sleep(3000);
            lblText.Text = DateTime.Now.ToString();
            
        }
    }
}