namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Users));
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_infos = new System.Windows.Forms.GroupBox();
            this.chk_actif = new System.Windows.Forms.CheckBox();
            this.txt_repassword = new System.Windows.Forms.MaskedTextBox();
            this.txt_password = new System.Windows.Forms.MaskedTextBox();
            this.com_niveau = new System.Windows.Forms.ComboBox();
            this.txt_identifiant = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.grp_photo = new System.Windows.Forms.GroupBox();
            this.lk_box_photo = new System.Windows.Forms.LinkLabel();
            this.box_photo = new System.Windows.Forms.PictureBox();
            this.lb_actif = new System.Windows.Forms.Label();
            this.lb_niveau = new System.Windows.Forms.Label();
            this.lb_confirme = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_identifiant = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.grp_liste = new System.Windows.Forms.GroupBox();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actif_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_action.SuspendLayout();
            this.grp_infos.SuspendLayout();
            this.grp_photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).BeginInit();
            this.grp_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.grp_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.btn_delete);
            this.grp_action.Controls.Add(this.btn_cancel);
            this.grp_action.Controls.Add(this.btn_save);
            this.grp_action.Location = new System.Drawing.Point(506, 12);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(113, 133);
            this.grp_action.TabIndex = 0;
            this.grp_action.TabStop = false;
            this.grp_action.Text = "Actions";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::CATALOGUE_ARTICLE.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(20, 91);
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
            this.btn_cancel.Location = new System.Drawing.Point(20, 55);
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
            this.btn_save.Location = new System.Drawing.Point(18, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grp_infos
            // 
            this.grp_infos.Controls.Add(this.chk_actif);
            this.grp_infos.Controls.Add(this.txt_repassword);
            this.grp_infos.Controls.Add(this.txt_password);
            this.grp_infos.Controls.Add(this.com_niveau);
            this.grp_infos.Controls.Add(this.txt_identifiant);
            this.grp_infos.Controls.Add(this.txt_prenom);
            this.grp_infos.Controls.Add(this.txt_nom);
            this.grp_infos.Controls.Add(this.grp_photo);
            this.grp_infos.Controls.Add(this.lb_actif);
            this.grp_infos.Controls.Add(this.lb_niveau);
            this.grp_infos.Controls.Add(this.lb_confirme);
            this.grp_infos.Controls.Add(this.lb_password);
            this.grp_infos.Controls.Add(this.lb_identifiant);
            this.grp_infos.Controls.Add(this.lb_prenom);
            this.grp_infos.Controls.Add(this.lb_nom);
            this.grp_infos.Location = new System.Drawing.Point(12, 12);
            this.grp_infos.Name = "grp_infos";
            this.grp_infos.Size = new System.Drawing.Size(488, 251);
            this.grp_infos.TabIndex = 1;
            this.grp_infos.TabStop = false;
            this.grp_infos.Text = "Informations";
            // 
            // chk_actif
            // 
            this.chk_actif.AutoSize = true;
            this.chk_actif.Location = new System.Drawing.Point(116, 219);
            this.chk_actif.Name = "chk_actif";
            this.chk_actif.Size = new System.Drawing.Size(15, 14);
            this.chk_actif.TabIndex = 15;
            this.chk_actif.UseVisualStyleBackColor = true;
            // 
            // txt_repassword
            // 
            this.txt_repassword.Location = new System.Drawing.Point(116, 150);
            this.txt_repassword.Name = "txt_repassword";
            this.txt_repassword.PasswordChar = '*';
            this.txt_repassword.Size = new System.Drawing.Size(209, 20);
            this.txt_repassword.TabIndex = 13;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(116, 117);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(209, 20);
            this.txt_password.TabIndex = 12;
            // 
            // com_niveau
            // 
            this.com_niveau.FormattingEnabled = true;
            this.com_niveau.Location = new System.Drawing.Point(116, 183);
            this.com_niveau.Name = "com_niveau";
            this.com_niveau.Size = new System.Drawing.Size(209, 21);
            this.com_niveau.TabIndex = 14;
            this.com_niveau.SelectedIndexChanged += new System.EventHandler(this.com_niveau_SelectedIndexChanged);
            // 
            // txt_identifiant
            // 
            this.txt_identifiant.Location = new System.Drawing.Point(117, 84);
            this.txt_identifiant.Name = "txt_identifiant";
            this.txt_identifiant.Size = new System.Drawing.Size(208, 20);
            this.txt_identifiant.TabIndex = 11;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(117, 56);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(208, 20);
            this.txt_prenom.TabIndex = 10;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(117, 25);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(208, 20);
            this.txt_nom.TabIndex = 9;
            // 
            // grp_photo
            // 
            this.grp_photo.Controls.Add(this.lk_box_photo);
            this.grp_photo.Controls.Add(this.box_photo);
            this.grp_photo.Location = new System.Drawing.Point(348, 19);
            this.grp_photo.Name = "grp_photo";
            this.grp_photo.Size = new System.Drawing.Size(121, 126);
            this.grp_photo.TabIndex = 7;
            this.grp_photo.TabStop = false;
            this.grp_photo.Text = "Photo";
            // 
            // lk_box_photo
            // 
            this.lk_box_photo.AutoSize = true;
            this.lk_box_photo.BackColor = System.Drawing.Color.Transparent;
            this.lk_box_photo.Location = new System.Drawing.Point(60, 105);
            this.lk_box_photo.Name = "lk_box_photo";
            this.lk_box_photo.Size = new System.Drawing.Size(54, 13);
            this.lk_box_photo.TabIndex = 1;
            this.lk_box_photo.TabStop = true;
            this.lk_box_photo.Text = "Supprimer";
            this.lk_box_photo.Visible = false;
            this.lk_box_photo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_box_photo_LinkClicked);
            // 
            // box_photo
            // 
            this.box_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            this.box_photo.Location = new System.Drawing.Point(3, 16);
            this.box_photo.Name = "box_photo";
            this.box_photo.Size = new System.Drawing.Size(115, 107);
            this.box_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_photo.TabIndex = 0;
            this.box_photo.TabStop = false;
            this.box_photo.Tag = "false";
            this.box_photo.DoubleClick += new System.EventHandler(this.box_photo_DoubleClick);
            // 
            // lb_actif
            // 
            this.lb_actif.AutoSize = true;
            this.lb_actif.Location = new System.Drawing.Point(27, 220);
            this.lb_actif.Name = "lb_actif";
            this.lb_actif.Size = new System.Drawing.Size(37, 13);
            this.lb_actif.TabIndex = 6;
            this.lb_actif.Text = "Actif : ";
            // 
            // lb_niveau
            // 
            this.lb_niveau.AutoSize = true;
            this.lb_niveau.Location = new System.Drawing.Point(27, 186);
            this.lb_niveau.Name = "lb_niveau";
            this.lb_niveau.Size = new System.Drawing.Size(83, 13);
            this.lb_niveau.TabIndex = 5;
            this.lb_niveau.Text = "Niveau Acces : ";
            // 
            // lb_confirme
            // 
            this.lb_confirme.AutoSize = true;
            this.lb_confirme.Location = new System.Drawing.Point(27, 153);
            this.lb_confirme.Name = "lb_confirme";
            this.lb_confirme.Size = new System.Drawing.Size(60, 13);
            this.lb_confirme.TabIndex = 4;
            this.lb_confirme.Text = "Confirmer : ";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(27, 120);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(66, 13);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Mot Passe : ";
            // 
            // lb_identifiant
            // 
            this.lb_identifiant.AutoSize = true;
            this.lb_identifiant.Location = new System.Drawing.Point(27, 87);
            this.lb_identifiant.Name = "lb_identifiant";
            this.lb_identifiant.Size = new System.Drawing.Size(62, 13);
            this.lb_identifiant.TabIndex = 2;
            this.lb_identifiant.Text = "Identifiant : ";
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(27, 59);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(52, 13);
            this.lb_prenom.TabIndex = 1;
            this.lb_prenom.Text = "Prénom : ";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(27, 28);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(38, 13);
            this.lb_nom.TabIndex = 0;
            this.lb_nom.Text = "Nom : ";
            // 
            // grp_liste
            // 
            this.grp_liste.Controls.Add(this.dgv_liste);
            this.grp_liste.Location = new System.Drawing.Point(12, 269);
            this.grp_liste.Name = "grp_liste";
            this.grp_liste.Size = new System.Drawing.Size(607, 239);
            this.grp_liste.TabIndex = 2;
            this.grp_liste.TabStop = false;
            this.grp_liste.Text = "Liste";
            // 
            // dgv_liste
            // 
            this.dgv_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.nom_,
            this.prenom_,
            this.niveau_,
            this.actif_,
            this.supp_});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(3, 16);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(601, 220);
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
            // nom_
            // 
            this.nom_.FillWeight = 147.6769F;
            this.nom_.HeaderText = "Noms";
            this.nom_.Name = "nom_";
            this.nom_.ReadOnly = true;
            // 
            // prenom_
            // 
            this.prenom_.FillWeight = 147.6769F;
            this.prenom_.HeaderText = "Prénoms";
            this.prenom_.Name = "prenom_";
            this.prenom_.ReadOnly = true;
            // 
            // niveau_
            // 
            this.niveau_.FillWeight = 147.6769F;
            this.niveau_.HeaderText = "Niveau Acces";
            this.niveau_.Name = "niveau_";
            this.niveau_.ReadOnly = true;
            // 
            // actif_
            // 
            this.actif_.FillWeight = 35.38071F;
            this.actif_.HeaderText = "Actif";
            this.actif_.Name = "actif_";
            this.actif_.ReadOnly = true;
            // 
            // supp_
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            this.supp_.DefaultCellStyle = dataGridViewCellStyle1;
            this.supp_.FillWeight = 31.58864F;
            this.supp_.HeaderText = "";
            this.supp_.Name = "supp_";
            this.supp_.ReadOnly = true;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Location = new System.Drawing.Point(12, 514);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(607, 48);
            this.grp_search.TabIndex = 3;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(54, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(442, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Form_Users
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(624, 562);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.grp_liste);
            this.Controls.Add(this.grp_infos);
            this.Controls.Add(this.grp_action);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 601);
            this.MinimumSize = new System.Drawing.Size(640, 601);
            this.Name = "Form_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilisateur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Users_FormClosed);
            this.Load += new System.EventHandler(this.Form_Users_Load);
            this.grp_action.ResumeLayout(false);
            this.grp_infos.ResumeLayout(false);
            this.grp_infos.PerformLayout();
            this.grp_photo.ResumeLayout(false);
            this.grp_photo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).EndInit();
            this.grp_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_action;
        private System.Windows.Forms.GroupBox grp_infos;
        private System.Windows.Forms.Label lb_actif;
        private System.Windows.Forms.Label lb_niveau;
        private System.Windows.Forms.Label lb_confirme;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_identifiant;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.GroupBox grp_liste;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.GroupBox grp_photo;
        private System.Windows.Forms.PictureBox box_photo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.MaskedTextBox txt_password;
        private System.Windows.Forms.ComboBox com_niveau;
        private System.Windows.Forms.TextBox txt_identifiant;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.CheckBox chk_actif;
        private System.Windows.Forms.MaskedTextBox txt_repassword;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.LinkLabel lk_box_photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actif_;
        private System.Windows.Forms.DataGridViewTextBoxColumn supp_;
    }
}