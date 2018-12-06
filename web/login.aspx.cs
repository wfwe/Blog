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

public partial class login : System.Web.UI.Page
{
    BLL_User userbll = new BLL_User();
    BlogUser usermodel = new BlogUser();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = this.TextBox1.Text;
        string UseerPwd = this.TextBox2.Text;

        bool a = userbll.Exists(UserName, UseerPwd);
        if (a)
        {
            Session["user"] = UserName;
            Response.Redirect("guanli.aspx");
        }
        else
        {
            Response.Write("<script language=javascript>alert('请重新输入！')</script>");

        }
    }
}
