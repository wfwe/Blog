using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DAL;
using BLL;
public partial class _Default : System.Web.UI.Page 
{
    BLL_Type typebll = new BLL_Type();
    DAL_Article dal = new DAL_Article();
    Model.Article model = new Model.Article();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            
        //}
        rep.DataSource = typebll.GetList(0);
        rep.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        model = dal.GetModel(1);
        Label1.Text = model.Author.ToString();
    }
}
