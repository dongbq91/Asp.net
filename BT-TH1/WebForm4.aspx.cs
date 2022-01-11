using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BT_TH1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTinh_Click(object sender, EventArgs e)
        {
            
            {
                int a, b, c, delta;
                float x1, x2, sqrt_delta;
                a = Convert.ToInt32(txtSoA.Text);
                b = Convert.ToInt32(txtSoB.Text);
                c = Convert.ToInt32(txtSoC.Text);
                delta = b * b - 4 * a * c;

                if (delta < 0) txtkp.Text = "Vô nghiệm";
                else
                    if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    txtkp.Text = "Phương trình có nghiệm kép: x=" + Convert.ToString(x1);
                }
                else
                {
                    sqrt_delta = (float)Math.Sqrt(delta);
                    x1 = (-b + sqrt_delta) / (2 * a);
                    x2 = (-b - sqrt_delta) / (2 * a);
                    txtkp.Text = "Phương trình có 2 nghiệm phân biệt:\n  x1 = " + Convert.ToString(x1) + "\n x2 = " + Convert.ToString(x2);
                }
            }
            
        }

    }
}