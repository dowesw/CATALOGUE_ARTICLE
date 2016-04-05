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
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_liste = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pua_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puv_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_infos = new System.Windows.Forms.TabPage();
            this.btn_add_marque = new System.Windows.Forms.Button();
            this.btn_add_famille = new System.Windows.Forms.Button();
            this.box_photo = new System.Windows.Forms.PictureBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.com_marque = new System.Windows.Forms.ComboBox();
            this.com_famille = new System.Windows.Forms.ComboBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_puv = new System.Windows.Forms.NumericUpDown();
            this.txt_pua = new System.Windows.Forms.NumericUpDown();
            this.dat_save = new System.Windows.Forms.DateTimePicker();
            this.dat_update = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.lb_dateupdate = new System.Windows.Forms.Label();
            this.lb_datesave = new System.Windows.Forms.Label();
            this.lb_prixv = new System.Windows.Forms.Label();
            this.lb_famille = new System.Windows.Forms.Label();
            this.lb_marque = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.lb_reference = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_prixa = new System.Windows.Forms.Label();
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
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lb_by_marque = new System.Windows.Forms.Label();
            this.txt_search_marque = new System.Windows.Forms.TextBox();
            this.lb_by_famille = new System.Windows.Forms.Label();
            this.txt_search_famille = new System.Windows.Forms.TextBox();
            this.grp_action.SuspendLayout();
            this.grp_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).BeginInit();
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
            this.grp_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.btn_delete);
            this.grp_action.Controls.Add(this.btn_cancel);
            this.grp_action.Controls.Add(this.btn_save);
            this.grp_action.Location = new System.Drawing.Point(849, 12);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(105, 125);
            this.grp_action.TabIndex = 0;
            this.grp_action.TabStop = false;
            this.grp_action.Text = "Actions";
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
            // grp_liste
            // 
            this.grp_liste.Controls.Add(this.dgv_liste);
            this.grp_liste.Location = new System.Drawing.Point(12, 381);
            this.grp_liste.Name = "grp_liste";
            this.grp_liste.Size = new System.Drawing.Size(942, 263);
            this.grp_liste.TabIndex = 2;
            this.grp_liste.TabStop = false;
            this.grp_liste.Text = "Liste";
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
            this.dgv_liste.Size = new System.Drawing.Size(936, 244);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_infos);
            this.tabControl1.Controls.Add(this.tab_photo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 305);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_infos
            // 
            this.tab_infos.Controls.Add(this.btn_add_marque);
            this.tab_infos.Controls.Add(this.btn_add_famille);
            this.tab_infos.Controls.Add(this.box_photo);
            this.tab_infos.Controls.Add(this.txt_stock);
            this.tab_infos.Controls.Add(this.com_marque);
            this.tab_infos.Controls.Add(this.com_famille);
            this.tab_infos.Controls.Add(this.txt_designation);
            this.tab_infos.Controls.Add(this.txt_reference);
            this.tab_infos.Controls.Add(this.txt_puv);
            this.tab_infos.Controls.Add(this.txt_pua);
            this.tab_infos.Controls.Add(this.dat_save);
            this.tab_infos.Controls.Add(this.dat_update);
            this.tab_infos.Controls.Add(this.txt_description);
            this.tab_infos.Controls.Add(this.lb_dateupdate);
            this.tab_infos.Controls.Add(this.lb_datesave);
            this.tab_infos.Controls.Add(this.lb_prixv);
            this.tab_infos.Controls.Add(this.lb_famille);
            this.tab_infos.Controls.Add(this.lb_marque);
            this.tab_infos.Controls.Add(this.lb_description);
            this.tab_infos.Controls.Add(this.lb_designation);
            this.tab_infos.Controls.Add(this.lb_reference);
            this.tab_infos.Controls.Add(this.lb_stock);
            this.tab_infos.Controls.Add(this.lb_prixa);
            this.tab_infos.Location = new System.Drawing.Point(4, 22);
            this.tab_infos.Name = "tab_infos";
            this.tab_infos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_infos.Size = new System.Drawing.Size(823, 279);
            this.tab_infos.TabIndex = 0;
            this.tab_infos.Text = "Informations";
            this.tab_infos.UseVisualStyleBackColor = true;
            // 
            // btn_add_marque
            // 
            this.btn_add_marque.Image = global::CATALOGUE_ARTICLE.Properties.Resources.add;
            this.btn_add_marque.Location = new System.Drawing.Point(261, 105);
            this.btn_add_marque.Name = "btn_add_marque";
            this.btn_add_marque.Size = new System.Drawing.Size(23, 23);
            this.btn_add_marque.TabIndex = 43;
            this.btn_add_marque.UseVisualStyleBackColor = true;
            this.btn_add_marque.Click += new System.EventHandler(this.btn_add_marque_Click);
            // 
            // btn_add_famille
            // 
            this.btn_add_famille.Image = global::CATALOGUE_ARTICLE.Properties.Resources.add;
            this.btn_add_famille.Location = new System.Drawing.Point(261, 74);
            this.btn_add_famille.Name = "btn_add_famille";
            this.btn_add_famille.Size = new System.Drawing.Size(23, 23);
            this.btn_add_famille.TabIndex = 43;
            this.btn_add_famille.UseVisualStyleBackColor = true;
            this.btn_add_famille.Click += new System.EventHandler(this.btn_add_famille_Click);
            // 
            // box_photo
            // 
            this.box_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.article;
            this.box_photo.Location = new System.Drawing.Point(656, 16);
            this.box_photo.Name = "box_photo";
            this.box_photo.Size = new System.Drawing.Size(149, 138);
            this.box_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_photo.TabIndex = 42;
            this.box_photo.TabStop = false;
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
            // com_marque
            // 
            this.com_marque.FormattingEnabled = true;
            this.com_marque.Location = new System.Drawing.Point(100, 106);
            this.com_marque.Name = "com_marque";
            this.com_marque.Size = new System.Drawing.Size(155, 21);
            this.com_marque.TabIndex = 35;
            this.com_marque.SelectedIndexChanged += new System.EventHandler(this.com_marque_SelectedIndexChanged);
            // 
            // com_famille
            // 
            this.com_famille.FormattingEnabled = true;
            this.com_famille.Location = new System.Drawing.Point(100, 75);
            this.com_famille.Name = "com_famille";
            this.com_famille.Size = new System.Drawing.Size(155, 21);
            this.com_famille.TabIndex = 35;
            this.com_famille.SelectedIndexChanged += new System.EventHandler(this.com_famille_SelectedIndexChanged);
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
            this.txt_description.Size = new System.Drawing.Size(786, 71);
            this.txt_description.TabIndex = 40;
            this.txt_description.Text = "";
            this.txt_description.Enter += new System.EventHandler(this.txt_description_Enter);
            this.txt_description.Leave += new System.EventHandler(this.txt_description_Leave);
            // 
            // lb_dateupdate
            // 
            this.lb_dateupdate.AutoSize = true;
            this.lb_dateupdate.Location = new System.Drawing.Point(326, 141);
            this.lb_dateupdate.Name = "lb_dateupdate";
            this.lb_dateupdate.Size = new System.Drawing.Size(99, 13);
            this.lb_dateupdate.TabIndex = 26;
            this.lb_dateupdate.Text = "Date Modification : ";
            // 
            // lb_datesave
            // 
            this.lb_datesave.AutoSize = true;
            this.lb_datesave.Location = new System.Drawing.Point(16, 141);
            this.lb_datesave.Name = "lb_datesave";
            this.lb_datesave.Size = new System.Drawing.Size(81, 13);
            this.lb_datesave.TabIndex = 25;
            this.lb_datesave.Text = "Date Création : ";
            // 
            // lb_prixv
            // 
            this.lb_prixv.AutoSize = true;
            this.lb_prixv.Location = new System.Drawing.Point(326, 109);
            this.lb_prixv.Name = "lb_prixv";
            this.lb_prixv.Size = new System.Drawing.Size(43, 13);
            this.lb_prixv.TabIndex = 24;
            this.lb_prixv.Text = "Prix.V : ";
            // 
            // lb_famille
            // 
            this.lb_famille.AutoSize = true;
            this.lb_famille.Location = new System.Drawing.Point(16, 78);
            this.lb_famille.Name = "lb_famille";
            this.lb_famille.Size = new System.Drawing.Size(48, 13);
            this.lb_famille.TabIndex = 23;
            this.lb_famille.Text = "Famille : ";
            // 
            // lb_marque
            // 
            this.lb_marque.AutoSize = true;
            this.lb_marque.Location = new System.Drawing.Point(16, 109);
            this.lb_marque.Name = "lb_marque";
            this.lb_marque.Size = new System.Drawing.Size(52, 13);
            this.lb_marque.TabIndex = 22;
            this.lb_marque.Text = "Marque : ";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(16, 171);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(69, 13);
            this.lb_description.TabIndex = 21;
            this.lb_description.Text = "Description : ";
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(16, 47);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 20;
            this.lb_designation.Text = "Désignation : ";
            // 
            // lb_reference
            // 
            this.lb_reference.AutoSize = true;
            this.lb_reference.Location = new System.Drawing.Point(16, 16);
            this.lb_reference.Name = "lb_reference";
            this.lb_reference.Size = new System.Drawing.Size(66, 13);
            this.lb_reference.TabIndex = 19;
            this.lb_reference.Text = "Reférence : ";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(326, 16);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(35, 13);
            this.lb_stock.TabIndex = 18;
            this.lb_stock.Text = "Stock";
            // 
            // lb_prixa
            // 
            this.lb_prixa.AutoSize = true;
            this.lb_prixa.Location = new System.Drawing.Point(326, 78);
            this.lb_prixa.Name = "lb_prixa";
            this.lb_prixa.Size = new System.Drawing.Size(43, 13);
            this.lb_prixa.TabIndex = 18;
            this.lb_prixa.Text = "Prix.A : ";
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
            this.tab_photo.Size = new System.Drawing.Size(823, 279);
            this.tab_photo.TabIndex = 1;
            this.tab_photo.Text = "Photos";
            this.tab_photo.UseVisualStyleBackColor = true;
            // 
            // lk_box_add_8
            // 
            this.lk_box_add_8.AutoSize = true;
            this.lk_box_add_8.Location = new System.Drawing.Point(731, 254);
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
            this.lk_box_add_7.Location = new System.Drawing.Point(525, 254);
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
            this.lk_box_add_4.Location = new System.Drawing.Point(732, 120);
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
            this.lk_box_add_6.Location = new System.Drawing.Point(314, 254);
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
            this.lk_box_add_3.Location = new System.Drawing.Point(526, 120);
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
            this.lk_box_add_5.Location = new System.Drawing.Point(114, 255);
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
            this.lk_box_add_2.Location = new System.Drawing.Point(315, 120);
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
            this.lk_box_add_1.Location = new System.Drawing.Point(114, 120);
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
            this.box_add_8.Location = new System.Drawing.Point(651, 142);
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
            this.box_add_4.Location = new System.Drawing.Point(652, 6);
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
            this.box_add_7.Location = new System.Drawing.Point(444, 142);
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
            this.box_add_6.Location = new System.Drawing.Point(234, 142);
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
            this.box_add_3.Location = new System.Drawing.Point(445, 7);
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
            this.box_add_2.Location = new System.Drawing.Point(235, 6);
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
            this.box_add_5.Location = new System.Drawing.Point(34, 143);
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
            this.box_add_1.Location = new System.Drawing.Point(34, 7);
            this.box_add_1.Name = "box_add_1";
            this.box_add_1.Size = new System.Drawing.Size(138, 129);
            this.box_add_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_add_1.TabIndex = 0;
            this.box_add_1.TabStop = false;
            this.box_add_1.Tag = "false";
            this.box_add_1.DoubleClick += new System.EventHandler(this.box_add_1_DoubleClick);
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Controls.Add(this.txt_search_famille);
            this.grp_search.Controls.Add(this.lb_by_famille);
            this.grp_search.Controls.Add(this.txt_search_marque);
            this.grp_search.Controls.Add(this.lb_by_marque);
            this.grp_search.Location = new System.Drawing.Point(15, 327);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(828, 46);
            this.grp_search.TabIndex = 5;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(35, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(195, 20);
            this.txt_search.TabIndex = 33;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lb_by_marque
            // 
            this.lb_by_marque.AutoSize = true;
            this.lb_by_marque.Location = new System.Drawing.Point(263, 19);
            this.lb_by_marque.Name = "lb_by_marque";
            this.lb_by_marque.Size = new System.Drawing.Size(71, 13);
            this.lb_by_marque.TabIndex = 19;
            this.lb_by_marque.Text = "Par Marque : ";
            // 
            // txt_search_marque
            // 
            this.txt_search_marque.Location = new System.Drawing.Point(347, 16);
            this.txt_search_marque.Name = "txt_search_marque";
            this.txt_search_marque.Size = new System.Drawing.Size(184, 20);
            this.txt_search_marque.TabIndex = 32;
            this.txt_search_marque.TextChanged += new System.EventHandler(this.txt_search_marque_TextChanged);
            // 
            // lb_by_famille
            // 
            this.lb_by_famille.AutoSize = true;
            this.lb_by_famille.Location = new System.Drawing.Point(554, 19);
            this.lb_by_famille.Name = "lb_by_famille";
            this.lb_by_famille.Size = new System.Drawing.Size(67, 13);
            this.lb_by_famille.TabIndex = 19;
            this.lb_by_famille.Text = "Par Famille : ";
            // 
            // txt_search_famille
            // 
            this.txt_search_famille.Location = new System.Drawing.Point(638, 16);
            this.txt_search_famille.Name = "txt_search_famille";
            this.txt_search_famille.Size = new System.Drawing.Size(184, 20);
            this.txt_search_famille.TabIndex = 32;
            this.txt_search_famille.TextChanged += new System.EventHandler(this.txt_search_famille_TextChanged);
            // 
            // Form_Article
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(956, 650);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grp_liste);
            this.Controls.Add(this.grp_action);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(972, 689);
            this.MinimumSize = new System.Drawing.Size(972, 689);
            this.Name = "Form_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Article_FormClosed);
            this.Load += new System.EventHandler(this.Form_Article_Load);
            this.Enter += new System.EventHandler(this.Form_Article_Enter);
            this.grp_action.ResumeLayout(false);
            this.grp_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_infos.ResumeLayout(false);
            this.tab_infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).EndInit();
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
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_action;
        private System.Windows.Forms.GroupBox grp_liste;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_infos;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.NumericUpDown txt_puv;
        private System.Windows.Forms.NumericUpDown txt_pua;
        private System.Windows.Forms.DateTimePicker dat_save;
        private System.Windows.Forms.DateTimePicker dat_update;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label lb_dateupdate;
        private System.Windows.Forms.Label lb_datesave;
        private System.Windows.Forms.Label lb_prixv;
        private System.Windows.Forms.Label lb_famille;
        private System.Windows.Forms.Label lb_marque;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.Label lb_reference;
        private System.Windows.Forms.Label lb_prixa;
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
        private System.Windows.Forms.LinkLabel lk_box_add_1;
        private System.Windows.Forms.LinkLabel lk_box_add_4;
        private System.Windows.Forms.LinkLabel lk_box_add_3;
        private System.Windows.Forms.LinkLabel lk_box_add_2;
        private System.Windows.Forms.LinkLabel lk_box_add_8;
        private System.Windows.Forms.LinkLabel lk_box_add_7;
        private System.Windows.Forms.LinkLabel lk_box_add_6;
        private System.Windows.Forms.LinkLabel lk_box_add_5;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.PictureBox box_photo;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_add_marque;
        private System.Windows.Forms.Button btn_add_famille;
        public System.Windows.Forms.ComboBox com_famille;
        public System.Windows.Forms.ComboBox com_marque;
        private System.Windows.Forms.TextBox txt_search_famille;
        private System.Windows.Forms.Label lb_by_famille;
        private System.Windows.Forms.TextBox txt_search_marque;
        private System.Windows.Forms.Label lb_by_marque;
    }
}