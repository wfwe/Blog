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
using Model;
using BLL;
using System.IO;
public partial class manageImg : System.Web.UI.Page
{
    BLL.BLL_PictureType ptbll = new BLL.BLL_PictureType();
    Model.PictureType ptmodel = new Model.PictureType();
    BLL.BLL_Picture pbll = new BLL.BLL_Picture();
    Model.Picture pmodel = new Model.Picture();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          bandlist();
        }
    }
    protected void addImgType_Click(object sender, EventArgs e)
    {
        ptmodel.TypeName = ImgType.Text.Trim();
        if (ptmodel.TypeName == "")
        {
            Response.Write("<script>alert('名称不能这空')</script>");
        }
        else
        {
            bool b = ptbll.Exists(ptmodel.TypeName);
            if (b)
            {
                Response.Write("<script>alert('此名称已存在')</script>");
            }
            else
            {
                ptbll.Add(ptmodel);
                bandlist();
                Response.Write("<script>alert('添加成功')</script>");
            }
        }
    }
    private void bandlist()
    {
        DataTable dt = ptbll.GetList();
        DList.Items.Clear();
        DList.DataSource = dt.DefaultView;
        DList.DataTextField = "TypeName";
        DList.DataValueField = "ID";
        DList.DataBind();

    }
    protected void btnupimage_Click(object sender, EventArgs e)
    {
        img.Visible = false;
        //获取上传文件完整路径
        string fullname = this.uploadimage.PostedFile.FileName;
        //创建fileinfo类实例
        FileInfo fl = new FileInfo(fullname);
        //获取文件名
        string name = fl.Name;
        if (name != "")
        {
            name = DateTime.Now.Ticks.ToString();
        }
        //获取图片扩展名
        string type = fl.Extension;
        if (".gif" == type || ".jpg" == type || ".GIF" == type || ".JPG" == type)
        {
            //定义保存图片路径
            string savepath = Server.MapPath("images");
            //保存上传的图片
            this.uploadimage.PostedFile.SaveAs(savepath + "\\" + name+type);
            this.img.Visible = true;
            //设置显示图片地址
            this.img.ImageUrl = "images" + "/" + name;
            pmodel.ImgName = name + type;
            pmodel.ImgUrl = "images" + "/" + name + type;
            pmodel.Imgsdescribe = imgname.Text.Trim();
            pmodel.TypeId = Convert.ToInt32(DList.SelectedValue);
            pbll.Add(pmodel);

        }
        else
        {
            Response.Write("<script>alert('请选择选择选择jpg或gif格式图片！')</script>");
        }
    }
}
