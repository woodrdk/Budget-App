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

            double elec = Convert.ToInt32(tbElec.Text);
            double phone = Convert.ToInt32(tbElec.Text);
            double cable = Convert.ToInt32(tbCable.Text);
            double water = Convert.ToInt32(tbWater.Text);
            double trash = Convert.ToInt32(tbTrash.Text);
            double mort = Convert.ToInt32(tbMortgage.Text);
            double sewer = Convert.ToInt32(tbSewer.Text);
            double houseTotal = elec + phone + cable + water + trash + mort + sewer;
            tbHouseTotal.Text = Convert.ToString(houseTotal);

            double incomeTotal = Convert.ToInt32(tbInc1.Text) + Convert.ToInt32(tbInc2.Text);

            if (tbInc1 != null && tbInc2 != null)
            {
                 tbIncTotal.Text = Convert.ToString(incomeTotal);
            }

            // insurances
            double carIns = Convert.ToInt32(tbCarIns.Text);
            double medIns = Convert.ToInt32(tbMedIns.Text);
            double lifeIns = Convert.ToInt32(tbLifeIns.Text);
            double insTotal = carIns + medIns + lifeIns;
            tbInsTotal.Text = Convert.ToString(insTotal);

            // Credit Cards
            double cc1 = Convert.ToInt32(tbCC1.Text);
            double cc2 = Convert.ToInt32(tbCC2.Text);
            double creditTotal = cc1 + cc2; 
            tbCreditTotal.Text = Convert.ToString(creditTotal);



            double billTotal = 0;
            double allTheBills = houseTotal + creditTotal + insTotal + billTotal;
            string AllBillTotal = Convert.ToString(allTheBills);
            tbBillTotal.Text = AllBillTotal;
            tbBillEnd.Text = AllBillTotal;
            tbIncEnd.Text = Convert.ToString(incomeTotal);
            tbLeftOver.Text = Convert.ToString(incomeTotal - allTheBills);

        }
    }
}
