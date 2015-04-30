using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCAIDemo.Web
{
    public class BasePage : System.Web.UI.Page
    {
        public string UserName
        {
            get
            {
                return Session["UserName"] != null ? Session["UserName"].ToString() : string.Empty ;
            }
            set
            {
                Session["UserName"] = value;
            }
        }
    }
}