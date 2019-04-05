using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBudget_Click(object sender, EventArgs e)
        {





            if (tbInc1 != null && tbInc2 != null)
            {
                 tbIncTotal.Text = Convert.ToString(Convert.ToInt32(tbInc1.Text) + Convert.ToInt32(tbInc2.Text));
            }




        }
    }
}
