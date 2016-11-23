using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _2016b2_B2D3_Demo.Models;

namespace _2016b2_B2D3_Demo
{
    public partial class DemoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var entiteit = new MijnEntiteit();
            TextBox1.Text = entiteit.DemoString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = "Date changed";
        }
    }
}