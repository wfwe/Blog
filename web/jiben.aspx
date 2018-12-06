<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jiben.aspx.cs" Inherits="jiben" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="repjb" runat="server"><ItemTemplate>
    
    <table border="0" cellpadding="0" cellspacing="0" width="96%">
            <tr>
                <td width="88">
                    <div>
                        <img id="userPortrait"src="#" /></div>
                </td>
                <td valign="top">
                    <h1>
                        <%# Eval("User") %></h1>
                    <a href="addrizhi.aspx"target="_blank">写文章</a>
                    <a href="#" target="_blank">上传照片</a>
                    <a href="#" target="_blank"></a>
                </td>
            </tr>
        </table>
       </ItemTemplate></asp:Repeater>
        <div>
            <a href="#">留言评论通知</a>&nbsp;</div>
    
    </div>
    </form>
</body>
</html>
