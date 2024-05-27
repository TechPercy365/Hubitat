namespace Hubitat.Forms
{
    partial class Frm_A_ManagePets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_A_ManagePets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x_Exit = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_Pets = new System.Windows.Forms.DataGridView();
            this.btn_Sold = new System.Windows.Forms.Button();
            this.btn_Available = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pic_addPetImg = new System.Windows.Forms.PictureBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_Breed = new System.Windows.Forms.TextBox();
            this.txt_Species = new System.Windows.Forms.TextBox();
            this.txt_petName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pic_DeletePet = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pic_EditPet = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_AddPet = new System.Windows.Forms.PictureBox();
            this.pic_Pet = new System.Windows.Forms.PictureBox();
            this.btn_sortAll = new System.Windows.Forms.Button();
            this.txt_petSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pets)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPetImg)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DeletePet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditPet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Location = new System.Drawing.Point(7, 110);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(69, 25);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.Text = "< BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(140, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Manage Pets";
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
            this.label_Home.TabIndex = 19;
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
            this.label5.Size = new System.Drawing.Size(225, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manage Pets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dg_Pets);
            this.panel2.Controls.Add(this.btn_Sold);
            this.panel2.Controls.Add(this.btn_Available);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pic_Pet);
            this.panel2.Controls.Add(this.btn_sortAll);
            this.panel2.Controls.Add(this.txt_petSearch);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 267);
            this.panel2.TabIndex = 21;
            // 
            // dg_Pets
            // 
            this.dg_Pets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.dg_Pets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Pets.Location = new System.Drawing.Point(4, 60);
            this.dg_Pets.Name = "dg_Pets";
            this.dg_Pets.Size = new System.Drawing.Size(534, 133);
            this.dg_Pets.TabIndex = 17;
            this.dg_Pets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Pets_CellContentClick);
            // 
            // btn_Sold
            // 
            this.btn_Sold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_Sold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sold.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sold.Location = new System.Drawing.Point(364, 9);
            this.btn_Sold.Name = "btn_Sold";
            this.btn_Sold.Size = new System.Drawing.Size(87, 26);
            this.btn_Sold.TabIndex = 16;
            this.btn_Sold.Text = "Sold";
            this.btn_Sold.UseVisualStyleBackColor = false;
            this.btn_Sold.Click += new System.EventHandler(this.btn_Sold_Click_1);
            // 
            // btn_Available
            // 
            this.btn_Available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_Available.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Available.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Available.Location = new System.Drawing.Point(262, 9);
            this.btn_Available.Name = "btn_Available";
            this.btn_Available.Size = new System.Drawing.Size(87, 26);
            this.btn_Available.TabIndex = 16;
            this.btn_Available.Text = "Available";
            this.btn_Available.UseVisualStyleBackColor = false;
            this.btn_Available.Click += new System.EventHandler(this.btn_Available_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.panel6.Controls.Add(this.pic_addPetImg);
            this.panel6.Controls.Add(this.cmb_Gender);
            this.panel6.Controls.Add(this.cmb_Status);
            this.panel6.Controls.Add(this.txt_Price);
            this.panel6.Controls.Add(this.txt_Age);
            this.panel6.Controls.Add(this.txt_Breed);
            this.panel6.Controls.Add(this.txt_Species);
            this.panel6.Controls.Add(this.txt_petName);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(4, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(720, 66);
            this.panel6.TabIndex = 15;
            // 
            // pic_addPetImg
            // 
            this.pic_addPetImg.BackColor = System.Drawing.Color.White;
            this.pic_addPetImg.Image = ((System.Drawing.Image)(resources.GetObject("pic_addPetImg.Image")));
            this.pic_addPetImg.Location = new System.Drawing.Point(624, 23);
            this.pic_addPetImg.Name = "pic_addPetImg";
            this.pic_addPetImg.Size = new System.Drawing.Size(45, 35);
            this.pic_addPetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_addPetImg.TabIndex = 7;
            this.pic_addPetImg.TabStop = false;
            this.pic_addPetImg.Click += new System.EventHandler(this.pic_addPetImg_Click);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmb_Gender.Location = new System.Drawing.Point(347, 24);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(62, 23);
            this.cmb_Gender.TabIndex = 6;
            // 
            // cmb_Status
            // 
            this.cmb_Status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "AVAILABLE",
            "SOLD"});
            this.cmb_Status.Location = new System.Drawing.Point(490, 24);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(92, 23);
            this.cmb_Status.TabIndex = 6;
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(418, 24);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(67, 23);
            this.txt_Price.TabIndex = 5;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // txt_Age
            // 
            this.txt_Age.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Age.Location = new System.Drawing.Point(295, 24);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(43, 23);
            this.txt_Age.TabIndex = 5;
            this.txt_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Age_KeyPress);
            // 
            // txt_Breed
            // 
            this.txt_Breed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Breed.Location = new System.Drawing.Point(204, 24);
            this.txt_Breed.Name = "txt_Breed";
            this.txt_Breed.Size = new System.Drawing.Size(87, 23);
            this.txt_Breed.TabIndex = 5;
            // 
            // txt_Species
            // 
            this.txt_Species.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Species.Location = new System.Drawing.Point(111, 24);
            this.txt_Species.Name = "txt_Species";
            this.txt_Species.Size = new System.Drawing.Size(87, 23);
            this.txt_Species.TabIndex = 5;
            // 
            // txt_petName
            // 
            this.txt_petName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_petName.Location = new System.Drawing.Point(6, 24);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(99, 23);
            this.txt_petName.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(489, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(415, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Breed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Species:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pet Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Image:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel5.Controls.Add(this.pic_DeletePet);
            this.panel5.Location = new System.Drawing.Point(656, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 36);
            this.panel5.TabIndex = 14;
            // 
            // pic_DeletePet
            // 
            this.pic_DeletePet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.pic_DeletePet.Image = ((System.Drawing.Image)(resources.GetObject("pic_DeletePet.Image")));
            this.pic_DeletePet.Location = new System.Drawing.Point(17, 3);
            this.pic_DeletePet.Name = "pic_DeletePet";
            this.pic_DeletePet.Size = new System.Drawing.Size(30, 30);
            this.pic_DeletePet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DeletePet.TabIndex = 13;
            this.pic_DeletePet.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel4.Controls.Add(this.pic_EditPet);
            this.panel4.Location = new System.Drawing.Point(565, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(65, 36);
            this.panel4.TabIndex = 14;
            // 
            // pic_EditPet
            // 
            this.pic_EditPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.pic_EditPet.Image = ((System.Drawing.Image)(resources.GetObject("pic_EditPet.Image")));
            this.pic_EditPet.Location = new System.Drawing.Point(18, 3);
            this.pic_EditPet.Name = "pic_EditPet";
            this.pic_EditPet.Size = new System.Drawing.Size(30, 30);
            this.pic_EditPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EditPet.TabIndex = 13;
            this.pic_EditPet.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.pic_AddPet);
            this.panel3.Location = new System.Drawing.Point(477, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 36);
            this.panel3.TabIndex = 14;
            // 
            // pic_AddPet
            // 
            this.pic_AddPet.Image = ((System.Drawing.Image)(resources.GetObject("pic_AddPet.Image")));
            this.pic_AddPet.Location = new System.Drawing.Point(17, 3);
            this.pic_AddPet.Name = "pic_AddPet";
            this.pic_AddPet.Size = new System.Drawing.Size(30, 30);
            this.pic_AddPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AddPet.TabIndex = 0;
            this.pic_AddPet.TabStop = false;
            this.pic_AddPet.Click += new System.EventHandler(this.pic_AddPet_Click);
            // 
            // pic_Pet
            // 
            this.pic_Pet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.pic_Pet.Location = new System.Drawing.Point(544, 60);
            this.pic_Pet.Name = "pic_Pet";
            this.pic_Pet.Size = new System.Drawing.Size(180, 133);
            this.pic_Pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pet.TabIndex = 12;
            this.pic_Pet.TabStop = false;
            // 
            // btn_sortAll
            // 
            this.btn_sortAll.BackColor = System.Drawing.Color.Black;
            this.btn_sortAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sortAll.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sortAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.btn_sortAll.Location = new System.Drawing.Point(189, 9);
            this.btn_sortAll.Name = "btn_sortAll";
            this.btn_sortAll.Size = new System.Drawing.Size(57, 26);
            this.btn_sortAll.TabIndex = 10;
            this.btn_sortAll.Text = "All";
            this.btn_sortAll.UseVisualStyleBackColor = false;
            this.btn_sortAll.Click += new System.EventHandler(this.btn_sortAll_Click);
            // 
            // txt_petSearch
            // 
            this.txt_petSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_petSearch.Location = new System.Drawing.Point(36, 7);
            this.txt_petSearch.Name = "txt_petSearch";
            this.txt_petSearch.Size = new System.Drawing.Size(136, 26);
            this.txt_petSearch.TabIndex = 8;
            this.txt_petSearch.Text = "Search...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Frm_A_ManagePets
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
            this.Name = "Frm_A_ManagePets";
            this.Text = "Hubitat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pets)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPetImg)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_DeletePet)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditPet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label x_Exit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sortAll;
        private System.Windows.Forms.TextBox txt_petSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pic_Pet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pic_DeletePet;
        private System.Windows.Forms.PictureBox pic_EditPet;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_petName;
        private System.Windows.Forms.TextBox txt_Breed;
        private System.Windows.Forms.TextBox txt_Species;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Sold;
        private System.Windows.Forms.Button btn_Available;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.PictureBox pic_addPetImg;
        private System.Windows.Forms.PictureBox pic_AddPet;
        private System.Windows.Forms.DataGridView dg_Pets;
    }
}