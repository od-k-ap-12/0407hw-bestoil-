using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0407hw
{
    struct Petrol
    {
        public string Name { get;set; }
        public double Price { get;set; }
        public Petrol(string name, double price)
        {
            Name=name;
            Price=price;
        }
    }
    public partial class Form1 : Form
    {
        MainMenu MainMenu;
        MenuItem Next, Exit, Reset;
        List<Petrol> PetrolTypes = new List<Petrol>
        {
            new Petrol("A-92",3),
            new Petrol("A-95",5),
            new Petrol("A-98",8),
            new Petrol("Diesel",2)

        };
        public Form1()
        {
            InitializeComponent();
            foreach (Petrol Petrol in PetrolTypes)
            {
                PetrolComboBox.Items.Add(Petrol.Name);
            }
            MainMenu = new MainMenu();

            Next = new MenuItem("Next");
            Next.Select += new EventHandler(Next_Click);
            MainMenu.MenuItems.Add(Next);

            Exit = new MenuItem("Exit");
            Exit.Click += new EventHandler(Exit_Click);
            MainMenu.MenuItems.Add(Exit);

            Reset = new MenuItem("Reset");
            Reset.Click += new EventHandler(Reset_Click);
            MainMenu.MenuItems.Add(Reset);
            Menu = MainMenu;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Close();
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


        private void CalculatePetrolPrice_Click(object sender, EventArgs e)
        {
            if (Quantity.Checked)
            {
                if (PetrolPrice.Text != null&&QuantityTB.Text!=null)
                {
                    FinalPetrolPrice.Text=Convert.ToString(Convert.ToDouble(QuantityTB.Text)*Convert.ToDouble(PetrolPrice.Text));
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
                    }
                }
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
            FinalCafePrice.Text=Convert.ToString(Total);
        }

        private void PetrolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                foreach (Petrol Petrol in PetrolTypes)
            {
                if (Petrol.Name == (string)PetrolComboBox.SelectedItem)
                {
                    PetrolPrice.Text = Convert.ToString(Petrol.Price);
                }
            }
        }

        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            QuantityTB.Enabled= true;
            MoneyTB.Enabled= false;
        }

        private void Money_CheckedChanged(object sender, EventArgs e)
        {
            QuantityTB.Enabled = false;
            MoneyTB.Enabled = true;
        }

        private void CalculatePrice_Click(object sender, EventArgs e)
        {
            double Total = 0;
            if(FinalPetrolPrice.Text != null)
            {
                Total += Convert.ToDouble(FinalPetrolPrice);

            }
            if(FinalCafePrice.Text != null)
            {
                Total += Convert.ToDouble(FinalCafePrice);
            }
            FinalPrice.Text = Convert.ToString(Total);
        }
    }
}
