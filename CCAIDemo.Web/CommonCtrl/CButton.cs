using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace CCAIDemo.Web.CommonCtrl
{
    public class CButton:Button
    {
        [Browsable(true)]
        [Description("The method called")]
        [DefaultValue("调用的方法")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        public string Method
        {
            get { return ViewState["Method"] != null ? (string)ViewState["Method"] : string.Empty; }
            set { ViewState["Method"] = value; }
        }

        [Browsable(true)]
        [Description("Data inputted")]
        [DefaultValue("传入的数据")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        public string Data
        {
            get { return ViewState["Data"] != null ? (string)ViewState["Data"] : string.Empty; }
            set { ViewState["Data"] = value; }
        }


        protected override void OnPreRender(EventArgs e)
        {
             //  data: "name=John&location=Boston",
            string strAjax=@" $(function () {
            $('#btnOK').click(function () {
                $.ajax({
                    type: 'POST',
                    async:true,
                    url: 'WebForm1.aspx/TestAjax',
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                   
                    data:'',
                    beforeSend: function () {
                        bsl_showLoadingDialog('请稍等');
                    },
                    success: function (msg) {
                        $(loadingDialog).dialog('close');
                    },
                    error: function (err) {
                        alert(err);
                    }
                });
                //禁用按钮的提交 
                return false;
            });
        });";
            if (!Page.ClientScript.IsClientScriptBlockRegistered("CheckNum"))
            {
               // Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "CheckNum", strCheckNum, true);
            }
            base.OnPreRender(e);
        }

    }
}