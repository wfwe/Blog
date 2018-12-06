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

public partial class Updaterizhi : System.Web.UI.Page
{
    BLL_Article arcbll = new BLL_Article();
    Model.Article model = new Model.Article();
    BLL_Type typbll = new BLL_Type();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            select();
        }
    }
    public void select()
    {
         int id = Convert.ToInt32(Request.QueryString["id"].ToString());
        model = arcbll.GetModel(id);
        DataTable dt = typbll.GetList(0);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DropDownList1.Items.Add(new ListItem(dt.Rows[i]["Type"].ToString(), dt.Rows[i]["ID"].ToString()));

        }
        this.TextBox1.Text = model.Subject.ToString();
        this.TextBox2.Text = model.Content.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        model.Subject = this.TextBox1.Text;
        model.Content = this.TextBox2.Text;
        model.TypeId =Convert.ToInt32( DropDownList1.SelectedValue);
        model.Author = "个人";
        model.Count = 0;
        model.ID = Convert.ToInt32(Request.QueryString["id"].ToString());
        arcbll.Update(model);
       Response.Write("<script>alert('修改成功！')</script>");
    } 
}
