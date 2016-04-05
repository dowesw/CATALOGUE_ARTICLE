namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Acces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Acces));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_form = new System.Windows.Forms.TabPage();
            this.dgv_form = new System.Windows.Forms.DataGridView();
            this.id_form_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_form_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_form_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acces_form_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tab_ress = new System.Windows.Forms.TabPage();
            this.dgv_ress = new System.Windows.Forms.DataGridView();
            this.id_ress_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_ress_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ress_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acces_ress_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.com_niveau = new System.Windows.Forms.ComboBox();
            this.lb_niveau = new System.Windows.Forms.Label();
            this.btn_add_niveau = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).BeginInit();
            this.tab_ress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_form);
            this.tabControl1.Controls.Add(this.tab_ress);
            this.tabControl1.Location = new System.Drawing.Point(1, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_form
            // 
            this.tab_form.Controls.Add(this.dgv_form);
            this.tab_form.Location = new System.Drawing.Point(4, 22);
            this.tab_form.Name = "tab_form";
            this.tab_form.Padding = new System.Windows.Forms.Padding(3);
            this.tab_form.Size = new System.Drawing.Size(462, 299);
            this.tab_form.TabIndex = 0;
            this.tab_form.Text = "Formulaires";
            this.tab_form.UseVisualStyleBackColor = true;
            // 
            // dgv_form
            // 
            this.dgv_form.AllowUserToAddRows = false;
            this.dgv_form.AllowUserToDeleteRows = false;
            this.dgv_form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_form.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_form_,
            this.code_form_,
            this.nom_form_,
            this.acces_form_});
            this.dgv_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_form.Location = new System.Drawing.Point(3, 3);
            this.dgv_form.Name = "dgv_form";
            this.dgv_form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_form.Size = new System.Drawing.Size(456, 293);
            this.dgv_form.TabIndex = 0;
            this.dgv_form.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_form_CellEndEdit);
            this.dgv_form.SelectionChanged += new System.EventHandler(this.dgv_form_SelectionChanged);
            // 
            // id_form_
            // 
            this.id_form_.HeaderText = "ID";
            this.id_form_.Name = "id_form_";
            this.id_form_.Visible = false;
            // 
            // code_form_
            // 
            this.code_form_.FillWeight = 134.7715F;
            this.code_form_.HeaderText = "Code";
            this.code_form_.Name = "code_form_";
            this.code_form_.ReadOnly = true;
            // 
            // nom_form_
            // 
            this.nom_form_.FillWeight = 134.7715F;
            this.nom_form_.HeaderText = "Libelle";
            this.nom_form_.Name = "nom_form_";
            this.nom_form_.ReadOnly = true;
            // 
            // acces_form_
            // 
            this.acces_form_.FillWeight = 35.45685F;
            this.acces_form_.HeaderText = "Acces";
            this.acces_form_.Name = "acces_form_";
            // 
            // tab_ress
            // 
            this.tab_ress.Controls.Add(this.dgv_ress);
            this.tab_ress.Location = new System.Drawing.Point(4, 22);
            this.tab_ress.Name = "tab_ress";
            this.tab_ress.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ress.Size = new System.Drawing.Size(462, 299);
            this.tab_ress.TabIndex = 1;
            this.tab_ress.Text = "Ressources";
            this.tab_ress.UseVisualStyleBackColor = true;
            // 
            // dgv_ress
            // 
            this.dgv_ress.AllowUserToAddRows = false;
            this.dgv_ress.AllowUserToDeleteRows = false;
            this.dgv_ress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ress.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_ress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ress_,
            this.code_ress_,
            this.nom_ress_,
            this.acces_ress_});
            this.dgv_ress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ress.Location = new System.Drawing.Point(3, 3);
            this.dgv_ress.Name = "dgv_ress";
            this.dgv_ress.Size = new System.Drawing.Size(456, 293);
            this.dgv_ress.TabIndex = 0;
            this.dgv_ress.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ress_CellEndEdit);
            // 
            // id_ress_
            // 
            this.id_ress_.HeaderText = "ID";
            this.id_ress_.Name = "id_ress_";
            this.id_ress_.Visible = false;
            // 
            // code_ress_
            // 
            this.code_ress_.FillWeight = 134.7715F;
            this.code_ress_.HeaderText = "Code";
            this.code_ress_.Name = "code_ress_";
            this.code_ress_.ReadOnly = true;
            // 
            // nom_ress_
            // 
            this.nom_ress_.FillWeight = 134.7715F;
            this.nom_ress_.HeaderText = "Libelle";
            this.nom_ress_.Name = "nom_ress_";
            this.nom_ress_.ReadOnly = true;
            // 
            // acces_ress_
            // 
            this.acces_ress_.FillWeight = 35.45685F;
            this.acces_ress_.HeaderText = "Acces";
            this.acces_ress_.Name = "acces_ress_";
            this.acces_ress_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acces_ress_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add_niveau);
            this.panel1.Controls.Add(this.com_niveau);
            this.panel1.Controls.Add(this.lb_niveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 29);
            this.panel1.TabIndex = 1;
            // 
            // com_niveau
            // 
            this.com_niveau.FormattingEnabled = true;
            this.com_niveau.Location = new System.Drawing.Point(68, 5);
            this.com_niveau.Name = "com_niveau";
            this.com_niveau.Size = new System.Drawing.Size(176, 21);
            this.com_niveau.TabIndex = 3;
            this.com_niveau.SelectedIndexChanged += new System.EventHandler(this.com_niveau_SelectedIndexChanged);
            // 
            // lb_niveau
            // 
            this.lb_niveau.AutoSize = true;
            this.lb_niveau.Location = new System.Drawing.Point(12, 9);
            this.lb_niveau.Name = "lb_niveau";
            this.lb_niveau.Size = new System.Drawing.Size(50, 13);
            this.lb_niveau.TabIndex = 2;
            this.lb_niveau.Text = "Niveau : ";
            // 
            // btn_add_niveau
            // 
            this.btn_add_niveau.Image = global::CATALOGUE_ARTICLE.Properties.Resources.add;
            this.btn_add_niveau.Location = new System.Drawing.Point(250, 4);
            this.btn_add_niveau.Name = "btn_add_niveau";
            this.btn_add_niveau.Size = new System.Drawing.Size(23, 23);
            this.btn_add_niveau.TabIndex = 44;
            this.btn_add_niveau.UseVisualStyleBackColor = true;
            this.btn_add_niveau.Click += new System.EventHandler(this.btn_add_niveau_Click);
            // 
            // Form_Acces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 404);
            this.MinimumSize = new System.Drawing.Size(487, 404);
            this.Name = "Form_Acces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Acces_FormClosed);
            this.Load += new System.EventHandler(this.Form_Acces_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).EndInit();
            this.tab_ress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_form;
        private System.Windows.Forms.TabPage tab_ress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_form;
        private System.Windows.Forms.DataGridView dgv_ress;
        private System.Windows.Forms.Label lb_niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ress_;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_ress_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ress_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acces_ress_;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_form_;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_form_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_form_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acces_form_;
        public System.Windows.Forms.ComboBox com_niveau;
        private System.Windows.Forms.Button btn_add_niveau;
    }
}