<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>

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
                                                        <span class="modtit"> �鿴����</span></div>
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
                                    
                                    <asp:Repeater id="rep" runat="server"><ItemTemplate>
                                  
                                   
              
              
                <div class=tit align="center"><%# Eval ("Subject")%></div>
                <div class=date><%# Eval ("Date") %></div>
              <div align="left" valign="top"><%# Eval ("Content") %>
               </div>
                
                <div class=opt>���<%# Eval("Type")%> | ����(0) 
                  | ���(<%# Eval("Count")%>
                  
                  ) </div>
                <span class="opt"></span>
               
                <div class=line></div>
              
               </ItemTemplate></asp:Repeater>
               <asp:Repeater ID="reppl" runat="server"><ItemTemplate>
               <div class=tit align="left">�������ۣ�</div>
                <%--<div class=date><%# Eval("date")%></div>--%>
              <div align="left" valign="top"> ���ѣ�<%# Eval("user")%>   ʱ�䣺<%# Eval("date")%>
               </div>
               <div align="left" valign="top"><%# Eval("Content")%>
               </div>
                </ItemTemplate></asp:Repeater>
                
                <span class="opt"></span>
               
                <div class=line></div>
              
                  <div align="left">
                  <table cellpadding="0" cellspacing="0" style="height: 168px; width: 516px">
  <tr>
    <td valign="top" width="200">�ա�����</td>
    <td>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
      </td>
  </tr>

  <tr>
    <td id="reTitle">�ڡ��ݣ�</td>
    <td>
        <asp:TextBox ID="TxtCon" runat="server" Height="100px" 
             TextMode="MultiLine" Width="450px"></asp:TextBox>
                                                    </td>
  </tr>
 
  <tr>
    <td class="style1">&nbsp;</td>
    <td>&nbsp;<asp:Button ID="BtnOk" runat="server" Text="�������" onclick="BtnOk_Click" />
      </td>
  </tr>
</table>
               </div>
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


