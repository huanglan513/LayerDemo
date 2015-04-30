using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Web.Security;
using System.Web.Services;

namespace CCAIDemo.Web
{
    public delegate void AsyncDelegateGetDataSet();
    public partial class WebForm1 : System.Web.UI.Page
    {
        private AsyncDelegateGetDataSet dgs;
        private int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // CCAIDemo.DAL.Class1 cl = new DAL.Class1();

          //  int a = int.Parse("abc");

            //System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(TestMe),
            //     null);


         
        }
        protected void TestMe(object state)
        {
            byte[] buf = new byte[2];
            buf[2] = 0;
        }

        
        public void BindData()
        {
            lblName.Text = "Hello, Async";
            Thread.Sleep(3000);
        }

        [WebMethod]//从前台调用必须是static方法
        public static string TestAjax()
        {
          //  lblName.Text = "Hello, Async";
            WebForm1 webForm = new WebForm1();
            if (webForm.lblName != null)
            {
                webForm.lblName.Text = "Hello,Async";
            }
           Thread.Sleep(3000);
            return "true";
        }

        IAsyncResult BeginAsyncOperation(object sender, EventArgs e,AsyncCallback cb,object state)
        {
            dgs = new AsyncDelegateGetDataSet(BindData);
            return dgs.BeginInvoke(cb, state);
        }

        void EndAsyncOperation(IAsyncResult ar)
        {
            Response.Write("<script>document.getElementById('s" + (i - 1) + "').style.display ='none';</script>");
            dgs.EndInvoke(ar);
        }
        void TimeoutAsyncOperation(IAsyncResult ar)
        {
        }

        private void WritePress()
        {
            while (i < 3)
            {
                Response.Write("<table  id='s" + i + "' width='100%'><tr ><td></td><td align=center >正在读取数据请稍候.</td></tr></table>");
                if (i > 0)
                {
                    Response.Write("<script>document.getElementById('s" + (i - 1) + "').style.display ='none';</script>");
                }
                i = i + 1;
                Response.Flush();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PageAsyncTask task = new PageAsyncTask(new BeginEventHandler(BeginAsyncOperation),
                                                 new EndEventHandler(EndAsyncOperation),
                                                 new EndEventHandler(TimeoutAsyncOperation), null);
            RegisterAsyncTask(task);
            WritePress();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void btnNone_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            lblName.Text = DateTime.Now.ToString();
          //  Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "aa", "$(loadingDialog).dialog('close');", true);
        }
    }
}