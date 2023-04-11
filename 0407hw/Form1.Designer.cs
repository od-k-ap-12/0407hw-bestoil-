namespace _0407hw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PetrolComboBox = new System.Windows.Forms.ComboBox();
            this.PetrolPrice = new System.Windows.Forms.TextBox();
            this.MoneyTB = new System.Windows.Forms.TextBox();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Money = new System.Windows.Forms.RadioButton();
            this.Quantity = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CalculatePetrolPrice = new System.Windows.Forms.Button();
            this.FinalPetrolPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cola = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColaQuantity = new System.Windows.Forms.TextBox();
            this.FriesQuantity = new System.Windows.Forms.TextBox();
            this.HamburgerQuantity = new System.Windows.Forms.TextBox();
            this.HotDogQuantity = new System.Windows.Forms.TextBox();
            this.ColaPrice = new System.Windows.Forms.TextBox();
            this.FriesPrice = new System.Windows.Forms.TextBox();
            this.HamburgerPrice = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.CocaCola = new System.Windows.Forms.CheckBox();
            this.Fries = new System.Windows.Forms.CheckBox();
            this.Hamburger = new System.Windows.Forms.CheckBox();
            this.HotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CalculateCafePrice = new System.Windows.Forms.Button();
            this.FinalCafePrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FinalPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CalculatePrice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Cola.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PetrolComboBox);
            this.groupBox1.Controls.Add(this.PetrolPrice);
            this.groupBox1.Controls.Add(this.MoneyTB);
            this.groupBox1.Controls.Add(this.QuantityTB);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "л.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "грн.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "грн.";
            // 
            // PetrolComboBox
            // 
            this.PetrolComboBox.FormattingEnabled = true;
            this.PetrolComboBox.Location = new System.Drawing.Point(103, 49);
            this.PetrolComboBox.Name = "PetrolComboBox";
            this.PetrolComboBox.Size = new System.Drawing.Size(130, 21);
            this.PetrolComboBox.TabIndex = 24;
            this.PetrolComboBox.SelectedIndexChanged += new System.EventHandler(this.PetrolComboBox_SelectedIndexChanged);
            // 
            // PetrolPrice
            // 
            this.PetrolPrice.Enabled = false;
            this.PetrolPrice.Location = new System.Drawing.Point(103, 103);
            this.PetrolPrice.Name = "PetrolPrice";
            this.PetrolPrice.Size = new System.Drawing.Size(130, 20);
            this.PetrolPrice.TabIndex = 23;
            // 
            // MoneyTB
            // 
            this.MoneyTB.Enabled = false;
            this.MoneyTB.Location = new System.Drawing.Point(159, 233);
            this.MoneyTB.Name = "MoneyTB";
            this.MoneyTB.Size = new System.Drawing.Size(100, 20);
            this.MoneyTB.TabIndex = 23;
            // 
            // QuantityTB
            // 
            this.QuantityTB.Enabled = false;
            this.QuantityTB.Location = new System.Drawing.Point(159, 176);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(100, 20);
            this.QuantityTB.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Money);
            this.groupBox6.Controls.Add(this.Quantity);
            this.groupBox6.Location = new System.Drawing.Point(16, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 137);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(16, 86);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(51, 17);
            this.Money.TabIndex = 1;
            this.Money.TabStop = true;
            this.Money.Text = "Сума";
            this.Money.UseVisualStyleBackColor = true;
            this.Money.CheckedChanged += new System.EventHandler(this.Money_CheckedChanged);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(16, 31);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(71, 17);
            this.Quantity.TabIndex = 0;
            this.Quantity.TabStop = true;
            this.Quantity.Text = "Кількість";
            this.Quantity.UseVisualStyleBackColor = true;
            this.Quantity.CheckedChanged += new System.EventHandler(this.Quantity_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Бензин";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CalculatePetrolPrice);
            this.groupBox4.Controls.Add(this.FinalPetrolPrice);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(15, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 131);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "До оплати";
            // 
            // CalculatePetrolPrice
            // 
            this.CalculatePetrolPrice.Location = new System.Drawing.Point(13, 28);
            this.CalculatePetrolPrice.Name = "CalculatePetrolPrice";
            this.CalculatePetrolPrice.Size = new System.Drawing.Size(117, 45);
            this.CalculatePetrolPrice.TabIndex = 31;
            this.CalculatePetrolPrice.Text = "Порахувати";
            this.CalculatePetrolPrice.UseVisualStyleBackColor = true;
            this.CalculatePetrolPrice.Click += new System.EventHandler(this.CalculatePetrolPrice_Click);
            // 
            // FinalPetrolPrice
            // 
            this.FinalPetrolPrice.Enabled = false;
            this.FinalPetrolPrice.Location = new System.Drawing.Point(97, 98);
            this.FinalPetrolPrice.Name = "FinalPetrolPrice";
            this.FinalPetrolPrice.Size = new System.Drawing.Size(108, 20);
            this.FinalPetrolPrice.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "грн.";
            // 
            // Cola
            // 
            this.Cola.Controls.Add(this.label2);
            this.Cola.Controls.Add(this.label1);
            this.Cola.Controls.Add(this.ColaQuantity);
            this.Cola.Controls.Add(this.FriesQuantity);
            this.Cola.Controls.Add(this.HamburgerQuantity);
            this.Cola.Controls.Add(this.HotDogQuantity);
            this.Cola.Controls.Add(this.ColaPrice);
            this.Cola.Controls.Add(this.FriesPrice);
            this.Cola.Controls.Add(this.HamburgerPrice);
            this.Cola.Controls.Add(this.HotDogPrice);
            this.Cola.Controls.Add(this.CocaCola);
            this.Cola.Controls.Add(this.Fries);
            this.Cola.Controls.Add(this.Hamburger);
            this.Cola.Controls.Add(this.HotDog);
            this.Cola.Controls.Add(this.groupBox5);
            this.Cola.Location = new System.Drawing.Point(390, 26);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(300, 459);
            this.Cola.TabIndex = 1;
            this.Cola.TabStop = false;
            this.Cola.Text = "Кафе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Кількість";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ціна";
            // 
            // ColaQuantity
            // 
            this.ColaQuantity.Enabled = false;
            this.ColaQuantity.Location = new System.Drawing.Point(223, 175);
            this.ColaQuantity.Name = "ColaQuantity";
            this.ColaQuantity.Size = new System.Drawing.Size(62, 20);
            this.ColaQuantity.TabIndex = 16;
            // 
            // FriesQuantity
            // 
            this.FriesQuantity.Enabled = false;
            this.FriesQuantity.Location = new System.Drawing.Point(223, 138);
            this.FriesQuantity.Name = "FriesQuantity";
            this.FriesQuantity.Size = new System.Drawing.Size(62, 20);
            this.FriesQuantity.TabIndex = 15;
            // 
            // HamburgerQuantity
            // 
            this.HamburgerQuantity.Enabled = false;
            this.HamburgerQuantity.Location = new System.Drawing.Point(223, 103);
            this.HamburgerQuantity.Name = "HamburgerQuantity";
            this.HamburgerQuantity.Size = new System.Drawing.Size(62, 20);
            this.HamburgerQuantity.TabIndex = 14;
            // 
            // HotDogQuantity
            // 
            this.HotDogQuantity.Enabled = false;
            this.HotDogQuantity.Location = new System.Drawing.Point(223, 68);
            this.HotDogQuantity.Name = "HotDogQuantity";
            this.HotDogQuantity.Size = new System.Drawing.Size(62, 20);
            this.HotDogQuantity.TabIndex = 13;
            // 
            // ColaPrice
            // 
            this.ColaPrice.Enabled = false;
            this.ColaPrice.Location = new System.Drawing.Point(133, 175);
            this.ColaPrice.Name = "ColaPrice";
            this.ColaPrice.Size = new System.Drawing.Size(62, 20);
            this.ColaPrice.TabIndex = 12;
            this.ColaPrice.Text = "4,40";
            // 
            // FriesPrice
            // 
            this.FriesPrice.Enabled = false;
            this.FriesPrice.Location = new System.Drawing.Point(133, 138);
            this.FriesPrice.Name = "FriesPrice";
            this.FriesPrice.Size = new System.Drawing.Size(62, 20);
            this.FriesPrice.TabIndex = 11;
            this.FriesPrice.Text = "7,20";
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.Enabled = false;
            this.HamburgerPrice.Location = new System.Drawing.Point(133, 103);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.Size = new System.Drawing.Size(62, 20);
            this.HamburgerPrice.TabIndex = 10;
            this.HamburgerPrice.Text = "5,40";
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Enabled = false;
            this.HotDogPrice.Location = new System.Drawing.Point(133, 68);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.Size = new System.Drawing.Size(62, 20);
            this.HotDogPrice.TabIndex = 9;
            this.HotDogPrice.Text = "4";
            // 
            // CocaCola
            // 
            this.CocaCola.AutoSize = true;
            this.CocaCola.Location = new System.Drawing.Point(16, 178);
            this.CocaCola.Name = "CocaCola";
            this.CocaCola.Size = new System.Drawing.Size(78, 17);
            this.CocaCola.TabIndex = 8;
            this.CocaCola.Text = "Кока-кола";
            this.CocaCola.UseVisualStyleBackColor = true;
            this.CocaCola.CheckedChanged += new System.EventHandler(this.CocaCola_CheckedChanged);
            // 
            // Fries
            // 
            this.Fries.AutoSize = true;
            this.Fries.Location = new System.Drawing.Point(16, 140);
            this.Fries.Name = "Fries";
            this.Fries.Size = new System.Drawing.Size(93, 17);
            this.Fries.TabIndex = 7;
            this.Fries.Text = "Картопля-фрі";
            this.Fries.UseVisualStyleBackColor = true;
            this.Fries.CheckedChanged += new System.EventHandler(this.Fries_CheckedChanged);
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.Location = new System.Drawing.Point(16, 103);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(80, 17);
            this.Hamburger.TabIndex = 6;
            this.Hamburger.Text = "Гамбургер";
            this.Hamburger.UseVisualStyleBackColor = true;
            this.Hamburger.CheckedChanged += new System.EventHandler(this.Hamburger_CheckedChanged);
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Location = new System.Drawing.Point(16, 68);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(64, 17);
            this.HotDog.TabIndex = 5;
            this.HotDog.Text = "Хот-дог";
            this.HotDog.UseVisualStyleBackColor = true;
            this.HotDog.CheckedChanged += new System.EventHandler(this.HotDog_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CalculateCafePrice);
            this.groupBox5.Controls.Add(this.FinalCafePrice);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(16, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 131);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "До оплати";
            // 
            // CalculateCafePrice
            // 
            this.CalculateCafePrice.Location = new System.Drawing.Point(15, 28);
            this.CalculateCafePrice.Name = "CalculateCafePrice";
            this.CalculateCafePrice.Size = new System.Drawing.Size(117, 45);
            this.CalculateCafePrice.TabIndex = 32;
            this.CalculateCafePrice.Text = "Порахувати";
            this.CalculateCafePrice.UseVisualStyleBackColor = true;
            this.CalculateCafePrice.Click += new System.EventHandler(this.CalculateCafePrice_Click);
            // 
            // FinalCafePrice
            // 
            this.FinalCafePrice.Enabled = false;
            this.FinalCafePrice.Location = new System.Drawing.Point(100, 102);
            this.FinalCafePrice.Name = "FinalCafePrice";
            this.FinalCafePrice.Size = new System.Drawing.Size(108, 20);
            this.FinalCafePrice.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "грн.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FinalPrice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CalculatePrice);
            this.groupBox3.Location = new System.Drawing.Point(26, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ВСЬОГО до сплати";
            // 
            // FinalPrice
            // 
            this.FinalPrice.Enabled = false;
            this.FinalPrice.Location = new System.Drawing.Point(497, 91);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(108, 20);
            this.FinalPrice.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(622, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "грн.";
            // 
            // CalculatePrice
            // 
            this.CalculatePrice.Location = new System.Drawing.Point(89, 37);
            this.CalculatePrice.Name = "CalculatePrice";
            this.CalculatePrice.Size = new System.Drawing.Size(182, 65);
            this.CalculatePrice.TabIndex = 0;
            this.CalculatePrice.Text = "Прорахувати";
            this.CalculatePrice.UseVisualStyleBackColor = true;
            this.CalculatePrice.Click += new System.EventHandler(this.CalculatePrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 696);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Cola.ResumeLayout(false);
            this.Cola.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PetrolComboBox;
        private System.Windows.Forms.TextBox PetrolPrice;
        private System.Windows.Forms.TextBox MoneyTB;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Money;
        private System.Windows.Forms.RadioButton Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Cola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColaQuantity;
        private System.Windows.Forms.TextBox FriesQuantity;
        private System.Windows.Forms.TextBox HamburgerQuantity;
        private System.Windows.Forms.TextBox HotDogQuantity;
        private System.Windows.Forms.TextBox ColaPrice;
        private System.Windows.Forms.TextBox FriesPrice;
        private System.Windows.Forms.TextBox HamburgerPrice;
        private System.Windows.Forms.TextBox HotDogPrice;
        private System.Windows.Forms.CheckBox CocaCola;
        private System.Windows.Forms.CheckBox Fries;
        private System.Windows.Forms.CheckBox Hamburger;
        private System.Windows.Forms.CheckBox HotDog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CalculatePrice;
        private System.Windows.Forms.TextBox FinalPetrolPrice;
        private System.Windows.Forms.TextBox FinalCafePrice;
        private System.Windows.Forms.TextBox FinalPrice;
        private System.Windows.Forms.Button CalculatePetrolPrice;
        private System.Windows.Forms.Button CalculateCafePrice;
    }
}

