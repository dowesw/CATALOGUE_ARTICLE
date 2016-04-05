namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_DocStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DocStock));
            this.grp_document = new System.Windows.Forms.GroupBox();
            this.date_save = new System.Windows.Forms.DateTimePicker();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.grp_type = new System.Windows.Forms.GroupBox();
            this.rbtn_sortie = new System.Windows.Forms.RadioButton();
            this.rbtn_entree = new System.Windows.Forms.RadioButton();
            this.lb_datesave = new System.Windows.Forms.Label();
            this.lb_reference = new System.Windows.Forms.Label();
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_contenu = new System.Windows.Forms.GroupBox();
            this.txt_search_art = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_contenu = new System.Windows.Forms.DataGridView();
            this._id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._supp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_prix = new System.Windows.Forms.NumericUpDown();
            this.txt_qte = new System.Windows.Forms.NumericUpDown();
            this.com_article = new System.Windows.Forms.ComboBox();
            this.lb_qte = new System.Windows.Forms.Label();
            this.lb_article = new System.Windows.Forms.Label();
            this.lb_prix = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            this.grp_liste = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icon_ = new System.Windows.Forms.DataGridViewImageColumn();
            this.reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_document.SuspendLayout();
            this.grp_type.SuspendLayout();
            this.grp_action.SuspendLayout();
            this.grp_contenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).BeginInit();
            this.grp_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.grp_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_document
            // 
            this.grp_document.Controls.Add(this.date_save);
            this.grp_document.Controls.Add(this.txt_reference);
            this.grp_document.Controls.Add(this.grp_type);
            this.grp_document.Controls.Add(this.lb_datesave);
            this.grp_document.Controls.Add(this.lb_reference);
            this.grp_document.Location = new System.Drawing.Point(12, 12);
            this.grp_document.Name = "grp_document";
            this.grp_document.Size = new System.Drawing.Size(536, 100);
            this.grp_document.TabIndex = 0;
            this.grp_document.TabStop = false;
            this.grp_document.Text = "Document";
            // 
            // date_save
            // 
            this.date_save.Location = new System.Drawing.Point(95, 54);
            this.date_save.Name = "date_save";
            this.date_save.Size = new System.Drawing.Size(200, 20);
            this.date_save.TabIndex = 7;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(95, 25);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.ReadOnly = true;
            this.txt_reference.Size = new System.Drawing.Size(296, 20);
            this.txt_reference.TabIndex = 6;
            // 
            // grp_type
            // 
            this.grp_type.Controls.Add(this.rbtn_sortie);
            this.grp_type.Controls.Add(this.rbtn_entree);
            this.grp_type.Location = new System.Drawing.Point(430, 13);
            this.grp_type.Name = "grp_type";
            this.grp_type.Size = new System.Drawing.Size(86, 75);
            this.grp_type.TabIndex = 8;
            this.grp_type.TabStop = false;
            this.grp_type.Text = "Type";
            // 
            // rbtn_sortie
            // 
            this.rbtn_sortie.AutoSize = true;
            this.rbtn_sortie.Location = new System.Drawing.Point(24, 41);
            this.rbtn_sortie.Name = "rbtn_sortie";
            this.rbtn_sortie.Size = new System.Drawing.Size(52, 17);
            this.rbtn_sortie.TabIndex = 1;
            this.rbtn_sortie.Text = "Sortie";
            this.rbtn_sortie.UseVisualStyleBackColor = true;
            this.rbtn_sortie.CheckedChanged += new System.EventHandler(this.rbtn_sortie_CheckedChanged);
            // 
            // rbtn_entree
            // 
            this.rbtn_entree.AutoSize = true;
            this.rbtn_entree.Checked = true;
            this.rbtn_entree.Location = new System.Drawing.Point(24, 19);
            this.rbtn_entree.Name = "rbtn_entree";
            this.rbtn_entree.Size = new System.Drawing.Size(56, 17);
            this.rbtn_entree.TabIndex = 0;
            this.rbtn_entree.TabStop = true;
            this.rbtn_entree.Text = "Entrée";
            this.rbtn_entree.UseVisualStyleBackColor = true;
            this.rbtn_entree.CheckedChanged += new System.EventHandler(this.rbtn_entree_CheckedChanged);
            // 
            // lb_datesave
            // 
            this.lb_datesave.AutoSize = true;
            this.lb_datesave.Location = new System.Drawing.Point(23, 58);
            this.lb_datesave.Name = "lb_datesave";
            this.lb_datesave.Size = new System.Drawing.Size(67, 13);
            this.lb_datesave.TabIndex = 2;
            this.lb_datesave.Text = "Date Save : ";
            // 
            // lb_reference
            // 
            this.lb_reference.AutoSize = true;
            this.lb_reference.Location = new System.Drawing.Point(23, 28);
            this.lb_reference.Name = "lb_reference";
            this.lb_reference.Size = new System.Drawing.Size(66, 13);
            this.lb_reference.TabIndex = 1;
            this.lb_reference.Text = "Réference : ";
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.btn_delete);
            this.grp_action.Controls.Add(this.btn_cancel);
            this.grp_action.Controls.Add(this.btn_save);
            this.grp_action.Location = new System.Drawing.Point(554, 12);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(114, 113);
            this.grp_action.TabIndex = 1;
            this.grp_action.TabStop = false;
            this.grp_action.Text = "Actions";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(17, 80);
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
            this.btn_cancel.Location = new System.Drawing.Point(17, 49);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "  Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(17, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grp_contenu
            // 
            this.grp_contenu.Controls.Add(this.txt_search_art);
            this.grp_contenu.Controls.Add(this.panel2);
            this.grp_contenu.Controls.Add(this.panel1);
            this.grp_contenu.Controls.Add(this.lb_search);
            this.grp_contenu.Location = new System.Drawing.Point(12, 131);
            this.grp_contenu.Name = "grp_contenu";
            this.grp_contenu.Size = new System.Drawing.Size(656, 256);
            this.grp_contenu.TabIndex = 2;
            this.grp_contenu.TabStop = false;
            this.grp_contenu.Text = "Contenus";
            // 
            // txt_search_art
            // 
            this.txt_search_art.Location = new System.Drawing.Point(102, 230);
            this.txt_search_art.Name = "txt_search_art";
            this.txt_search_art.Size = new System.Drawing.Size(260, 20);
            this.txt_search_art.TabIndex = 6;
            this.txt_search_art.TextChanged += new System.EventHandler(this.txt_search_art_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_contenu);
            this.panel2.Location = new System.Drawing.Point(6, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 163);
            this.panel2.TabIndex = 1;
            // 
            // dgv_contenu
            // 
            this.dgv_contenu.AllowUserToAddRows = false;
            this.dgv_contenu.AllowUserToDeleteRows = false;
            this.dgv_contenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contenu.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_contenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id_,
            this.article_,
            this.qte_,
            this.prix_,
            this._supp_});
            this.dgv_contenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_contenu.Location = new System.Drawing.Point(0, 0);
            this.dgv_contenu.Name = "dgv_contenu";
            this.dgv_contenu.ReadOnly = true;
            this.dgv_contenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contenu.Size = new System.Drawing.Size(644, 163);
            this.dgv_contenu.TabIndex = 0;
            this.dgv_contenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contenu_CellContentClick);
            this.dgv_contenu.SelectionChanged += new System.EventHandler(this.dgv_contenu_SelectionChanged);
            // 
            // _id_
            // 
            this._id_.HeaderText = "ID";
            this._id_.Name = "_id_";
            this._id_.ReadOnly = true;
            this._id_.Visible = false;
            // 
            // article_
            // 
            this.article_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.article_.FillWeight = 126.5651F;
            this.article_.HeaderText = "Article";
            this.article_.Name = "article_";
            this.article_.ReadOnly = true;
            // 
            // qte_
            // 
            this.qte_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qte_.FillWeight = 126.5651F;
            this.qte_.HeaderText = "Quantitée";
            this.qte_.Name = "qte_";
            this.qte_.ReadOnly = true;
            // 
            // prix_
            // 
            this.prix_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix_.FillWeight = 126.5651F;
            this.prix_.HeaderText = "Prix";
            this.prix_.Name = "prix_";
            this.prix_.ReadOnly = true;
            // 
            // _supp_
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            this._supp_.DefaultCellStyle = dataGridViewCellStyle1;
            this._supp_.FillWeight = 20.30457F;
            this._supp_.HeaderText = "";
            this._supp_.Name = "_supp_";
            this._supp_.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_prix);
            this.panel1.Controls.Add(this.txt_qte);
            this.panel1.Controls.Add(this.com_article);
            this.panel1.Controls.Add(this.lb_qte);
            this.panel1.Controls.Add(this.lb_article);
            this.panel1.Controls.Add(this.lb_prix);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 36);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Image = global::CATALOGUE_ARTICLE.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(605, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(31, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "&A";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_prix
            // 
            this.txt_prix.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txt_prix.Location = new System.Drawing.Point(470, 8);
            this.txt_prix.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(120, 20);
            this.txt_prix.TabIndex = 3;
            this.txt_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_prix.Enter += new System.EventHandler(this.txt_prix_Enter);
            this.txt_prix.Leave += new System.EventHandler(this.txt_prix_Leave);
            // 
            // txt_qte
            // 
            this.txt_qte.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txt_qte.Location = new System.Drawing.Point(299, 8);
            this.txt_qte.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(120, 20);
            this.txt_qte.TabIndex = 2;
            this.txt_qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_qte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qte.Enter += new System.EventHandler(this.txt_qte_Enter);
            this.txt_qte.Leave += new System.EventHandler(this.txt_qte_Leave);
            // 
            // com_article
            // 
            this.com_article.FormattingEnabled = true;
            this.com_article.Location = new System.Drawing.Point(50, 8);
            this.com_article.Name = "com_article";
            this.com_article.Size = new System.Drawing.Size(177, 21);
            this.com_article.TabIndex = 1;
            this.com_article.SelectedIndexChanged += new System.EventHandler(this.com_article_SelectedIndexChanged);
            this.com_article.Enter += new System.EventHandler(this.com_article_Enter);
            this.com_article.Leave += new System.EventHandler(this.com_article_Leave);
            // 
            // lb_qte
            // 
            this.lb_qte.AutoSize = true;
            this.lb_qte.Location = new System.Drawing.Point(237, 11);
            this.lb_qte.Name = "lb_qte";
            this.lb_qte.Size = new System.Drawing.Size(62, 13);
            this.lb_qte.TabIndex = 2;
            this.lb_qte.Text = "Quantitée : ";
            // 
            // lb_article
            // 
            this.lb_article.AutoSize = true;
            this.lb_article.Location = new System.Drawing.Point(8, 12);
            this.lb_article.Name = "lb_article";
            this.lb_article.Size = new System.Drawing.Size(45, 13);
            this.lb_article.TabIndex = 1;
            this.lb_article.Text = "Article : ";
            // 
            // lb_prix
            // 
            this.lb_prix.AutoSize = true;
            this.lb_prix.Location = new System.Drawing.Point(431, 11);
            this.lb_prix.Name = "lb_prix";
            this.lb_prix.Size = new System.Drawing.Size(33, 13);
            this.lb_prix.TabIndex = 0;
            this.lb_prix.Text = "Prix : ";
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(22, 233);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(69, 13);
            this.lb_search.TabIndex = 2;
            this.lb_search.Text = "Recherche : ";
            // 
            // grp_liste
            // 
            this.grp_liste.Controls.Add(this.dgv_liste);
            this.grp_liste.Location = new System.Drawing.Point(12, 393);
            this.grp_liste.Name = "grp_liste";
            this.grp_liste.Size = new System.Drawing.Size(656, 229);
            this.grp_liste.TabIndex = 3;
            this.grp_liste.TabStop = false;
            this.grp_liste.Text = "Liste";
            // 
            // dgv_liste
            // 
            this.dgv_liste.AllowUserToAddRows = false;
            this.dgv_liste.AllowUserToDeleteRows = false;
            this.dgv_liste.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.icon_,
            this.reference_,
            this.date_,
            this.type_,
            this.supp_});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(650, 210);
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
            // icon_
            // 
            this.icon_.FillWeight = 26.35914F;
            this.icon_.HeaderText = "";
            this.icon_.Name = "icon_";
            this.icon_.ReadOnly = true;
            this.icon_.Width = 32;
            // 
            // reference_
            // 
            this.reference_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reference_.FillWeight = 177.3068F;
            this.reference_.HeaderText = "Réference";
            this.reference_.Name = "reference_";
            this.reference_.ReadOnly = true;
            // 
            // date_
            // 
            this.date_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_.FillWeight = 156.0152F;
            this.date_.HeaderText = "Date Création";
            this.date_.Name = "date_";
            this.date_.ReadOnly = true;
            // 
            // type_
            // 
            this.type_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type_.FillWeight = 117.882F;
            this.type_.HeaderText = "Type";
            this.type_.Name = "type_";
            this.type_.ReadOnly = true;
            // 
            // supp_
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "X";
            this.supp_.DefaultCellStyle = dataGridViewCellStyle2;
            this.supp_.FillWeight = 22.4368F;
            this.supp_.HeaderText = "";
            this.supp_.Name = "supp_";
            this.supp_.ReadOnly = true;
            this.supp_.Width = 27;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Location = new System.Drawing.Point(12, 628);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(650, 40);
            this.grp_search.TabIndex = 4;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(43, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(262, 20);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Form_DocStock
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(676, 672);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.grp_liste);
            this.Controls.Add(this.grp_contenu);
            this.Controls.Add(this.grp_action);
            this.Controls.Add(this.grp_document);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 711);
            this.MinimumSize = new System.Drawing.Size(692, 711);
            this.Name = "Form_DocStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_DocStock_FormClosed);
            this.Load += new System.EventHandler(this.Form_DocStock_Load);
            this.grp_document.ResumeLayout(false);
            this.grp_document.PerformLayout();
            this.grp_type.ResumeLayout(false);
            this.grp_type.PerformLayout();
            this.grp_action.ResumeLayout(false);
            this.grp_contenu.ResumeLayout(false);
            this.grp_contenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).EndInit();
            this.grp_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_document;
        private System.Windows.Forms.GroupBox grp_type;
        private System.Windows.Forms.RadioButton rbtn_sortie;
        private System.Windows.Forms.RadioButton rbtn_entree;
        private System.Windows.Forms.Label lb_datesave;
        private System.Windows.Forms.Label lb_reference;
        private System.Windows.Forms.GroupBox grp_action;
        private System.Windows.Forms.GroupBox grp_contenu;
        private System.Windows.Forms.GroupBox grp_liste;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.DateTimePicker date_save;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search_art;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown txt_prix;
        private System.Windows.Forms.NumericUpDown txt_qte;
        private System.Windows.Forms.ComboBox com_article;
        private System.Windows.Forms.Label lb_qte;
        private System.Windows.Forms.Label lb_article;
        private System.Windows.Forms.Label lb_prix;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_contenu;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewImageColumn icon_;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_;
        private System.Windows.Forms.DataGridViewTextBoxColumn supp_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _supp_;
    }
}