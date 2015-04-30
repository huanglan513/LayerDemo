<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CCAIDemo.Web.WebForm1" %>

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

        $(function () {
            $("#btnOK").click(function () {

                $.ajax({
                    type: "POST",
                    async:true,
                    url: "WebForm1.aspx/TestAjax",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    //  data: "name=John&location=Boston",
                    data:"",
                    beforeSend: function () {
                        bsl_showLoadingDialog("请稍等");
                    },
                    success: function (msg) {
                        $(loadingDialog).dialog("close");
                        alert("Data Saved: " + msg.d);
                    },
                    error: function (err) {
                        $(loadingDialog).dialog("close");
                        alert(err);
                    }
                });
                //禁用按钮的提交 
                return false;
            });
        });

        function BlockTest() {
            bsl_showLoadingDialog("请稍等");
            document.getElementById("btnNone").click();
          //  $(loadingDialog).dialog("close");
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><br />
    <asp:Label ID="lblName" runat="server">abc</asp:Label>
        <div id="sq0">No0
        </div>
         <div id="sq1">No1
        </div>
          <div id="sq2">No2
        </div>
         <div id="sq3">No3
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">LinkButton</asp:LinkButton>
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <input id="btnTestAjax" type="button"
            value="TestAjax" />
            <asp:Button ID="btnOK" runat="server" Text="验证用户"  /> 
       
        <asp:Button ID="btnBlock" runat="server" Text="Block" OnClientClick="return BlockTest();" />
             <asp:Button ID="btnNone" runat="server" Text="None" 
            onclick="btnNone_Click" OnClientClick="javascript: bsl_showLoadingDialog('请稍等');" />
    </div>
    </form>
</body>
</html>
