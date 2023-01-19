using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practon12th
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            for (int i = 0;i < ListBox1.Items.Count; i++){
                if (ListBox1.Items[i].Selected == true)
                    TextBox1.Text = TextBox1.Text + ListBox1.Items[i].Text + "\n";
            }
        }
    }
}