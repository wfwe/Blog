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

public partial class adddangan : System.Web.UI.Page
{
    BLL_User userbll = new BLL_User();
    BlogUser usermo = new BlogUser();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            select();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        usermo.Name =this.txtxm.Text;
        usermo.sex=this.TextBox2.Text;
        usermo.Birthday=Convert.ToDateTime(this.txtrq.Text);
        usermo.Fristaddress=this.txtdz.Text;
        usermo.Secondaddress=this.txtjz.Text ;
        usermo.Email=this.txtEimal.Text ;
        usermo.School =this.txtjd.Text;
        usermo.ID = 1;
        userbll.Update(usermo);
        Response.Write("<script>alert('修改成功！')</script>");
        select();
    }
    public void select()
    {

        this.txtxm.Text = userbll.GetList().Rows[0]["Name"].ToString();
        this.TextBox2.Text = userbll.GetList().Rows[0]["sex"].ToString();
        this.txtrq.Text = userbll.GetList().Rows[0]["Birthday"].ToString();
        this.txtdz.Text = userbll.GetList().Rows[0]["Fristaddress"].ToString();
        this.txtjz.Text = userbll.GetList().Rows[0]["Secondaddress"].ToString();
        this.txtEimal.Text = userbll.GetList().Rows[0]["Email"].ToString();
        this.txtjd.Text = userbll.GetList().Rows[0]["School"].ToString();
       
    }
}
