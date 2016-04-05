namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_niveau = new System.Windows.Forms.TabPage();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_liste = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_infos = new System.Windows.Forms.GroupBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tab_parametre = new System.Windows.Forms.TabPage();
            this.box_template = new System.Windows.Forms.PictureBox();
            this.box_langue = new System.Windows.Forms.PictureBox();
            this.grp_action_ = new System.Windows.Forms.GroupBox();
            this.btn_reset_setting = new System.Windows.Forms.Button();
            this.btn_save_setting = new System.Windows.Forms.Button();
            this.com_template = new System.Windows.Forms.ComboBox();
            this.lb_template = new System.Windows.Forms.Label();
            this.com_langue = new System.Windows.Forms.ComboBox();
            this.lb_langue = new System.Windows.Forms.Label();
            this.tab_serveur = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_action_s = new System.Windows.Forms.GroupBox();
            this.btn_reset_serveur = new System.Windows.Forms.Button();
            this.btn_save_serveur = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_users = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_database = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_niveau.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.grp_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.grp_infos.SuspendLayout();
            this.grp_action.SuspendLayout();
            this.tab_parametre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_template)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_langue)).BeginInit();
            this.grp_action_.SuspendLayout();
            this.tab_serveur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_action_s.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tab_niveau);
            this.tabControl1.Controls.Add(this.tab_parametre);
            this.tabControl1.Controls.Add(this.tab_serveur);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_niveau
            // 
            this.tab_niveau.Controls.Add(this.grp_search);
            this.tab_niveau.Controls.Add(this.grp_liste);
            this.tab_niveau.Controls.Add(this.grp_infos);
            this.tab_niveau.Controls.Add(this.grp_action);
            this.tab_niveau.Location = new System.Drawing.Point(23, 4);
            this.tab_niveau.Name = "tab_niveau";
            this.tab_niveau.Padding = new System.Windows.Forms.Padding(3);
            this.tab_niveau.Size = new System.Drawing.Size(554, 419);
            this.tab_niveau.TabIndex = 0;
            this.tab_niveau.Text = "Niveau Acces";
            this.tab_niveau.UseVisualStyleBackColor = true;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Location = new System.Drawing.Point(6, 368);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(537, 43);
            this.grp_search.TabIndex = 3;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(42, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(389, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // grp_liste
            // 
            this.grp_liste.Controls.Add(this.dgv_liste);
            this.grp_liste.Location = new System.Drawing.Point(6, 156);
            this.grp_liste.Name = "grp_liste";
            this.grp_liste.Size = new System.Drawing.Size(537, 206);
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
            this.designation_,
            this.description_,
            this.supp_});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(531, 187);
            this.dgv_liste.TabIndex = 0;
            this.dgv_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_liste_CellContentClick);
            this.dgv_liste.SelectionChanged += new System.EventHandler(this.dgv_liste_SelectionChanged);
            // 
            // id_
            // 
            this.id_.HeaderText = "ID";
            this.id_.Name = "id_";
            this.id_.ReadOnly = true;
            this.id_.Visible = false;
            // 
            // designation_
            // 
            this.designation_.FillWeight = 142.3858F;
            this.designation_.HeaderText = "Désignation";
            this.designation_.Name = "designation_";
            this.designation_.ReadOnly = true;
            // 
            // description_
            // 
            this.description_.FillWeight = 142.3858F;
            this.description_.HeaderText = "Déscription";
            this.description_.Name = "description_";
            this.description_.ReadOnly = true;
            // 
            // supp_
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            this.supp_.DefaultCellStyle = dataGridViewCellStyle1;
            this.supp_.FillWeight = 15.22843F;
            this.supp_.HeaderText = "";
            this.supp_.Name = "supp_";
            this.supp_.ReadOnly = true;
            // 
            // grp_infos
            // 
            this.grp_infos.Controls.Add(this.txt_description);
            this.grp_infos.Controls.Add(this.txt_designation);
            this.grp_infos.Controls.Add(this.lb_description);
            this.grp_infos.Controls.Add(this.lb_designation);
            this.grp_infos.Location = new System.Drawing.Point(6, 14);
            this.grp_infos.Name = "grp_infos";
            this.grp_infos.Size = new System.Drawing.Size(431, 136);
            this.grp_infos.TabIndex = 1;
            this.grp_infos.TabStop = false;
            this.grp_infos.Text = "Informations";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(28, 62);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(395, 68);
            this.txt_description.TabIndex = 3;
            this.txt_description.Text = "";
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(110, 18);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(266, 20);
            this.txt_designation.TabIndex = 2;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(25, 47);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(69, 13);
            this.lb_description.TabIndex = 1;
            this.lb_description.Text = "Déscription : ";
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(25, 21);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 0;
            this.lb_designation.Text = "Désignation : ";
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.btn_delete);
            this.grp_action.Controls.Add(this.btn_cancel);
            this.grp_action.Controls.Add(this.btn_save);
            this.grp_action.Location = new System.Drawing.Point(443, 14);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(100, 136);
            this.grp_action.TabIndex = 0;
            this.grp_action.TabStop = false;
            this.grp_action.Text = "Actions";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(13, 95);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "  Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::CATALOGUE_ARTICLE.Properties.Resources.cancel;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(13, 60);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "  Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(13, 24);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tab_parametre
            // 
            this.tab_parametre.Controls.Add(this.box_template);
            this.tab_parametre.Controls.Add(this.box_langue);
            this.tab_parametre.Controls.Add(this.grp_action_);
            this.tab_parametre.Controls.Add(this.com_template);
            this.tab_parametre.Controls.Add(this.lb_template);
            this.tab_parametre.Controls.Add(this.com_langue);
            this.tab_parametre.Controls.Add(this.lb_langue);
            this.tab_parametre.Location = new System.Drawing.Point(23, 4);
            this.tab_parametre.Name = "tab_parametre";
            this.tab_parametre.Padding = new System.Windows.Forms.Padding(3);
            this.tab_parametre.Size = new System.Drawing.Size(554, 419);
            this.tab_parametre.TabIndex = 2;
            this.tab_parametre.Text = "Paramètres";
            this.tab_parametre.UseVisualStyleBackColor = true;
            // 
            // box_template
            // 
            this.box_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_template.Location = new System.Drawing.Point(17, 107);
            this.box_template.Name = "box_template";
            this.box_template.Size = new System.Drawing.Size(531, 304);
            this.box_template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_template.TabIndex = 4;
            this.box_template.TabStop = false;
            // 
            // box_langue
            // 
            this.box_langue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_langue.Location = new System.Drawing.Point(217, 16);
            this.box_langue.Name = "box_langue";
            this.box_langue.Size = new System.Drawing.Size(27, 21);
            this.box_langue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_langue.TabIndex = 4;
            this.box_langue.TabStop = false;
            // 
            // grp_action_
            // 
            this.grp_action_.Controls.Add(this.btn_reset_setting);
            this.grp_action_.Controls.Add(this.btn_save_setting);
            this.grp_action_.Location = new System.Drawing.Point(437, 8);
            this.grp_action_.Name = "grp_action_";
            this.grp_action_.Size = new System.Drawing.Size(109, 90);
            this.grp_action_.TabIndex = 3;
            this.grp_action_.TabStop = false;
            this.grp_action_.Text = "Actions";
            // 
            // btn_reset_setting
            // 
            this.btn_reset_setting.Image = global::CATALOGUE_ARTICLE.Properties.Resources.reset;
            this.btn_reset_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset_setting.Location = new System.Drawing.Point(19, 48);
            this.btn_reset_setting.Name = "btn_reset_setting";
            this.btn_reset_setting.Size = new System.Drawing.Size(81, 23);
            this.btn_reset_setting.TabIndex = 2;
            this.btn_reset_setting.Text = "  Défaut";
            this.btn_reset_setting.UseVisualStyleBackColor = true;
            // 
            // btn_save_setting
            // 
            this.btn_save_setting.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_setting.Location = new System.Drawing.Point(19, 19);
            this.btn_save_setting.Name = "btn_save_setting";
            this.btn_save_setting.Size = new System.Drawing.Size(81, 23);
            this.btn_save_setting.TabIndex = 2;
            this.btn_save_setting.Text = "   Save";
            this.btn_save_setting.UseVisualStyleBackColor = true;
            this.btn_save_setting.Click += new System.EventHandler(this.btn_save_setting_Click);
            // 
            // com_template
            // 
            this.com_template.FormattingEnabled = true;
            this.com_template.Items.AddRange(new object[] {
            "Basique",
            "Classique",
            "BlackClass",
            "BlueTrack"});
            this.com_template.Location = new System.Drawing.Point(90, 77);
            this.com_template.Name = "com_template";
            this.com_template.Size = new System.Drawing.Size(121, 21);
            this.com_template.TabIndex = 1;
            this.com_template.SelectedIndexChanged += new System.EventHandler(this.com_template_SelectedIndexChanged);
            // 
            // lb_template
            // 
            this.lb_template.AutoSize = true;
            this.lb_template.Location = new System.Drawing.Point(14, 80);
            this.lb_template.Name = "lb_template";
            this.lb_template.Size = new System.Drawing.Size(60, 13);
            this.lb_template.TabIndex = 0;
            this.lb_template.Text = "Template : ";
            // 
            // com_langue
            // 
            this.com_langue.FormattingEnabled = true;
            this.com_langue.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.com_langue.Location = new System.Drawing.Point(90, 16);
            this.com_langue.Name = "com_langue";
            this.com_langue.Size = new System.Drawing.Size(121, 21);
            this.com_langue.TabIndex = 1;
            this.com_langue.SelectedIndexChanged += new System.EventHandler(this.com_langue_SelectedIndexChanged);
            // 
            // lb_langue
            // 
            this.lb_langue.AutoSize = true;
            this.lb_langue.Location = new System.Drawing.Point(14, 19);
            this.lb_langue.Name = "lb_langue";
            this.lb_langue.Size = new System.Drawing.Size(52, 13);
            this.lb_langue.TabIndex = 0;
            this.lb_langue.Text = "Langue : ";
            // 
            // tab_serveur
            // 
            this.tab_serveur.Controls.Add(this.pictureBox3);
            this.tab_serveur.Controls.Add(this.pictureBox2);
            this.tab_serveur.Controls.Add(this.pictureBox1);
            this.tab_serveur.Controls.Add(this.grp_action_s);
            this.tab_serveur.Controls.Add(this.txt_password);
            this.tab_serveur.Controls.Add(this.txt_users);
            this.tab_serveur.Controls.Add(this.txt_database);
            this.tab_serveur.Controls.Add(this.txt_port);
            this.tab_serveur.Controls.Add(this.txt_adresse);
            this.tab_serveur.Controls.Add(this.lb_password);
            this.tab_serveur.Controls.Add(this.lb_user);
            this.tab_serveur.Controls.Add(this.lb_database);
            this.tab_serveur.Controls.Add(this.label2);
            this.tab_serveur.Controls.Add(this.label1);
            this.tab_serveur.Controls.Add(this.lb_port);
            this.tab_serveur.Controls.Add(this.lb_adresse);
            this.tab_serveur.Location = new System.Drawing.Point(23, 4);
            this.tab_serveur.Name = "tab_serveur";
            this.tab_serveur.Padding = new System.Windows.Forms.Padding(3);
            this.tab_serveur.Size = new System.Drawing.Size(554, 419);
            this.tab_serveur.TabIndex = 3;
            this.tab_serveur.Text = "Serveur";
            this.tab_serveur.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CATALOGUE_ARTICLE.Properties.Resources.pc;
            this.pictureBox3.Location = new System.Drawing.Point(23, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CATALOGUE_ARTICLE.Properties.Resources.remote;
            this.pictureBox2.Location = new System.Drawing.Point(214, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CATALOGUE_ARTICLE.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(404, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // grp_action_s
            // 
            this.grp_action_s.Controls.Add(this.btn_reset_serveur);
            this.grp_action_s.Controls.Add(this.btn_save_serveur);
            this.grp_action_s.Location = new System.Drawing.Point(418, 22);
            this.grp_action_s.Name = "grp_action_s";
            this.grp_action_s.Size = new System.Drawing.Size(111, 92);
            this.grp_action_s.TabIndex = 6;
            this.grp_action_s.TabStop = false;
            this.grp_action_s.Text = "Actions";
            // 
            // btn_reset_serveur
            // 
            this.btn_reset_serveur.Image = global::CATALOGUE_ARTICLE.Properties.Resources.reset;
            this.btn_reset_serveur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset_serveur.Location = new System.Drawing.Point(18, 56);
            this.btn_reset_serveur.Name = "btn_reset_serveur";
            this.btn_reset_serveur.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_serveur.TabIndex = 1;
            this.btn_reset_serveur.Text = "  Reset";
            this.btn_reset_serveur.UseVisualStyleBackColor = true;
            this.btn_reset_serveur.Click += new System.EventHandler(this.btn_reset_serveur_Click);
            // 
            // btn_save_serveur
            // 
            this.btn_save_serveur.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save_serveur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_serveur.Location = new System.Drawing.Point(18, 22);
            this.btn_save_serveur.Name = "btn_save_serveur";
            this.btn_save_serveur.Size = new System.Drawing.Size(75, 23);
            this.btn_save_serveur.TabIndex = 0;
            this.btn_save_serveur.Text = "   Save";
            this.btn_save_serveur.UseVisualStyleBackColor = true;
            this.btn_save_serveur.Click += new System.EventHandler(this.btn_save_serveur_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(110, 198);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(253, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "yves1910/";
            // 
            // txt_users
            // 
            this.txt_users.Location = new System.Drawing.Point(110, 154);
            this.txt_users.Name = "txt_users";
            this.txt_users.Size = new System.Drawing.Size(253, 20);
            this.txt_users.TabIndex = 5;
            this.txt_users.Text = "postgres";
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(110, 108);
            this.txt_database.Name = "txt_database";
            this.txt_database.ReadOnly = true;
            this.txt_database.Size = new System.Drawing.Size(253, 20);
            this.txt_database.TabIndex = 5;
            this.txt_database.Text = "catalogue_article";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(110, 68);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(84, 20);
            this.txt_port.TabIndex = 5;
            this.txt_port.Text = "5432";
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(110, 28);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(253, 20);
            this.txt_adresse.TabIndex = 5;
            this.txt_adresse.Text = "127.0.0.1";
            this.txt_adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(20, 201);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(62, 13);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password : ";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(20, 157);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(62, 13);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "Utilisateur : ";
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(20, 111);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(62, 13);
            this.lb_database.TabIndex = 2;
            this.lb_database.Text = "Database : ";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(20, 71);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(35, 13);
            this.lb_port.TabIndex = 1;
            this.lb_port.Text = "Port : ";
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Location = new System.Drawing.Point(20, 31);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(67, 13);
            this.lb_adresse.TabIndex = 0;
            this.lb_adresse.Text = "Adresse IP : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " ==>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = " ==>";
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 466);
            this.MinimumSize = new System.Drawing.Size(597, 466);
            this.Name = "Form_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Setting_FormClosed);
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_niveau.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.grp_infos.ResumeLayout(false);
            this.grp_infos.PerformLayout();
            this.grp_action.ResumeLayout(false);
            this.tab_parametre.ResumeLayout(false);
            this.tab_parametre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_template)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_langue)).EndInit();
            this.grp_action_.ResumeLayout(false);
            this.tab_serveur.ResumeLayout(false);
            this.tab_serveur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_action_s.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_niveau;
        private System.Windows.Forms.TabPage tab_parametre;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.GroupBox grp_liste;
        private System.Windows.Forms.GroupBox grp_infos;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.GroupBox grp_action;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation_;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_;
        private System.Windows.Forms.DataGridViewTextBoxColumn supp_;
        private System.Windows.Forms.TabPage tab_serveur;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_users;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_database;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_adresse;
        private System.Windows.Forms.GroupBox grp_action_s;
        private System.Windows.Forms.Button btn_reset_serveur;
        private System.Windows.Forms.Button btn_save_serveur;
        private System.Windows.Forms.ComboBox com_langue;
        private System.Windows.Forms.Label lb_langue;
        private System.Windows.Forms.GroupBox grp_action_;
        private System.Windows.Forms.Button btn_reset_setting;
        private System.Windows.Forms.Button btn_save_setting;
        private System.Windows.Forms.PictureBox box_langue;
        private System.Windows.Forms.PictureBox box_template;
        private System.Windows.Forms.ComboBox com_template;
        private System.Windows.Forms.Label lb_template;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}