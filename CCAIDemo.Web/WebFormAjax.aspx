<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAjax.aspx.cs" Inherits="CCAIDemo.Web.WebFormAjax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript" src="JScripts/jquery-1.8.3.js"></script>
    <script language="javascript" type="text/javascript" src="JScripts/jquery-ui-1.9.2.custom.min.js"></script>
    <link type="text/css" rel="Stylesheet" href="Css/jquery-ui-1.9.2.custom.min.css" />
    <script language="javascript" type="text/javascript">
        var loadingDialog = $('<div id="dialog" title="" width="100%"><p class="center"><img src="Images/loading.gif"/></p><br/><p class="center">Please wait for a little while.</p></div>');
        function bsl_showLoadingDialog(title) {
            loadingDialog.dialog({
                modal: true,
                title: title,
                width: 400,
                height: 300,
                closeOnEscape: false,
                resizable: false
            });
            loadingDialog.parent().find('.ui-dialog-titlebar-close').hide();
        }
        function getValue() {
            bsl_showLoadingDialog("请稍等");
            //这里如果是AjaxPro.dll就加Web._Default.getValue,如果是Ajax.dll就不用加命名空间如下 
            WebFormAjax.getValue(1, 2, getGroups_callback); //该处即调用服务器端的_Default.getValue方法。 
            //_Default就是写getValue的那个类，如果写在本页CS里就是WebPage1.getValue，1和2是参数。 
            //这在里边getGroups_callback指定的是个回调函数，以接受服务器端处理完后返回客户端结果。 
        }
        //这个方法用户接受并处理服务器端返回的结果。 
        function getGroups_callback(response) {
            var dt = response.value; //这个值就是最终传回来的值，想怎么用就怎么用，反正回前台了。
            alert(dt);
            document.getElementById("Div_1").innerHTML = dt;
            $(loadingDialog).dialog("close");
        }

        function CallTest() {
           // document.getElementById('txtClientId').charset = "gb2312"
            var EmpName = document.getElementById('txtClientId').value;
         //   alert(EmpName);
            bsl_showLoadingDialog("请稍等");
            WebFormAjax.Test(EmpName, getGroups_callback);
            return false;
        } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="Div_1"> </div> 
    <button id="btnTest" onclick="getValue()">开始 </button> <br />
      Enter Emp No Here:
                <input type="text" id="txtClientId" />
                  <button id="Button1" onclick="CallTest()">HtmlOK </button> <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClientClick="return CallTest();" />
        <asp:Label ID="lblEmpNo" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
