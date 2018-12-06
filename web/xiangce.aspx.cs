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

public partial class xiangce : System.Web.UI.Page
{
    BLL_Picture picbll = new BLL_Picture();
    BLL_PictureType pictype = new BLL_PictureType();
    protected void Page_Load(object sender, EventArgs e)
    {
        dat.DataSource = pictype.GetList();
        dat.DataBind();
    }
}
