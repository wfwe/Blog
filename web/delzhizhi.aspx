<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delzhizhi.aspx.cs" Inherits="delzhizhi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#a8c7ce" >
      <tr>
        <td width="4%" height="20" bgcolor="d3eaef"><div align="center">
            <%--<input name='chkAll' type='checkbox' id='chkAll' onclick='CheckAll(this.form)' value='checkbox'>--%>
            </div></td>
        <td height="20" bgcolor="d3eaef"><div align="center"><span>用户名</span></div></td>
        <td width="40%" height="20" bgcolor="d3eaef" ><div align="center"><span>新闻标题</span></div></td>
        <td width="15%" height="20" bgcolor="d3eaef" ><div align="center"><span>添加时间</span></div></td>
        <td width="14%" height="20" bgcolor="d3eaef" ><div align="center"><span>基本操作</span></div></td>
      </tr>
      <asp:Repeater ID="rep1" runat="server" onitemcommand="rep1_ItemCommand"><ItemTemplate>
      <tr>
        <td bgcolor="#FFFFFF" style="height: 20px"><div align="center">
          
          <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
        </div></td>
        <td bgcolor="#FFFFFF"  style="height: 20px; width:80px;"><div align="center"><span>系统管理员</span></div></td>
        <td bgcolor="#FFFFFF"  style="height: 20px"><div align="left"><%# Eval("Subject")%><%--<asp:CheckBox ID="cbxSonger" runat="server" Text='<%# Eval("News_Title") %>' />--%></div></td>
        <td bgcolor="#FFFFFF"  style="height: 20px"><div align="center"><%# Eval("date")%>...</div></td>
        <td bgcolor="#FFFFFF" style="height: 20px"><div align="center" >
       <%-- <asp:Label ID="Label2" runat="server" Text="Label" style="display: none"></asp:Label>--%>
         <asp:LinkButton ID="LinkButton1" OnClientClick="return confirm('确定删除?');"  CommandArgument=' <%# Eval("ID") %>' CommandName="delete" runat="server" > 删除</asp:LinkButton> |  <a href="Updaterizhi.aspx?id=<%# Eval("ID") %>"> 编辑</a></div></td>
      </tr>
      </ItemTemplate></asp:Repeater>

    </table>
    </div>
    </form>
</body>
</html>
