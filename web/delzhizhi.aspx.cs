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

public partial class delzhizhi : System.Web.UI.Page
{
    BLL_Article artbll = new BLL_Article();
    protected void Page_Load(object sender, EventArgs e)
    {
        select();
    }
    public void select()
    {
        rep1.DataSource = artbll.GetList(0);
        rep1.DataBind();
    }
 

    protected void rep1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);

            artbll.Delete(id);
            select();
        }
    }
}
