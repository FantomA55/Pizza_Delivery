namespace Pizza_delivery
{
    partial class Order
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddOrd = new System.Windows.Forms.TextBox();
            this.txtMobOrd = new System.Windows.Forms.TextBox();
            this.txtFNameOrd = new System.Windows.Forms.TextBox();
            this.txtNameOrd = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPizzaN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(343, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddOrd
            // 
            this.txtAddOrd.Location = new System.Drawing.Point(251, 213);
            this.txtAddOrd.Name = "txtAddOrd";
            this.txtAddOrd.Size = new System.Drawing.Size(349, 30);
            this.txtAddOrd.TabIndex = 22;
            // 
            // txtMobOrd
            // 
            this.txtMobOrd.Location = new System.Drawing.Point(251, 167);
            this.txtMobOrd.Name = "txtMobOrd";
            this.txtMobOrd.Size = new System.Drawing.Size(349, 30);
            this.txtMobOrd.TabIndex = 20;
            // 
            // txtFNameOrd
            // 
            this.txtFNameOrd.Location = new System.Drawing.Point(251, 116);
            this.txtFNameOrd.Name = "txtFNameOrd";
            this.txtFNameOrd.Size = new System.Drawing.Size(349, 30);
            this.txtFNameOrd.TabIndex = 19;
            // 
            // txtNameOrd
            // 
            this.txtNameOrd.Location = new System.Drawing.Point(251, 62);
            this.txtNameOrd.Name = "txtNameOrd";
            this.txtNameOrd.Size = new System.Drawing.Size(349, 30);
            this.txtNameOrd.TabIndex = 18;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(157, 221);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 22);
            this.label37.TabIndex = 17;
            this.label37.Text = "Адрес:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(54, 175);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(179, 22);
            this.label35.TabIndex = 15;
            this.label35.Text = "Номер телефона:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(137, 124);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 22);
            this.label34.TabIndex = 14;
            this.label34.Text = "Фамилия:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(183, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 22);
            this.label33.TabIndex = 13;
            this.label33.Text = "Имя:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(244, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(302, 39);
            this.label32.TabIndex = 12;
            this.label32.Text = "Введите данные:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(251, 307);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(349, 30);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Название пиццы:";
            // 
            // txtPizzaN
            // 
            this.txtPizzaN.Location = new System.Drawing.Point(251, 261);
            this.txtPizzaN.Name = "txtPizzaN";
            this.txtPizzaN.ReadOnly = true;
            this.txtPizzaN.Size = new System.Drawing.Size(349, 30);
            this.txtPizzaN.TabIndex = 26;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPizzaN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddOrd);
            this.Controls.Add(this.txtMobOrd);
            this.Controls.Add(this.txtFNameOrd);
            this.Controls.Add(this.txtNameOrd);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddOrd;
        private System.Windows.Forms.TextBox txtMobOrd;
        private System.Windows.Forms.TextBox txtFNameOrd;
        private System.Windows.Forms.TextBox txtNameOrd;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPizzaN;
    }
}