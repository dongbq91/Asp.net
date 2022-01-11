using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BT_TH1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lblThu_Nhapp_Click(object sender, EventArgs e)
        {
            lblThu_Nhapp.Text = "Bạn chọn thu nhập: " + rblThu_Nhap.SelectedItem.Text;
        }
    }
}