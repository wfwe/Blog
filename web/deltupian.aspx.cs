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

public partial class deltupian : System.Web.UI.Page
{
    BLL_Picture picbll = new BLL_Picture();
    protected void Page_Load(object sender, EventArgs e)
    {
        select();
      
    }
    public void select()
    {
        reptp.DataSource = picbll.GetList();
        reptp.DataBind();
    }

    protected void reptp_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);

            picbll.Delete(id);
            select();
        }
    }
}
