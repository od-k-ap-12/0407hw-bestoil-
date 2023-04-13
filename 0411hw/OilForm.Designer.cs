namespace _0411hw
{
    partial class OilForm
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
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 459);
            this.groupBox1.TabIndex = 2;
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
            // OilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "OilForm";
            this.Text = "Petrol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PetrolPrice;
        private System.Windows.Forms.TextBox MoneyTB;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Money;
        private System.Windows.Forms.RadioButton Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CalculatePetrolPrice;
        private System.Windows.Forms.TextBox FinalPetrolPrice;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox PetrolComboBox;
    }
}