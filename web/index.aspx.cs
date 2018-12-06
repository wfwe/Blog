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

public partial class index : System.Web.UI.Page
{
    BLL_Article bll = new BLL_Article();
    BLL_Type typebll = new BLL_Type();
    BLL_Revert rebll = new BLL_Revert();
    BLL_User userbll = new BLL_User();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            rep.DataSource = bll.GetListRevert(7);
            rep.DataBind();
            reptype.DataSource = typebll.GetList(0);
            reptype.DataBind();
            //最新文章
            repzx.DataSource = bll.GetList(5);
            repzx.DataBind();
            //最新评论
            repzxpl.DataSource = rebll.selectt(5);
            repzxpl.DataBind();
            //个人档案
            repgr.DataSource = userbll.GetList();
            repgr.DataBind();
        }
        //DataTable dt = typebll.GetList(0);
        //Label1.Text = dt.Rows[0][0].ToString();
    }
}
