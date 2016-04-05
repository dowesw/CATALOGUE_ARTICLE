namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Accessoire_Article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accessoire_Article));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_famille = new System.Windows.Forms.TabPage();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_infos = new System.Windows.Forms.GroupBox();
            this.com_parent = new System.Windows.Forms.ComboBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_parent = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.lb_reference = new System.Windows.Forms.Label();
            this.grp_liste = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tab_marque = new System.Windows.Forms.TabPage();
            this.grp_search1 = new System.Windows.Forms.GroupBox();
            this.txt_search_ = new System.Windows.Forms.TextBox();
            this.grp_infos1 = new System.Windows.Forms.GroupBox();
            this.txt_description_ = new System.Windows.Forms.RichTextBox();
            this.lb_description1 = new System.Windows.Forms.Label();
            this.txt_designation_ = new System.Windows.Forms.TextBox();
            this.txt_reference_ = new System.Windows.Forms.TextBox();
            this.lb_designation1 = new System.Windows.Forms.Label();
            this.lb_reference1 = new System.Windows.Forms.Label();
            this.grp_liste1 = new System.Windows.Forms.GroupBox();
            this.dgv_liste_ = new System.Windows.Forms.DataGridView();
            this._id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._description_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._supp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_action1 = new System.Windows.Forms.GroupBox();
            this.btn_delete_ = new System.Windows.Forms.Button();
            this.btn_cancel_ = new System.Windows.Forms.Button();
            this.btn_save_ = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_famille.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.grp_infos.SuspendLayout();
            this.grp_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.grp_action.SuspendLayout();
            this.tab_marque.SuspendLayout();
            this.grp_search1.SuspendLayout();
            this.grp_infos1.SuspendLayout();
            this.grp_liste1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_)).BeginInit();
            this.grp_action1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_famille);
            this.tabControl.Controls.Add(this.tab_marque);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(562, 516);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_famille
            // 
            this.tab_famille.Controls.Add(this.grp_search);
            this.tab_famille.Controls.Add(this.grp_infos);
            this.tab_famille.Controls.Add(this.grp_liste);
            this.tab_famille.Controls.Add(this.grp_action);
            this.tab_famille.Location = new System.Drawing.Point(4, 22);
            this.tab_famille.Name = "tab_famille";
            this.tab_famille.Padding = new System.Windows.Forms.Padding(3);
            this.tab_famille.Size = new System.Drawing.Size(554, 490);
            this.tab_famille.TabIndex = 0;
            this.tab_famille.Text = "Familles Article";
            this.tab_famille.UseVisualStyleBackColor = true;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Location = new System.Drawing.Point(6, 444);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(543, 41);
            this.grp_search.TabIndex = 3;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(19, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(507, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // grp_infos
            // 
            this.grp_infos.Controls.Add(this.com_parent);
            this.grp_infos.Controls.Add(this.txt_designation);
            this.grp_infos.Controls.Add(this.txt_reference);
            this.grp_infos.Controls.Add(this.txt_description);
            this.grp_infos.Controls.Add(this.lb_description);
            this.grp_infos.Controls.Add(this.lb_parent);
            this.grp_infos.Controls.Add(this.lb_designation);
            this.grp_infos.Controls.Add(this.lb_reference);
            this.grp_infos.Location = new System.Drawing.Point(6, 6);
            this.grp_infos.Name = "grp_infos";
            this.grp_infos.Size = new System.Drawing.Size(431, 207);
            this.grp_infos.TabIndex = 4;
            this.grp_infos.TabStop = false;
            this.grp_infos.Text = "Informations";
            // 
            // com_parent
            // 
            this.com_parent.FormattingEnabled = true;
            this.com_parent.Location = new System.Drawing.Point(94, 85);
            this.com_parent.Name = "com_parent";
            this.com_parent.Size = new System.Drawing.Size(138, 21);
            this.com_parent.TabIndex = 4;
            this.com_parent.SelectedIndexChanged += new System.EventHandler(this.com_parent_SelectedIndexChanged);
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(94, 53);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(257, 20);
            this.txt_designation.TabIndex = 2;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(94, 23);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(190, 20);
            this.txt_reference.TabIndex = 1;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(19, 131);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(397, 66);
            this.txt_description.TabIndex = 3;
            this.txt_description.Text = "";
            this.txt_description.Enter += new System.EventHandler(this.txt_description_Enter);
            this.txt_description.Leave += new System.EventHandler(this.txt_description_Leave);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(16, 115);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(69, 13);
            this.lb_description.TabIndex = 0;
            this.lb_description.Text = "Déscription : ";
            // 
            // lb_parent
            // 
            this.lb_parent.AutoSize = true;
            this.lb_parent.Location = new System.Drawing.Point(16, 88);
            this.lb_parent.Name = "lb_parent";
            this.lb_parent.Size = new System.Drawing.Size(47, 13);
            this.lb_parent.TabIndex = 0;
            this.lb_parent.Text = "Parent : ";
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(16, 56);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 0;
            this.lb_designation.Text = "Désignation : ";
            // 
            // lb_reference
            // 
            this.lb_reference.AutoSize = true;
            this.lb_reference.Location = new System.Drawing.Point(16, 26);
            this.lb_reference.Name = "lb_reference";
            this.lb_reference.Size = new System.Drawing.Size(66, 13);
            this.lb_reference.TabIndex = 0;
            this.lb_reference.Text = "Réference : ";
            // 
            // grp_liste
            // 
            this.grp_liste.Controls.Add(this.dgv_liste);
            this.grp_liste.Location = new System.Drawing.Point(6, 219);
            this.grp_liste.Name = "grp_liste";
            this.grp_liste.Size = new System.Drawing.Size(543, 219);
            this.grp_liste.TabIndex = 5;
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
            this.parent_,
            this.description_,
            this.supp});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(537, 200);
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
            // reference_
            // 
            this.reference_.FillWeight = 126.5651F;
            this.reference_.HeaderText = "Réference";
            this.reference_.Name = "reference_";
            this.reference_.ReadOnly = true;
            // 
            // designation_
            // 
            this.designation_.FillWeight = 126.5651F;
            this.designation_.HeaderText = "Désignation";
            this.designation_.Name = "designation_";
            this.designation_.ReadOnly = true;
            // 
            // parent_
            // 
            this.parent_.HeaderText = "Parent";
            this.parent_.Name = "parent_";
            this.parent_.ReadOnly = true;
            // 
            // description_
            // 
            this.description_.FillWeight = 126.5651F;
            this.description_.HeaderText = "Déscription";
            this.description_.Name = "description_";
            this.description_.ReadOnly = true;
            // 
            // supp
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            this.supp.DefaultCellStyle = dataGridViewCellStyle1;
            this.supp.FillWeight = 20.30457F;
            this.supp.HeaderText = "";
            this.supp.Name = "supp";
            this.supp.ReadOnly = true;
            this.supp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.btn_delete);
            this.grp_action.Controls.Add(this.btn_cancel);
            this.grp_action.Controls.Add(this.btn_save);
            this.grp_action.Location = new System.Drawing.Point(443, 6);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(106, 207);
            this.grp_action.TabIndex = 2;
            this.grp_action.TabStop = false;
            this.grp_action.Text = "Actions";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(14, 90);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "   Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::CATALOGUE_ARTICLE.Properties.Resources.cancel;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(14, 56);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "    Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(14, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tab_marque
            // 
            this.tab_marque.Controls.Add(this.grp_search1);
            this.tab_marque.Controls.Add(this.grp_infos1);
            this.tab_marque.Controls.Add(this.grp_liste1);
            this.tab_marque.Controls.Add(this.grp_action1);
            this.tab_marque.Location = new System.Drawing.Point(4, 22);
            this.tab_marque.Name = "tab_marque";
            this.tab_marque.Padding = new System.Windows.Forms.Padding(3);
            this.tab_marque.Size = new System.Drawing.Size(554, 490);
            this.tab_marque.TabIndex = 1;
            this.tab_marque.Text = "Marques Article";
            this.tab_marque.UseVisualStyleBackColor = true;
            // 
            // grp_search1
            // 
            this.grp_search1.Controls.Add(this.txt_search_);
            this.grp_search1.Location = new System.Drawing.Point(6, 444);
            this.grp_search1.Name = "grp_search1";
            this.grp_search1.Size = new System.Drawing.Size(543, 41);
            this.grp_search1.TabIndex = 7;
            this.grp_search1.TabStop = false;
            this.grp_search1.Text = "Recherche";
            // 
            // txt_search_
            // 
            this.txt_search_.Location = new System.Drawing.Point(19, 15);
            this.txt_search_.Name = "txt_search_";
            this.txt_search_.Size = new System.Drawing.Size(507, 20);
            this.txt_search_.TabIndex = 0;
            this.txt_search_.TextChanged += new System.EventHandler(this.txt_search__TextChanged);
            // 
            // grp_infos1
            // 
            this.grp_infos1.Controls.Add(this.txt_description_);
            this.grp_infos1.Controls.Add(this.lb_description1);
            this.grp_infos1.Controls.Add(this.txt_designation_);
            this.grp_infos1.Controls.Add(this.txt_reference_);
            this.grp_infos1.Controls.Add(this.lb_designation1);
            this.grp_infos1.Controls.Add(this.lb_reference1);
            this.grp_infos1.Location = new System.Drawing.Point(6, 6);
            this.grp_infos1.Name = "grp_infos1";
            this.grp_infos1.Size = new System.Drawing.Size(431, 207);
            this.grp_infos1.TabIndex = 8;
            this.grp_infos1.TabStop = false;
            this.grp_infos1.Text = "Informations";
            // 
            // txt_description_
            // 
            this.txt_description_.Location = new System.Drawing.Point(19, 102);
            this.txt_description_.Name = "txt_description_";
            this.txt_description_.Size = new System.Drawing.Size(397, 96);
            this.txt_description_.TabIndex = 5;
            this.txt_description_.Text = "";
            this.txt_description_.Enter += new System.EventHandler(this.txt_description__Enter);
            this.txt_description_.Leave += new System.EventHandler(this.txt_description__Leave);
            // 
            // lb_description1
            // 
            this.lb_description1.AutoSize = true;
            this.lb_description1.Location = new System.Drawing.Point(16, 86);
            this.lb_description1.Name = "lb_description1";
            this.lb_description1.Size = new System.Drawing.Size(69, 13);
            this.lb_description1.TabIndex = 4;
            this.lb_description1.Text = "Déscription : ";
            // 
            // txt_designation_
            // 
            this.txt_designation_.Location = new System.Drawing.Point(94, 53);
            this.txt_designation_.Name = "txt_designation_";
            this.txt_designation_.Size = new System.Drawing.Size(257, 20);
            this.txt_designation_.TabIndex = 2;
            // 
            // txt_reference_
            // 
            this.txt_reference_.Location = new System.Drawing.Point(94, 23);
            this.txt_reference_.Name = "txt_reference_";
            this.txt_reference_.Size = new System.Drawing.Size(190, 20);
            this.txt_reference_.TabIndex = 1;
            // 
            // lb_designation1
            // 
            this.lb_designation1.AutoSize = true;
            this.lb_designation1.Location = new System.Drawing.Point(16, 56);
            this.lb_designation1.Name = "lb_designation1";
            this.lb_designation1.Size = new System.Drawing.Size(72, 13);
            this.lb_designation1.TabIndex = 0;
            this.lb_designation1.Text = "Désignation : ";
            // 
            // lb_reference1
            // 
            this.lb_reference1.AutoSize = true;
            this.lb_reference1.Location = new System.Drawing.Point(16, 26);
            this.lb_reference1.Name = "lb_reference1";
            this.lb_reference1.Size = new System.Drawing.Size(66, 13);
            this.lb_reference1.TabIndex = 0;
            this.lb_reference1.Text = "Réference : ";
            // 
            // grp_liste1
            // 
            this.grp_liste1.Controls.Add(this.dgv_liste_);
            this.grp_liste1.Location = new System.Drawing.Point(6, 219);
            this.grp_liste1.Name = "grp_liste1";
            this.grp_liste1.Size = new System.Drawing.Size(543, 219);
            this.grp_liste1.TabIndex = 9;
            this.grp_liste1.TabStop = false;
            this.grp_liste1.Text = "Liste";
            // 
            // dgv_liste_
            // 
            this.dgv_liste_.AllowUserToAddRows = false;
            this.dgv_liste_.AllowUserToDeleteRows = false;
            this.dgv_liste_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_liste_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id_,
            this._reference_,
            this._designation_,
            this._description_,
            this._supp_});
            this.dgv_liste_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste_.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste_.Name = "dgv_liste_";
            this.dgv_liste_.ReadOnly = true;
            this.dgv_liste_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_.Size = new System.Drawing.Size(537, 200);
            this.dgv_liste_.TabIndex = 0;
            this.dgv_liste_.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_liste__CellContentClick);
            this.dgv_liste_.SelectionChanged += new System.EventHandler(this.dgv_liste__SelectionChanged);
            // 
            // _id_
            // 
            this._id_.HeaderText = "ID";
            this._id_.Name = "_id_";
            this._id_.ReadOnly = true;
            this._id_.Visible = false;
            // 
            // _reference_
            // 
            this._reference_.FillWeight = 126.5651F;
            this._reference_.HeaderText = "Réference";
            this._reference_.Name = "_reference_";
            this._reference_.ReadOnly = true;
            // 
            // _designation_
            // 
            this._designation_.FillWeight = 126.5651F;
            this._designation_.HeaderText = "Désignation";
            this._designation_.Name = "_designation_";
            this._designation_.ReadOnly = true;
            // 
            // _description_
            // 
            this._description_.HeaderText = "Description";
            this._description_.Name = "_description_";
            this._description_.ReadOnly = true;
            // 
            // _supp_
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "X";
            this._supp_.DefaultCellStyle = dataGridViewCellStyle2;
            this._supp_.FillWeight = 20.30457F;
            this._supp_.HeaderText = "";
            this._supp_.Name = "_supp_";
            this._supp_.ReadOnly = true;
            this._supp_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._supp_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grp_action1
            // 
            this.grp_action1.Controls.Add(this.btn_delete_);
            this.grp_action1.Controls.Add(this.btn_cancel_);
            this.grp_action1.Controls.Add(this.btn_save_);
            this.grp_action1.Location = new System.Drawing.Point(443, 6);
            this.grp_action1.Name = "grp_action1";
            this.grp_action1.Size = new System.Drawing.Size(106, 207);
            this.grp_action1.TabIndex = 6;
            this.grp_action1.TabStop = false;
            this.grp_action1.Text = "Actions";
            // 
            // btn_delete_
            // 
            this.btn_delete_.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_.Location = new System.Drawing.Point(14, 90);
            this.btn_delete_.Name = "btn_delete_";
            this.btn_delete_.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_.TabIndex = 2;
            this.btn_delete_.Text = "   Delete";
            this.btn_delete_.UseVisualStyleBackColor = true;
            this.btn_delete_.Click += new System.EventHandler(this.btn_delete__Click);
            // 
            // btn_cancel_
            // 
            this.btn_cancel_.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel_.Image = global::CATALOGUE_ARTICLE.Properties.Resources.cancel;
            this.btn_cancel_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel_.Location = new System.Drawing.Point(14, 56);
            this.btn_cancel_.Name = "btn_cancel_";
            this.btn_cancel_.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_.TabIndex = 1;
            this.btn_cancel_.Text = "    Cancel";
            this.btn_cancel_.UseVisualStyleBackColor = true;
            this.btn_cancel_.Click += new System.EventHandler(this.btn_cancel__Click);
            // 
            // btn_save_
            // 
            this.btn_save_.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_.Location = new System.Drawing.Point(14, 21);
            this.btn_save_.Name = "btn_save_";
            this.btn_save_.Size = new System.Drawing.Size(75, 23);
            this.btn_save_.TabIndex = 0;
            this.btn_save_.Text = "  Save";
            this.btn_save_.UseVisualStyleBackColor = true;
            this.btn_save_.Click += new System.EventHandler(this.btn_save__Click);
            // 
            // Form_Accessoire_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 537);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 542);
            this.Name = "Form_Accessoire_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accessoire Article";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Famille_FormClosed);
            this.Load += new System.EventHandler(this.Form_Famille_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_famille.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_infos.ResumeLayout(false);
            this.grp_infos.PerformLayout();
            this.grp_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.grp_action.ResumeLayout(false);
            this.tab_marque.ResumeLayout(false);
            this.grp_search1.ResumeLayout(false);
            this.grp_search1.PerformLayout();
            this.grp_infos1.ResumeLayout(false);
            this.grp_infos1.PerformLayout();
            this.grp_liste1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_)).EndInit();
            this.grp_action1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_famille;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox grp_infos;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.Label lb_reference;
        private System.Windows.Forms.GroupBox grp_liste;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.GroupBox grp_action;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabPage tab_marque;
        private System.Windows.Forms.GroupBox grp_search1;
        private System.Windows.Forms.TextBox txt_search_;
        private System.Windows.Forms.GroupBox grp_infos1;
        private System.Windows.Forms.TextBox txt_designation_;
        private System.Windows.Forms.TextBox txt_reference_;
        private System.Windows.Forms.Label lb_designation1;
        private System.Windows.Forms.Label lb_reference1;
        private System.Windows.Forms.GroupBox grp_liste1;
        private System.Windows.Forms.DataGridView dgv_liste_;
        private System.Windows.Forms.GroupBox grp_action1;
        private System.Windows.Forms.Button btn_delete_;
        private System.Windows.Forms.Button btn_cancel_;
        private System.Windows.Forms.Button btn_save_;
        private System.Windows.Forms.RichTextBox txt_description_;
        private System.Windows.Forms.Label lb_description1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _reference_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _designation_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _description_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _supp_;
        private System.Windows.Forms.ComboBox com_parent;
        private System.Windows.Forms.Label lb_parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation_;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_;
        private System.Windows.Forms.DataGridViewTextBoxColumn supp;

    }
}