namespace Hubitat.Forms
{
    partial class Frm_C_BuyPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_BuyPets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x_Exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Done = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.dgv_butPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_CusName = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_PetName = new System.Windows.Forms.Label();
            this.lbl_Species = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_butPet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.x_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 34);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(34, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "HUB-ITAT";
            // 
            // x_Exit
            // 
            this.x_Exit.AutoSize = true;
            this.x_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x_Exit.Location = new System.Drawing.Point(728, 6);
            this.x_Exit.Name = "x_Exit";
            this.x_Exit.Size = new System.Drawing.Size(21, 22);
            this.x_Exit.TabIndex = 0;
            this.x_Exit.Text = "X";
            this.x_Exit.Click += new System.EventHandler(this.x_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(140, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buy Pet";
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.BackColor = System.Drawing.Color.Transparent;
            this.label_Home.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Home.Location = new System.Drawing.Point(83, 88);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(60, 16);
            this.label_Home.TabIndex = 14;
            this.label_Home.Text = "Home /";
            this.label_Home.Click += new System.EventHandler(this.label_Home_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(82, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buy Pet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Location = new System.Drawing.Point(7, 110);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(69, 25);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "< BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_butPet);
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 267);
            this.panel2.TabIndex = 16;
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Done.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.ForeColor = System.Drawing.Color.Black;
            this.btn_Done.Location = new System.Drawing.Point(248, 209);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(93, 29);
            this.btn_Done.TabIndex = 15;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = false;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(113, 154);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(64, 20);
            this.txt_Amount.TabIndex = 5;
            // 
            // dgv_butPet
            // 
            this.dgv_butPet.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_butPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_butPet.Location = new System.Drawing.Point(379, 32);
            this.dgv_butPet.Name = "dgv_butPet";
            this.dgv_butPet.Size = new System.Drawing.Size(342, 169);
            this.dgv_butPet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a Pet you want to buy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Transaction Info:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lbl_Amount);
            this.panel3.Controls.Add(this.btn_Done);
            this.panel3.Controls.Add(this.lbl_Price);
            this.panel3.Controls.Add(this.txt_Amount);
            this.panel3.Controls.Add(this.lbl_Species);
            this.panel3.Controls.Add(this.lbl_PetName);
            this.panel3.Controls.Add(this.lbl_Email);
            this.panel3.Controls.Add(this.lbl_CusName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 241);
            this.panel3.TabIndex = 17;
            // 
            // lbl_CusName
            // 
            this.lbl_CusName.AutoSize = true;
            this.lbl_CusName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CusName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_CusName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusName.Location = new System.Drawing.Point(3, 34);
            this.lbl_CusName.Name = "lbl_CusName";
            this.lbl_CusName.Size = new System.Drawing.Size(50, 16);
            this.lbl_CusName.TabIndex = 17;
            this.lbl_CusName.Text = "Name: ";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(3, 59);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(46, 16);
            this.lbl_Email.TabIndex = 18;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_PetName
            // 
            this.lbl_PetName.AutoSize = true;
            this.lbl_PetName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PetName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_PetName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PetName.Location = new System.Drawing.Point(3, 84);
            this.lbl_PetName.Name = "lbl_PetName";
            this.lbl_PetName.Size = new System.Drawing.Size(70, 16);
            this.lbl_PetName.TabIndex = 19;
            this.lbl_PetName.Text = "Pet Name:";
            // 
            // lbl_Species
            // 
            this.lbl_Species.AutoSize = true;
            this.lbl_Species.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Species.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Species.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Species.Location = new System.Drawing.Point(3, 109);
            this.lbl_Species.Name = "lbl_Species";
            this.lbl_Species.Size = new System.Drawing.Size(57, 16);
            this.lbl_Species.TabIndex = 20;
            this.lbl_Species.Text = "Species:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(3, 134);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(43, 16);
            this.lbl_Price.TabIndex = 21;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Amount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Amount.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(3, 158);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(104, 16);
            this.lbl_Amount.TabIndex = 22;
            this.lbl_Amount.Text = "Amount to Pay:";
            // 
            // Frm_C_BuyPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_C_BuyPets";
            this.Text = "Frm_T_RentApartment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_butPet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label x_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_butPet;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Species;
        private System.Windows.Forms.Label lbl_PetName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_CusName;
        private System.Windows.Forms.Label lbl_Amount;
    }
}