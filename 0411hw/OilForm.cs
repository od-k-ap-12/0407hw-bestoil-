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
    public partial class OilForm : Form
    {
        public class Oil
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public Oil(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }
        public List<Oil> OilTypes = new List<Oil>();
/*        {
            new Oil("A-92",3),
            new Oil("A-95",5),
            new Oil("A-98",8),
            new Oil("Diesel",2)

        };*/
        public MenuForm Menu { get; set; }
        public OilForm()
        {

            InitializeComponent();
            foreach (Oil Oil in OilTypes)
            {
                PetrolComboBox.Items.Add(Oil.Name);
            }
        }
        private void CalculatePetrolPrice_Click(object sender, EventArgs e)
        {
            if (Quantity.Checked)
            {
                if (PetrolPrice.Text != null && QuantityTB.Text != null)
                {
                    FinalPetrolPrice.Text = Convert.ToString(Convert.ToDouble(QuantityTB.Text) * Convert.ToDouble(PetrolPrice.Text));
                    Menu.Total += Convert.ToDouble(FinalPetrolPrice.Text);
                }
            }
            else if (Money.Checked)
            {
                if (PetrolPrice.Text != null && MoneyTB.Text != null)
                {
                    if (Convert.ToDouble(MoneyTB.Text) < Convert.ToDouble(PetrolPrice))
                    {
                        MessageBox.Show("Недостатньо коштів");
                    }
                    else
                    {
                        FinalPetrolPrice.Text = MoneyTB.Text;
                        Menu.Total += Convert.ToDouble(FinalPetrolPrice.Text);
                    }
                }
            }
        }
        private void PetrolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Oil Petrol in OilTypes)
            {
                if (Petrol.Name == (string)PetrolComboBox.SelectedItem)
                {
                    PetrolPrice.Text = Convert.ToString(Petrol.Price);
                }
            }
        }

        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            QuantityTB.Enabled = true;
            MoneyTB.Enabled = false;
        }
        private void Money_CheckedChanged(object sender, EventArgs e)
        {
            QuantityTB.Enabled = false;
            MoneyTB.Enabled = true;
        }
    }
}
