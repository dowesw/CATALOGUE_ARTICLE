namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Article
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Article));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pua_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puv_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.com_famille = new System.Windows.Forms.ComboBox();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_puv = new System.Windows.Forms.NumericUpDown();
            this.txt_pua = new System.Windows.Forms.NumericUpDown();
            this.dat_save = new System.Windows.Forms.DateTimePicker();
            this.dat_update = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_photo = new System.Windows.Forms.TabPage();
            this.lk_box_add_8 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_7 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_4 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_6 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_3 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_5 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_2 = new System.Windows.Forms.LinkLabel();
            this.lk_box_add_1 = new System.Windows.Forms.LinkLabel();
            this.box_add_8 = new System.Windows.Forms.PictureBox();
            this.box_add_4 = new System.Windows.Forms.PictureBox();
            this.box_add_7 = new System.Windows.Forms.PictureBox();
            this.box_add_6 = new System.Windows.Forms.PictureBox();
            this.box_add_3 = new System.Windows.Forms.PictureBox();
            this.box_add_2 = new System.Windows.Forms.PictureBox();
            this.box_add_5 = new System.Windows.Forms.PictureBox();
            this.box_add_1 = new System.Windows.Forms.PictureBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pua)).BeginInit();
            this.tab_photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(651, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(16, 95);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "  Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::CATALOGUE_ARTICLE.Properties.Resources.cancel;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(16, 56);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "   Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(14, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_liste);
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste";
            // 
            // dgv_liste
            // 
            this.dgv_liste.AllowUserToAddRows = false;
            this.dgv_liste.AllowUserToDeleteRows = false;
            this.dgv_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.reference_,
            this.designation_,
            this.marque_,
            this.pua_,
            this.puv_,
            this.famille_,
            this.supp});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(739, 244);
            this.dgv_liste.TabIndex = 0;
            this.dgv_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellContentClick);
            this.dgv_liste.SelectionChanged += new System.EventHandler(this.dgv_list_SelectionChanged);
            // 
            // id_
            // 
            this.id_.HeaderText = "ID";
            this.id_.Name = "id_";
            this.id_.ReadOnly = true;
            this.id_.Visible = false;
            // 
            // reference_
            // 
            this.reference_.FillWeight = 110.7445F;
            this.reference_.HeaderText = "Réference";
            this.reference_.Name = "reference_";
            this.reference_.ReadOnly = true;
            // 
            // designation_
            // 
            this.designation_.FillWeight = 110.7445F;
            this.designation_.HeaderText = "Désignation";
            this.designation_.Name = "designation_";
            this.designation_.ReadOnly = true;
            // 
            // marque_
            // 
            this.marque_.FillWeight = 110.7445F;
            this.marque_.HeaderText = "Marque";
            this.marque_.Name = "marque_";
            this.marque_.ReadOnly = true;
            // 
            // pua_
            // 
            this.pua_.FillWeight = 110.7445F;
            this.pua_.HeaderText = "Prix.A";
            this.pua_.Name = "pua_";
            this.pua_.ReadOnly = true;
            // 
            // puv_
            // 
            this.puv_.FillWeight = 110.7445F;
            this.puv_.HeaderText = "Prix.V";
            this.puv_.Name = "puv_";
            this.puv_.ReadOnly = true;
            // 
            // famille_
            // 
            this.famille_.FillWeight = 110.7445F;
            this.famille_.HeaderText = "Famille";
            this.famille_.Name = "famille_";
            this.famille_.ReadOnly = true;
            // 
            // supp
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            this.supp.DefaultCellStyle = dataGridViewCellStyle1;
            this.supp.FillWeight = 35.53299F;
            this.supp.HeaderText = "";
            this.supp.Name = "supp";
            this.supp.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Location = new System.Drawing.Point(12, 626);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 46);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(35, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(598, 20);
            this.txt_search.TabIndex = 33;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab_photo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 339);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_stock);
            this.tabPage1.Controls.Add(this.com_famille);
            this.tabPage1.Controls.Add(this.txt_marque);
            this.tabPage1.Controls.Add(this.txt_designation);
            this.tabPage1.Controls.Add(this.txt_reference);
            this.tabPage1.Controls.Add(this.txt_puv);
            this.tabPage1.Controls.Add(this.txt_pua);
            this.tabPage1.Controls.Add(this.dat_save);
            this.tabPage1.Controls.Add(this.dat_update);
            this.tabPage1.Controls.Add(this.txt_description);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // com_famille
            // 
            this.com_famille.FormattingEnabled = true;
            this.com_famille.Location = new System.Drawing.Point(100, 75);
            this.com_famille.Name = "com_famille";
            this.com_famille.Size = new System.Drawing.Size(184, 21);
            this.com_famille.TabIndex = 35;
            this.com_famille.SelectedIndexChanged += new System.EventHandler(this.com_famille_SelectedIndexChanged);
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(100, 106);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(184, 20);
            this.txt_marque.TabIndex = 36;
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(100, 44);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(311, 20);
            this.txt_designation.TabIndex = 33;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(100, 13);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(184, 20);
            this.txt_reference.TabIndex = 32;
            // 
            // txt_puv
            // 
            this.txt_puv.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txt_puv.Location = new System.Drawing.Point(427, 107);
            this.txt_puv.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txt_puv.Name = "txt_puv";
            this.txt_puv.Size = new System.Drawing.Size(120, 20);
            this.txt_puv.TabIndex = 38;
            this.txt_puv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_pua
            // 
            this.txt_pua.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txt_pua.Location = new System.Drawing.Point(427, 76);
            this.txt_pua.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txt_pua.Name = "txt_pua";
            this.txt_pua.Size = new System.Drawing.Size(120, 20);
            this.txt_pua.TabIndex = 37;
            this.txt_pua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dat_save
            // 
            this.dat_save.Enabled = false;
            this.dat_save.Location = new System.Drawing.Point(100, 139);
            this.dat_save.Name = "dat_save";
            this.dat_save.Size = new System.Drawing.Size(184, 20);
            this.dat_save.TabIndex = 29;
            // 
            // dat_update
            // 
            this.dat_update.Enabled = false;
            this.dat_update.Location = new System.Drawing.Point(427, 139);
            this.dat_update.Name = "dat_update";
            this.dat_update.Size = new System.Drawing.Size(178, 20);
            this.dat_update.TabIndex = 28;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(19, 187);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(600, 118);
            this.txt_description.TabIndex = 40;
            this.txt_description.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date Modification : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Date Création : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Prix.V : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Famille : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Marque : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Déscription : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Désignation : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Réference : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prix.A : ";
            // 
            // tab_photo
            // 
            this.tab_photo.Controls.Add(this.lk_box_add_8);
            this.tab_photo.Controls.Add(this.lk_box_add_7);
            this.tab_photo.Controls.Add(this.lk_box_add_4);
            this.tab_photo.Controls.Add(this.lk_box_add_6);
            this.tab_photo.Controls.Add(this.lk_box_add_3);
            this.tab_photo.Controls.Add(this.lk_box_add_5);
            this.tab_photo.Controls.Add(this.lk_box_add_2);
            this.tab_photo.Controls.Add(this.lk_box_add_1);
            this.tab_photo.Controls.Add(this.box_add_8);
            this.tab_photo.Controls.Add(this.box_add_4);
            this.tab_photo.Controls.Add(this.box_add_7);
            this.tab_photo.Controls.Add(this.box_add_6);
            this.tab_photo.Controls.Add(this.box_add_3);
            this.tab_photo.Controls.Add(this.box_add_2);
            this.tab_photo.Controls.Add(this.box_add_5);
            this.tab_photo.Controls.Add(this.box_add_1);
            this.tab_photo.Location = new System.Drawing.Point(4, 22);
            this.tab_photo.Name = "tab_photo";
            this.tab_photo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_photo.Size = new System.Drawing.Size(625, 313);
            this.tab_photo.TabIndex = 1;
            this.tab_photo.Text = "Photos";
            this.tab_photo.UseVisualStyleBackColor = true;
            // 
            // lk_box_add_8
            // 
            this.lk_box_add_8.AutoSize = true;
            this.lk_box_add_8.Location = new System.Drawing.Point(558, 294);
            this.lk_box_add_8.Name = "lk_box_add_8";
            this.lk_box_add_8.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_8.TabIndex = 1;
            this.lk_box_add_8.TabStop = true;
            this.lk_box_add_8.Text = "Supprimer";
            this.lk_box_add_8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_8_LinkClicked);
            // 
            // lk_box_add_7
            // 
            this.lk_box_add_7.AutoSize = true;
            this.lk_box_add_7.Location = new System.Drawing.Point(403, 294);
            this.lk_box_add_7.Name = "lk_box_add_7";
            this.lk_box_add_7.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_7.TabIndex = 1;
            this.lk_box_add_7.TabStop = true;
            this.lk_box_add_7.Text = "Supprimer";
            this.lk_box_add_7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_7_LinkClicked);
            // 
            // lk_box_add_4
            // 
            this.lk_box_add_4.AutoSize = true;
            this.lk_box_add_4.Location = new System.Drawing.Point(558, 120);
            this.lk_box_add_4.Name = "lk_box_add_4";
            this.lk_box_add_4.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_4.TabIndex = 1;
            this.lk_box_add_4.TabStop = true;
            this.lk_box_add_4.Text = "Supprimer";
            this.lk_box_add_4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_4_LinkClicked);
            // 
            // lk_box_add_6
            // 
            this.lk_box_add_6.AutoSize = true;
            this.lk_box_add_6.Location = new System.Drawing.Point(247, 294);
            this.lk_box_add_6.Name = "lk_box_add_6";
            this.lk_box_add_6.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_6.TabIndex = 1;
            this.lk_box_add_6.TabStop = true;
            this.lk_box_add_6.Text = "Supprimer";
            this.lk_box_add_6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_6_LinkClicked);
            // 
            // lk_box_add_3
            // 
            this.lk_box_add_3.AutoSize = true;
            this.lk_box_add_3.Location = new System.Drawing.Point(403, 120);
            this.lk_box_add_3.Name = "lk_box_add_3";
            this.lk_box_add_3.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_3.TabIndex = 1;
            this.lk_box_add_3.TabStop = true;
            this.lk_box_add_3.Text = "Supprimer";
            this.lk_box_add_3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_3_LinkClicked);
            // 
            // lk_box_add_5
            // 
            this.lk_box_add_5.AutoSize = true;
            this.lk_box_add_5.Location = new System.Drawing.Point(86, 294);
            this.lk_box_add_5.Name = "lk_box_add_5";
            this.lk_box_add_5.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_5.TabIndex = 1;
            this.lk_box_add_5.TabStop = true;
            this.lk_box_add_5.Text = "Supprimer";
            this.lk_box_add_5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_5_LinkClicked);
            // 
            // lk_box_add_2
            // 
            this.lk_box_add_2.AutoSize = true;
            this.lk_box_add_2.Location = new System.Drawing.Point(247, 120);
            this.lk_box_add_2.Name = "lk_box_add_2";
            this.lk_box_add_2.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_2.TabIndex = 1;
            this.lk_box_add_2.TabStop = true;
            this.lk_box_add_2.Text = "Supprimer";
            this.lk_box_add_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_2_LinkClicked);
            // 
            // lk_box_add_1
            // 
            this.lk_box_add_1.AutoSize = true;
            this.lk_box_add_1.Location = new System.Drawing.Point(86, 120);
            this.lk_box_add_1.Name = "lk_box_add_1";
            this.lk_box_add_1.Size = new System.Drawing.Size(54, 13);
            this.lk_box_add_1.TabIndex = 1;
            this.lk_box_add_1.TabStop = true;
            this.lk_box_add_1.Text = "Supprimer";
            this.lk_box_add_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_add_1_LinkClicked);
            // 
            // box_add_8
            // 
            this.box_add_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_8.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_8.Location = new System.Drawing.Point(474, 178);
            this.box_add_8.Name = "box_add_8";
            this.box_add_8.Size = new System.Drawing.Size(138, 129);
            this.box_add_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_8.TabIndex = 0;
            this.box_add_8.TabStop = false;
            this.box_add_8.Tag = "false";
            this.box_add_8.DoubleClick += new System.EventHandler(this.box_add_8_DoubleClick);
            // 
            // box_add_4
            // 
            this.box_add_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_4.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_4.Location = new System.Drawing.Point(475, 6);
            this.box_add_4.Name = "box_add_4";
            this.box_add_4.Size = new System.Drawing.Size(138, 129);
            this.box_add_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_4.TabIndex = 0;
            this.box_add_4.TabStop = false;
            this.box_add_4.Tag = "false";
            this.box_add_4.DoubleClick += new System.EventHandler(this.box_add_4_DoubleClick);
            // 
            // box_add_7
            // 
            this.box_add_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_7.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_7.Location = new System.Drawing.Point(318, 178);
            this.box_add_7.Name = "box_add_7";
            this.box_add_7.Size = new System.Drawing.Size(138, 129);
            this.box_add_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_7.TabIndex = 0;
            this.box_add_7.TabStop = false;
            this.box_add_7.Tag = "false";
            this.box_add_7.DoubleClick += new System.EventHandler(this.box_add_7_DoubleClick);
            // 
            // box_add_6
            // 
            this.box_add_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_6.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_6.Location = new System.Drawing.Point(163, 178);
            this.box_add_6.Name = "box_add_6";
            this.box_add_6.Size = new System.Drawing.Size(138, 129);
            this.box_add_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_6.TabIndex = 0;
            this.box_add_6.TabStop = false;
            this.box_add_6.Tag = "false";
            this.box_add_6.DoubleClick += new System.EventHandler(this.box_add_6_DoubleClick);
            // 
            // box_add_3
            // 
            this.box_add_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_3.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_3.Location = new System.Drawing.Point(319, 7);
            this.box_add_3.Name = "box_add_3";
            this.box_add_3.Size = new System.Drawing.Size(138, 129);
            this.box_add_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_3.TabIndex = 0;
            this.box_add_3.TabStop = false;
            this.box_add_3.Tag = "false";
            this.box_add_3.DoubleClick += new System.EventHandler(this.box_add_3_DoubleClick);
            // 
            // box_add_2
            // 
            this.box_add_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_2.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_2.Location = new System.Drawing.Point(164, 6);
            this.box_add_2.Name = "box_add_2";
            this.box_add_2.Size = new System.Drawing.Size(138, 129);
            this.box_add_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_2.TabIndex = 0;
            this.box_add_2.TabStop = false;
            this.box_add_2.Tag = "false";
            this.box_add_2.DoubleClick += new System.EventHandler(this.box_add_2_DoubleClick);
            // 
            // box_add_5
            // 
            this.box_add_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_5.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_5.Location = new System.Drawing.Point(6, 179);
            this.box_add_5.Name = "box_add_5";
            this.box_add_5.Size = new System.Drawing.Size(138, 129);
            this.box_add_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_5.TabIndex = 0;
            this.box_add_5.TabStop = false;
            this.box_add_5.Tag = "false";
            this.box_add_5.DoubleClick += new System.EventHandler(this.box_add_5_DoubleClick);
            // 
            // box_add_1
            // 
            this.box_add_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_add_1.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_add_1.Location = new System.Drawing.Point(6, 7);
            this.box_add_1.Name = "box_add_1";
            this.box_add_1.Size = new System.Drawing.Size(138, 129);
            this.box_add_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_1.TabIndex = 0;
            this.box_add_1.TabStop = false;
            this.box_add_1.Tag = "false";
            this.box_add_1.DoubleClick += new System.EventHandler(this.box_add_1_DoubleClick);
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_stock.Location = new System.Drawing.Point(427, 13);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(120, 20);
            this.txt_stock.TabIndex = 41;
            this.txt_stock.Text = "0";
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Stock";
            // 
            // Form_Article
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(762, 671);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 710);
            this.MinimumSize = new System.Drawing.Size(778, 710);
            this.Name = "Form_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Article_FormClosed);
            this.Load += new System.EventHandler(this.Form_Article_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pua)).EndInit();
            this.tab_photo.ResumeLayout(false);
            this.tab_photo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_add_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox com_famille;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.NumericUpDown txt_puv;
        private System.Windows.Forms.NumericUpDown txt_pua;
        private System.Windows.Forms.DateTimePicker dat_save;
        private System.Windows.Forms.DateTimePicker dat_update;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_photo;
        private System.Windows.Forms.PictureBox box_add_8;
        private System.Windows.Forms.PictureBox box_add_4;
        private System.Windows.Forms.PictureBox box_add_7;
        private System.Windows.Forms.PictureBox box_add_6;
        private System.Windows.Forms.PictureBox box_add_3;
        private System.Windows.Forms.PictureBox box_add_2;
        private System.Windows.Forms.PictureBox box_add_5;
        private System.Windows.Forms.PictureBox box_add_1;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation_;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque_;
        private System.Windows.Forms.DataGridViewTextBoxColumn pua_;
        private System.Windows.Forms.DataGridViewTextBoxColumn puv_;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille_;
        private System.Windows.Forms.DataGridViewTextBoxColumn supp;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.LinkLabel lk_box_add_1;
        private System.Windows.Forms.LinkLabel lk_box_add_4;
        private System.Windows.Forms.LinkLabel lk_box_add_3;
        private System.Windows.Forms.LinkLabel lk_box_add_2;
        private System.Windows.Forms.LinkLabel lk_box_add_8;
        private System.Windows.Forms.LinkLabel lk_box_add_7;
        private System.Windows.Forms.LinkLabel lk_box_add_6;
        private System.Windows.Forms.LinkLabel lk_box_add_5;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label10;
    }
}