<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAjaxJquery.aspx.cs" Inherits="CCAIDemo.Web.WebFormAjaxJquery" %>

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
            $("#btnTest").click(function () {

                $.ajax({
                    type: "POST",
                    async:true,
                    url: "WebFormAjaxJquery.aspx?Method=Test",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    //  data: "name=John&location=Boston",
                    data:"",
                    beforeSend: function () {
                        bsl_showLoadingDialog("请稍等");
                    },
                    success: function (msg) {
                        $(loadingDialog).dialog("close");
                       // alert("Data Saved: " + msg.d);
                    },
                    error: function (err) {
                        $(loadingDialog).dialog("close");
                        alert(err.d);
                    }
                });
                //禁用按钮的提交 
                return false;
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnTest" runat="server" Text="Test" />
    </div>
    </form>
</body>
</html>
