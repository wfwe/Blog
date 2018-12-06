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
public partial class tupian : System.Web.UI.Page
{
    BLL_Picture picbll = new BLL_Picture();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        int id =Convert.ToInt32(Request.QueryString["id"].ToString());
        dat.DataSource = picbll.GetlestID(id);
        dat.DataBind();
    }
}
