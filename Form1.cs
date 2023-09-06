using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standard_quadratic_root_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double x, y;
            try
            {               
                x = (-(double.Parse(txt_b.Text)) + Math.Sqrt((double.Parse(txt_b.Text) * double.Parse(txt_b.Text)) - 4 * (double.Parse(txt_a.Text)) * (double.Parse(txt_c.Text)))) / (2 * (double.Parse(txt_a.Text)));
                y = (-(double.Parse(txt_b.Text)) - Math.Sqrt((double.Parse(txt_b.Text) * double.Parse(txt_b.Text)) - 4 * (double.Parse(txt_a.Text)) * (double.Parse(txt_c.Text)))) / (2 * (double.Parse(txt_a.Text)));
            }
            catch
            {
                MessageBox.Show("Enter valid inputs","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }           
            if(((double.Parse(txt_b.Text) * double.Parse(txt_b.Text)) - 4 * (double.Parse(txt_a.Text)) * (double.Parse(txt_c.Text)))>0)
                {
                lblRoots.Text = "Number of roots:2"+"  : "+x.ToString("0.0000")+" , "+y.ToString("0.0000");
            }
            if (((double.Parse(txt_b.Text) * double.Parse(txt_b.Text)) - 4 * (double.Parse(txt_a.Text)) * (double.Parse(txt_c.Text))) == 0)
            {
                lblRoots.Text = "Number of roots:1" + "  : " + x.ToString("0.0000");
            }
            if(((double.Parse(txt_b.Text) * double.Parse(txt_b.Text)) - 4 * (double.Parse(txt_a.Text)) * (double.Parse(txt_c.Text))) < 0)
            {
                lblRoots.Text = "Number of roots:None";
            }
        }

        private void btnNewProblem_Click(object sender, EventArgs e)
        {
            lblRoots.Text = "Number of roots";
            txt_a.Text = string.Empty;
            txt_b.Text = string.Empty;
            txt_c.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
