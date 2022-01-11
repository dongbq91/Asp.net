using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BT_TH1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int bacLuong = Int32.Parse(txtBacLuong.Text), ngayCong = Int32.Parse(txtNgayCong.Text), pc = 100000, tl;
            string cv = listCV.SelectedValue;
            switch (cv)
            {
                case "tp":
                    pc = 500000;
                    break;
                case "pp":
                    pc = 300000;
                    break;
                case "nv":
                    pc = 100000;
                    break;
            }
            if (ngayCong >= 25)
            {
                ngayCong = (ngayCong - 25) * 2 + 25;
            }

            tl = bacLuong * 650000 * ngayCong + pc;
            lbTienLinh.Text = tl.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtmaNV.Text = "";
            txtBacLuong.Text = "";
            txtNgayCong.Text = "";
        }
    }
}