using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _0411hw.OilForm;

namespace _0411hw
{
    public partial class EditForm : Form
    {

        public double HotDogPrice;
        public double HamburgerPrice;
        public double FriesPrice;
        public double ColaPrice;
        public List<Oil> OilTypes = new List<Oil>();
        public EditForm()
        {
            InitializeComponent();
            foreach (Oil Oil in OilTypes)
            {
                comboBox1.Items.Add(Oil.Name);
            }

        }
        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            Hamburger.Enabled = false;
            Fries.Enabled = false;
            CocaCola.Enabled = false;
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            HotDog.Enabled = false;
            Fries.Enabled = false;
            CocaCola.Enabled = false;
        }

        private void Fries_CheckedChanged(object sender, EventArgs e)
        {
            Hamburger.Enabled = false;
            HotDog.Enabled = false;
            CocaCola.Enabled = false;
        }
        private void CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            Hamburger.Enabled = false;
            Fries.Enabled = false;
            HotDog.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                MessageBox.Show("Error");
            }
            else
            {
                if (Hamburger.Checked)
                {
                    HamburgerPrice = Convert.ToDouble(textBox2.Text);
                }
                else if(Fries.Checked)
                {
                    FriesPrice = Convert.ToDouble(textBox2.Text);
                }
                else if (CocaCola.Checked)
                {
                    ColaPrice = Convert.ToDouble(textBox2.Text);
                }
                else if (HotDog.Checked)
                {
                    HotDogPrice = Convert.ToDouble(textBox2.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Error");
            }
            else
            {
                foreach (Oil Petrol in OilTypes)
                {
                    if (Petrol.Name == (string)comboBox1.SelectedItem)
                    {
                        Petrol.Price = Convert.ToDouble(textBox1);
                    }
                }
            }
        }
    }
}
