<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>taotao的空间</title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312"/>
    <style type="text/css">
        #layout
        {
            table-layout: fixed;
        }
        #layout TD.c2t1
        {
            padding-left: 10px;
        }
        #layout TD.c2t2
        {
            width: 20px;
        }
        #layout TD.c2t3
        {
            padding-right: 10px;
            width: 24%;
        }
        </style>
    <link href="images/mods.css" type="text/css" rel="stylesheet"/>
    <link href="images/486f3981b480bad79123d9a9.css" type="text/css" rel="stylesheet"/>
    <link href="images/space.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="main" align="left">
            <div id="header">
                <div class="lc">
                    <div class="rc">
                    </div>
                </div>
                <div class="tit">
                    潮哥哥的空间</div>
                <div class="desc">
                    突破目标,实现理想,超越潮哥~~无需太多言语,行动最实际</div>
                <div id="tabline">
                </div>
  <DIV id=tab><!--个人档案页--><!--首页--><A 
href="index.aspx">主页</A><A 
href="rizhi.aspx">博客</A><SPAN>|</SPAN><A 
href="xiangce.aspx">相册</A><SPAN>|</SPAN><A 
href="gerendangan.aspx">个人档案</A> <SPAN>|</SPAN><A 
href="login.aspx">管理中心</A> </DIV>
            </div>
            <div class="stage">
                <table id="layout" cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tbody>
                        <tr>
                            
                            <td valign="middle" class="c2t3">
                                <!-- end mod_profile -->
                                <table border="0" cellpadding="0" cellspacing="0" 
                                    style="height: 79px; width: 251px">
                                  <tr>
                                    <td width="70">用户名：</td>
                                    <td width="95" align="left">
                                        <asp:TextBox ID="TextBox1" runat="server" Width="130px"></asp:TextBox>
                                            </td>
                                    <td width="56" rowspan="2" valign="middle">
                                        <asp:Button ID="Button1" runat="server" Height="51px" onclick="Button1_Click" 
                                            Text="登录" />
                                            </td>
                                  </tr>
                                  <tr>
                                    <td>密 码：</td>
                                    <td align="left">
                                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="130px"></asp:TextBox>
                                            </td>
                                  </tr>
                                </table></td>
                        </tr>
                    </tbody>
                </table>
                <!---class="stage" --->
            </div>
            <!---id="main" --->
        </div>
        <br>
        <br>
    </div>
    </form>
</body>
</html>

