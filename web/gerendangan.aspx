<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gerendangan.aspx.cs" Inherits="gerendangan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>taotao�Ŀռ�</title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
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
        .style1
        {
            background: url(  'images/b45a933de6a6a7cb3d6d979d.gif' ) repeat-x;
            width: 210px;
        }
    </style>
    <link href="images/mods.css" type="text/css" rel="stylesheet" />
    <link href="images/486f3981b480bad79123d9a9.css" type="text/css" rel="stylesheet" />
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
                            <td class="c2t3" valign="top">
                                <div class="mod" id="mod_profile" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" nowrap>
                                                    <div class="modhead" align="left">
                                                        <span class="modtit">���˵���</span></div>
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
                                    <div class="modbox" id="m_pro">
                                        <div class="wrapper" align="left">
                                        <asp:Repeater ID="repg" runat="server"><ItemTemplate>
                                                <nobr><b><%#Eval("Name")%></b></nobr>
                                                <br>
                                                <nobr><%# Eval("sex")%>,&nbsp;<%#Eval("Birthday") %></nobr>
                                                <br>
                                                <nobr><%# Eval("Email")%></nobr>
                                                <br>
                                                <nobr><%# Eval("School")%>&nbsp;</nobr>
                                                <br>
                                                <nobr><%# Eval("Secondaddress")%></nobr>
                                                </ItemTemplate></asp:Repeater>
                                        </div>
                                        <!-- end act-->
                                    </div>
                                    <!-- end m_pro -->
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
                                </div>
                                <!-- end mod_profile -->
                                <div id="_redirect_to_passport" style="display: none">
                                </div>
                                <div class="mod" id="mod_artclg" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" nowrap>
                                                    <div class="modhead" align="left">
                                                        <span class="modtit">���·���</span></div>
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
                                    <div class="modbox" id="m_artclg">
                                        <asp:Repeater ID="reptype" runat="server">
                                            <ItemTemplate>
                                                <div class="item" align="left">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <%# Eval("Type")%>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <%# Eval("Type")%>
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
                                </div>
                                <div class="mod" id="mod_comment" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" nowrap>
                                                    <div class="modhead" align="left">
                                                        <span class="modtit">��������</span></div>
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
                                    <div class="modbox" id="m_comment">
                                <asp:Repeater ID="repzxpl" runat="server"><ItemTemplate>
                                        
                                        <DIV class=item align="left"><%# Eval("Content") %> </DIV></ItemTemplate></asp:Repeater>
                                        </div>
                                    </div>
                                    <table height="8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modbl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="style1">
                                                    &nbsp;
                                                </td>
                                                <td class="modbr" width="7">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="mod" id="mod_friblog" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" nowrap>
                                                    <div class="modhead" align="left">
                                                        <span class="modtit">��������</span></div>
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
                                    <div class="modbox" id="m_friblog">
                                    <asp:Repeater ID="repzx" runat="server"><ItemTemplate>
                                        <div id="cmttab0">
                                           <a href='news.aspx?id=<%# Eval("ID") %>'><%# Eval("Subject")%></a>
                                        </div></ItemTemplate></asp:Repeater></div>
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
                                </div>
                            </td>
                            <td class="c2t2" style="width: 5px">
                                &nbsp;
                            </td>
                            <td valign="top" class="c2t1">
                                <div class="mod" id="mod_bloglist" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" align="left">
                                                    <div class="modhead">
                                                        <span class="modtit">�ҵ�����</span></div>
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
                                    
                                            <div class="modbox" id="m_blog" align="left">
                                               <asp:Repeater ID="repgr" runat="server">
                                        <ItemTemplate>
                                                ������<%# Eval("Name") %><br />
                                                �Ա�<%# Eval("sex")%><br />
                                                ���գ�<%# Eval("Birthday") %><br />
                                                �����أ�<%# Eval("Fristaddress")%><br />
                                                Ŀǰ��ס�أ�<%# Eval("Secondaddress")%>
                                                <br />
                                                �ҾͶ�����ѧУ��<%# Eval("School")%>
                                                <br />
                                                Eimal:<%# Eval("Email") %><br />
                                               </ItemTemplate>
                                    </asp:Repeater>
                                            </div>
                                        
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
                                <div class="mod" id="Div1" rel="drag">
                                    <table class="modth" cellspacing="0" cellpadding="0" width="100%" border="0">
                                        <tbody>
                                            <tr>
                                                <td class="modtl" width="7">
                                                    &nbsp;
                                                </td>
                                                <td class="modtc" align="left">
                                                    <div class="modhead">
                                                        <span class="modtit">���԰�</span></div>
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
                                    <div class="modbox" id="Div2" align="left">
                                        <asp:Repeater ID="reppl" runat="server">
                                            <ItemTemplate>
                                                <div class="tit" align="left">
                                                    �������ۣ�</div>
                                                <div align="left" valign="top">
                                                    ���ѣ�<%# Eval("User")%>
                                                    ʱ�䣺<%# Eval("date")%>
                                                </div>
                                                <div align="left" valign="top">
                                                    <%# Eval("UserMessage")%>
                                                </div>
                                                <div class="line">
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <table width="516" height="267" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td valign="top" width="60">
                                                    �� ����
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td id="reTitle">
                                                    �� �ݣ�
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TxtCon" runat="server" Height="198px" TextMode="MultiLine" Width="454px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    &nbsp;<asp:Button ID="BtnOk" runat="server" Text="�������" OnClick="BtnOk_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
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
