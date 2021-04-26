namespace homeWork1
{
    partial class form_menedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menedger));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_menedger = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_login1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_filtName = new System.Windows.Forms.Button();
            this.button_filtZakaz = new System.Windows.Forms.Button();
            this.button_NewZakaz = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_idIncription = new System.Windows.Forms.Label();
            this.label_NameIncription = new System.Windows.Forms.Label();
            this.label_colvoIncription = new System.Windows.Forms.Label();
            this.label_priceIncription = new System.Windows.Forms.Label();
            this.label_if = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_colvo = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_menedger
            // 
            this.label_menedger.AutoSize = true;
            this.label_menedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_menedger.Location = new System.Drawing.Point(65, 116);
            this.label_menedger.Name = "label_menedger";
            this.label_menedger.Size = new System.Drawing.Size(75, 13);
            this.label_menedger.TabIndex = 1;
            this.label_menedger.Text = "«Менеджер».";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_login.Location = new System.Drawing.Point(152, 23);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(32, 13);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "login:";
            // 
            // label_login1
            // 
            this.label_login1.AutoSize = true;
            this.label_login1.Location = new System.Drawing.Point(188, 23);
            this.label_login1.Name = "label_login1";
            this.label_login1.Size = new System.Drawing.Size(35, 13);
            this.label_login1.TabIndex = 3;
            this.label_login1.Text = "login1";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Red;
            this.button_back.Location = new System.Drawing.Point(33, 301);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(93, 43);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "вернуться назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_filtName
            // 
            this.button_filtName.Location = new System.Drawing.Point(335, 301);
            this.button_filtName.Name = "button_filtName";
            this.button_filtName.Size = new System.Drawing.Size(100, 43);
            this.button_filtName.TabIndex = 5;
            this.button_filtName.Text = "фильтрация по названию";
            this.button_filtName.UseVisualStyleBackColor = true;
            // 
            // button_filtZakaz
            // 
            this.button_filtZakaz.Location = new System.Drawing.Point(237, 301);
            this.button_filtZakaz.Name = "button_filtZakaz";
            this.button_filtZakaz.Size = new System.Drawing.Size(93, 43);
            this.button_filtZakaz.TabIndex = 6;
            this.button_filtZakaz.Text = "фильтрация по номеру заказа";
            this.button_filtZakaz.UseVisualStyleBackColor = true;
            // 
            // button_NewZakaz
            // 
            this.button_NewZakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.button_NewZakaz.Location = new System.Drawing.Point(131, 301);
            this.button_NewZakaz.Name = "button_NewZakaz";
            this.button_NewZakaz.Size = new System.Drawing.Size(100, 43);
            this.button_NewZakaz.TabIndex = 9;
            this.button_NewZakaz.Text = "создать новый заказ";
            this.button_NewZakaz.UseVisualStyleBackColor = false;
            this.button_NewZakaz.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Controls.Add(this.label_colvo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_if);
            this.panel1.Controls.Add(this.label_priceIncription);
            this.panel1.Controls.Add(this.label_colvoIncription);
            this.panel1.Controls.Add(this.label_NameIncription);
            this.panel1.Controls.Add(this.label_idIncription);
            this.panel1.Location = new System.Drawing.Point(166, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 144);
            this.panel1.TabIndex = 11;
            // 
            // label_idIncription
            // 
            this.label_idIncription.AutoSize = true;
            this.label_idIncription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_idIncription.Location = new System.Drawing.Point(4, 20);
            this.label_idIncription.Name = "label_idIncription";
            this.label_idIncription.Size = new System.Drawing.Size(78, 13);
            this.label_idIncription.TabIndex = 0;
            this.label_idIncription.Text = "номер заказа";
            // 
            // label_NameIncription
            // 
            this.label_NameIncription.AutoSize = true;
            this.label_NameIncription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_NameIncription.Location = new System.Drawing.Point(4, 48);
            this.label_NameIncription.Name = "label_NameIncription";
            this.label_NameIncription.Size = new System.Drawing.Size(81, 13);
            this.label_NameIncription.TabIndex = 1;
            this.label_NameIncription.Text = "наименование";
            // 
            // label_colvoIncription
            // 
            this.label_colvoIncription.AutoSize = true;
            this.label_colvoIncription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_colvoIncription.Location = new System.Drawing.Point(4, 82);
            this.label_colvoIncription.Name = "label_colvoIncription";
            this.label_colvoIncription.Size = new System.Drawing.Size(65, 13);
            this.label_colvoIncription.TabIndex = 2;
            this.label_colvoIncription.Text = "количество";
            // 
            // label_priceIncription
            // 
            this.label_priceIncription.AutoSize = true;
            this.label_priceIncription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_priceIncription.Location = new System.Drawing.Point(4, 112);
            this.label_priceIncription.Name = "label_priceIncription";
            this.label_priceIncription.Size = new System.Drawing.Size(31, 13);
            this.label_priceIncription.TabIndex = 3;
            this.label_priceIncription.Text = "цена";
            // 
            // label_if
            // 
            this.label_if.AutoSize = true;
            this.label_if.Location = new System.Drawing.Point(106, 20);
            this.label_if.Name = "label_if";
            this.label_if.Size = new System.Drawing.Size(35, 13);
            this.label_if.TabIndex = 4;
            this.label_if.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label_colvo
            // 
            this.label_colvo.AutoSize = true;
            this.label_colvo.Location = new System.Drawing.Point(106, 82);
            this.label_colvo.Name = "label_colvo";
            this.label_colvo.Size = new System.Drawing.Size(35, 13);
            this.label_colvo.TabIndex = 6;
            this.label_colvo.Text = "label7";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(106, 112);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(35, 13);
            this.label_price.TabIndex = 7;
            this.label_price.Text = "label8";
            // 
            // form_menedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_NewZakaz);
            this.Controls.Add(this.button_filtZakaz);
            this.Controls.Add(this.button_filtName);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_login1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_menedger);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_menedger";
            this.Text = "menedger";
            this.Load += new System.EventHandler(this.form_menedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_menedger;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_login1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_filtName;
        private System.Windows.Forms.Button button_filtZakaz;
        private System.Windows.Forms.Button button_NewZakaz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_colvo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_if;
        private System.Windows.Forms.Label label_priceIncription;
        private System.Windows.Forms.Label label_colvoIncription;
        private System.Windows.Forms.Label label_NameIncription;
        private System.Windows.Forms.Label label_idIncription;
    }
}