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

public partial class gerendangan : System.Web.UI.Page
{
    
    BLL_Message Mesbll = new BLL_Message();
    Message Mesmodel = new Message();
    BLL_User userbll = new BLL_User();
    BLL_Type typebll = new BLL_Type();
    BLL_Article bll = new BLL_Article();
    BLL_Revert rebll = new BLL_Revert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //个人档案
            repg.DataSource = userbll.GetList();
            repg.DataBind();
            repgr.DataSource = userbll.GetList();
            repgr.DataBind();
            select();
            reptype.DataSource = typebll.GetList(0);
            reptype.DataBind();
            repzx.DataSource = bll.GetList(5);
            repzx.DataBind();
            //最新评论
            repzxpl.DataSource = rebll.selectt(5);
            repzxpl.DataBind();
        }
    }
    public void select()
    {
        reppl.DataSource = Mesbll.GetList(0);
        reppl.DataBind();
    }
    protected void BtnOk_Click(object sender, EventArgs e)
    {
        Mesmodel.User = this.TxtName.Text;
        Mesmodel.UserMessage = this.TxtCon.Text;

        Mesbll.Add(Mesmodel);
        Response.Write("<script>alert('添加成功！')</script>");
        select();
        this.TxtName = null;
        this.TxtCon = null;
    }
}
