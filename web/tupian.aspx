<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tupian.aspx.cs" Inherits="tupian" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>taotao�Ŀռ�</title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312">
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
    <link href="images/mods.css" type="text/css" rel="stylesheet">
    <link href="images/486f3981b480bad79123d9a9.css" type="text/css" rel="stylesheet">
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
                    taotao�Ŀռ�</div>
                <div class="desc">
                    ͻ��Ŀ��,ʵ������,��Խ����~~����̫������,�ж���ʵ��</div>
                <div id="tabline">
                </div>
                <DIV id=tab><!--���˵���ҳ--><!--��ҳ--><A 
href="index.aspx">��ҳ</A><A 
href="rizhi.aspx">����</A><SPAN>|</SPAN><A 
href="xiangce.aspx">���</A><SPAN>|</SPAN><A 
href="gerendangan.aspx">���˵���</A> <SPAN>|</SPAN><A 
href="login.aspx">��������</A> </DIV>
            </div>
            <div class="stage">
                <table id="layout" cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tbody>
                        <tr>
                            <td class="c2t1" valign="top">
                                <div class="mod" id="mod_bloglist" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" align="left">
                                                    <div class="modhead">
                                                        <span class="modtit"> ����б�</span></div>
                                                </td>
                                                <td class="modtc" nowrap align="right">
                                                    &nbsp;
                                                </td>
                                                <td class="modtr" width="7">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    
                                    <div class="modbox" id="m_blog">
                                        <asp:DataList ID="dat" runat="server" RepeatColumns="5" 
                                        RepeatDirection="Horizontal" Height="59px" Width="500px"><ItemTemplate>
                              <table border="0" cellspacing="0" cellpadding="0">
                              <tr><td>
                                  <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImgUrl") %>' Height="100px" Width="100px" /></td></tr>
			                   </table>
                                        <span class="opt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("Imgsdescribe")%></span>
                                    </ItemTemplate></asp:DataList> </div>
                                   
                                </div>
                                <table height="8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tbody>
                                        <tr>
                                            <td class="modbl" width="7">
                                                &nbsp;
                                            </td>
                                            <td class="modbc">
                                                &nbsp;
                                            </td>
                                            <td class="modbr" width="7">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
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
