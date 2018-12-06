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

public partial class addrizhi : System.Web.UI.Page
{
    Article art = new Article();
    BLL_Article arcbll = new BLL_Article();
    BLL_Type typebll = new BLL_Type();
    BlogType blmodel = new BlogType();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        select();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //日志添加
        art.Author = "个人";
        art.Subject = this.TextBox1.Text;
        art.Content = this.TextBox2.Text;
        art.Count = 0;
        art.TypeId =Convert.ToInt32( this.DropDownList1.SelectedValue);
        arcbll.Add(art);
        this.TextBox1.Text = null;
        this.TextBox2.Text = null;
        Response.Write("<script>alert('添加成功！')</script>");
    }
    public void select()
    {


        DropDownList1.Items.Clear();
        DataTable dt = typebll.GetList(0);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
           
            DropDownList1.Items.Add(new ListItem(dt.Rows[i]["Type"].ToString(), dt.Rows[i]["ID"].ToString()));

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        blmodel.Type = this.TextBox3.Text;
        typebll.Add(blmodel);
        DropDownList1.Items.Clear();
        this.TextBox3.Text = null;
        select();
    }
}
