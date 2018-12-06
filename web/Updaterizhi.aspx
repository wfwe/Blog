<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Updaterizhi.aspx.cs" Inherits="Updaterizhi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        标题：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        类别：<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="255px" TextMode="MultiLine" 
            Width="440px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" 
            style="width: 40px" />
    </div>
    </form>
</body>
</html>
