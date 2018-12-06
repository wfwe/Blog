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

public partial class jiben : System.Web.UI.Page
{
    BLL_User userbll = new BLL_User();
    protected void Page_Load(object sender, EventArgs e)
    {
        repjb.DataSource = userbll.GetList();
        repjb.DataBind();
    }
}
