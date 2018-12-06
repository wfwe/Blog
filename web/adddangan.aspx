<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adddangan.aspx.cs" Inherits="adddangan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table width="600" border="0" cellpadding="0" cellspacing="1" bgcolor="#a8c7ce">
      <tr>
        <td bgcolor="d3eaef" style="height: 20px; width: 4%;"class="TrHead"><div align="center" >
            信息添加
            &nbsp;</div></td>
      </tr>
       
    <tr>
        <td bgcolor="d3eaef" class="STYLE10" style="height: 300px; width:300;" valign="top">姓名：<asp:TextBox ID="txtxm" runat="server" Height="23px"></asp:TextBox>
        <br /><br />
        性别：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <br />
        出生日期：<asp:TextBox ID="txtrq" runat="server"></asp:TextBox>
        <br /><br />
        出生地址：<asp:TextBox ID="txtdz" runat="server" Width="166px"></asp:TextBox>
        <br /><br />
        居住地址：<asp:TextBox ID="txtjz" runat="server" Width="222px"></asp:TextBox>
        <br /><br />
        就读过的小学：<asp:TextBox ID="txtjd" runat="server" Width="254px"></asp:TextBox>
        <br /><br />
        Eimal：<asp:TextBox ID="txtEimal" runat="server"></asp:TextBox>
                    </td>
       <!-- <td width="10%" bgcolor="d3eaef" class="STYLE6" style="height: 20px"><div align="center"></div></td>  -->     
      </tr>
       <tr>
        <td bgcolor="d3eaef" class="STYLE10" style="height: 20px; width: 4%;" valign="middle"><div align="center" valign="middle">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="修改" 
            Width="96px" />
            &nbsp;</div></td>
      </tr>
    </table>
    </div>
    </form>
</body>
</html>
