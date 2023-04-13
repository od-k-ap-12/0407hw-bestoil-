using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _0411hw.OilForm;

namespace _0411hw
{
    public partial class MenuForm : Form
    {
        public double HotDogPrice = 4;
        public double HamburgerPrice = 5.4;
        public double FriesPrice = 7.2;
        public double ColaPrice = 4.4;
        public double Total = 0;
        public List<Oil> OilTypes = new List<Oil>
        {
            new Oil("A-92",3),
            new Oil("A-95",5),
            new Oil("A-98",8),
            new Oil("Diesel",2)

        };
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(OilTypes);
            editForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CafeForm cafeForm = new CafeForm();
            cafeForm.Menu = this;
            cafeForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OilForm oilForm = new OilForm();
            oilForm.Menu = this;
            oilForm.ShowDialog();
        }
    }
}
