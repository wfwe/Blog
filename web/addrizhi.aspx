<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addrizhi.aspx.cs" Inherits="addrizhi" %>

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
            日志添加
            &nbsp;</div></td>
      </tr>
         <tr>
        <td bgcolor="d3eaef" style="height: 20px; width: 4%;" align="left"><div align="left" >
    
        标题：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </div></td>
      </tr>  <tr>
        <td bgcolor="d3eaef" style="height: 20px; width: 4%;" align="left"><div align="left" >
            &nbsp;&nbsp;类别：<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="类别添加" onclick="Button2_Click" />
            </div></td>
      </tr>
    <tr>
        <td bgcolor="d3eaef" class="STYLE10" style="height: 400px; width:300;" valign="top">
        <asp:TextBox ID="TextBox2" runat="server" Height="409px" TextMode="MultiLine" 
            Width="587px"></asp:TextBox>
        </td>
       <!-- <td width="10%" bgcolor="d3eaef" class="STYLE6" style="height: 20px"><div align="center"></div></td>  -->     
      </tr>
       <tr>
        <td bgcolor="d3eaef" class="STYLE10" style="height: 20px; width: 4%;" valign="middle"><div align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" 
             Height="30px" Width="96px" />
            &nbsp;</div></td>
      </tr>
    </table>
    </div>
    </form>
</body>
</html>
