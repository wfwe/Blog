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
using Model;

public partial class news : System.Web.UI.Page
{
    Revert revmodel = new Revert();
    BLL_Article Arcbll = new BLL_Article();
    BLL_Revert Revbll = new BLL_Revert();
    Article artmodel = new Article();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"].ToString());
            //日志全文
            rep.DataSource = Arcbll.GetList(id);
            rep.DataBind();
            //浏览一次加一
            artmodel.ID = id;
            Arcbll.addCount(artmodel);
            select();
        }


    }
    /// <summary>
    /// 文章评论
    /// </summary>
    public void select()
    {
        int id = Convert.ToInt32(Request.QueryString["ID"].ToString());
        reppl.DataSource = Revbll.GetList(id);
        reppl.DataBind();


    }
    protected void BtnOk_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["ID"].ToString());
        revmodel.User = TxtName.Text;
        revmodel.Content = TxtCon.Text;
        revmodel.ArticleID = id;

        Revbll.Add(revmodel);
        Response.Write("<script>alert('添加成功！')</script>");
        select();
        TxtCon.Text = null;
        TxtName.Text = null;
    }
}
