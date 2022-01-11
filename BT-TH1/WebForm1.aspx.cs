using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BT_TH1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTinh_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = Int32.Parse(txtSoA.Text);
            so2 = Int32.Parse(txtSoB.Text);
            tong = so1 + so2;
            txtTong.Text = tong.ToString();
        }
    }
}