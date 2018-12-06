<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rizhi.aspx.cs" Inherits="rizhi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>taotao的空间</title>
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
        .style1
        {
            background: url( 'images/b45a933de6a6a7cb3d6d979d.gif' ) repeat-x;
            width: 210px;
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
                    taotao的空间</div>
                <div class="desc">
                    突破目标,实现理想,超越自我~~无需太多言语,行动最实际</div>
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
                                                        <span class="modtit" >文章列表</span></div>
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
                                 <asp:Repeater id="rep" runat="server"><ItemTemplate>
                                  
                                   
                <div class=modbox id=m_blog>
              
                <div class=tit align="left"><a href='news.aspx?id=<%# Eval("ID") %>'><%# Eval ("Subject")%></a></div>
                <div class=date><%# Eval ("Date") %></div>
                <div align="left"><%# Eval ("Content") %></div>
              
                <div class=more><a href='news.aspx?id=<%# Eval("ID") %>'>阅读全文</a></div>
                
                <div class=opt>类别：<%# Eval("Type")%> | 评论(<%# Eval("b")%>)
                  | <a href='news.aspx?id=<%# Eval("ID") %>'>浏览(<%# Eval("Count")%></a>
                  
                  ) </div>
                <span class="opt"></span>
               
                <div class=line></div>
              </div>
               </ItemTemplate></asp:Repeater>
              
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
                            <td class="c2t2">
                                &nbsp;
                            </td>
                            <td valign="top" class="c2t3">
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
                                                        <span class="modtit">文章分类</span></div>
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
                                    <asp:Repeater ID="reptype" runat="server"><ItemTemplate>
                                        <div class="item" align="left">
                                            <%# Eval("type") %></div>
                                          </ItemTemplate></asp:Repeater>
                                            
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
                                                        <span class="modtit">最新评论</span></div>
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
