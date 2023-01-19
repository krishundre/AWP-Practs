using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practon12th
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            if (CheckBox2.Checked)
                Label2.Font.Italic = true;
            else
                Label2.Font.Italic = false;
        }
        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            if (CheckBox3.Checked)
                Label2.Font.Underline = true;
            else
                Label2.Font.Underline = false;
        }


        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            Label2.ForeColor = System.Drawing.Color.Red;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            Label2.ForeColor = System.Drawing.Color.Green;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            Label2.ForeColor = System.Drawing.Color.Blue;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
            if (CheckBox1.Checked)
                Label2.Font.Bold = true;
            else
                Label2.Font.Bold = false;
        }
    }
}