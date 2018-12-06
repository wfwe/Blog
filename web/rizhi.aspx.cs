using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using BLL;

public partial class rizhi : System.Web.UI.Page
{
    BLL_Article Artbll = new BLL_Article();
    BLL_Revert rebll = new BLL_Revert();
    protected void Page_Load(object sender, EventArgs e)
    {
        rep.DataSource = Artbll.GetListRevert(0);
        rep.DataBind();
        reptype.DataSource = Artbll.GetList(0);
        reptype.DataBind();
        //最新评论
        repzxpl.DataSource = rebll.selectt(5);
        repzxpl.DataBind();
    }
}
