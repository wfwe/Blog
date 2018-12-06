<%@ Page Language="C#" AutoEventWireup="true" CodeFile="guanli.aspx.cs" Inherits="guanli" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
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
          <div class="stage" valign="top">
   
<iframe id="fid" src="index.html" width="90%" height="500"  marginheight="0" frameborder="0" scrolling="no" vspace="0" 
hspace="0"  marginwidth="0" border="0" ></iframe>



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
