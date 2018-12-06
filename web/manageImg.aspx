<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manageImg.aspx.cs" Inherits="manageImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>博客相管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        
        <table width="600" border="0" cellpadding="0" cellspacing="1" bgcolor="#a8c7ce">
      <tr>
        <td bgcolor="d3eaef" style="height: 20px; width: 4%;"class="TrHead"><div align="center" >
            照片添加
            &nbsp;</div></td>
      </tr>
       
    <tr>
        <td bgcolor="d3eaef" class="STYLE10" style="height: 200px; width:300;">
        <asp:Image ID="img" runat="server" />
            <br />
        <asp:Label ID="Label2" runat="server" Text="描述"></asp:Label>
        <asp:TextBox ID="imgname" runat="server"></asp:TextBox>
            ----<asp:DropDownList ID="DList" runat="server">
        </asp:DropDownList>     
        
        
            <br />
            <br />
        <asp:FileUpload ID="uploadimage" runat="server" />
            <br />
            <br />
        <asp:Button ID="btnupimage" runat="server" Text="添加图片" 
            onclick="btnupimage_Click" />
            <br />
            <br />
        <asp:TextBox ID="ImgType" runat="server"></asp:TextBox>
        <asp:Button ID="addImgType" runat="server" Text="添加相册" 
            onclick="addImgType_Click" />
            <br />
        </td>
       <!-- <td width="10%" bgcolor="d3eaef" class="STYLE6" style="height: 20px"><div align="center"></div></td>  -->     
      </tr>
    
    </table>
    </div>
    </form>
</body>
</html>

