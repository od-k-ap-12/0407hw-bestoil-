using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0411hw
{
    public partial class CafeForm : Form
    {

        public MenuForm Menu { get; set; }
        public CafeForm()
        {
            InitializeComponent();
        }
        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDog.Checked)
            {
                HotDogQuantity.Enabled = true;
            }
            else
            {
                HotDogQuantity.Enabled = false;
            }
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (Hamburger.Checked)
            {
                HamburgerQuantity.Enabled = true;
            }
            else
            {
                HamburgerQuantity.Enabled = false;
            }
        }

        private void Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (Fries.Checked)
            {
                FriesQuantity.Enabled = true;
            }
            else
            {
                FriesQuantity.Enabled = false;
            }
        }
        private void CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola.Checked)
            {
                ColaQuantity.Enabled = true;
            }
            else
            {
                ColaQuantity.Enabled = false;
            }
        }
        private void CalculateCafePrice_Click(object sender, EventArgs e)
        {
            double Total = 0;
            if (HotDogQuantity.Text != null)
            {
                Total += Convert.ToDouble(HotDogQuantity.Text) * Convert.ToDouble(HotDogPrice);
            }
            if (HamburgerQuantity.Text != null)
            {
                Total += Convert.ToDouble(HamburgerQuantity.Text) * Convert.ToDouble(HamburgerPrice);
            }
            if (FriesQuantity.Text != null)
            {
                Total += Convert.ToDouble(FriesQuantity.Text) * Convert.ToDouble(FriesPrice);
            }
            if (ColaQuantity.Text != null)
            {
                Total += Convert.ToDouble(ColaQuantity.Text) * Convert.ToDouble(ColaPrice);
            }
            FinalCafePrice.Text = Convert.ToString(Total);
            Menu.Total += Total;
        }

    }
}
