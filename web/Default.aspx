<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Repeater ID="rep" runat="server"><ItemTemplate>
        <table><tr><td><%# Eval("Type") %></td></tr></table>
        </ItemTemplate></asp:Repeater>
    </div>
    
    
    
    
    
    
    
    
    
    
    
    <table cellpadding="0" cellspacing="0" style="height: 168px; width: 516px">
  <tr>
    <td valign="top" width="200">姓　名：</td>
    <td>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
      </td>
  </tr>

  <tr>
    <td id="reTitle">内　容：</td>
    <td>
        <asp:TextBox ID="TxtCon" runat="server" Height="100px" 
             TextMode="MultiLine" Width="450px"></asp:TextBox>
                                                    </td>
  </tr>
 
  <tr>
    <td class="style1">&nbsp;</td>
    <td>&nbsp;<asp:Button ID="BtnOk" runat="server" Text="添加留言" />
      </td>
  </tr>
</table>
        
    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        
    </form>
    
    
    
    
    
    
    
    
    
    
    
    </body>
</html>
