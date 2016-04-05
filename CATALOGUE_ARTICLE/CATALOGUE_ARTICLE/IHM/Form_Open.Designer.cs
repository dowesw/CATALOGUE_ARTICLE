namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Open
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Open));
            this.grp_gestion_article = new System.Windows.Forms.GroupBox();
            this.grp_article = new System.Windows.Forms.GroupBox();
            this.box_article = new System.Windows.Forms.PictureBox();
            this.grp_accessoire = new System.Windows.Forms.GroupBox();
            this.box_famille = new System.Windows.Forms.PictureBox();
            this.grp_catalogue = new System.Windows.Forms.GroupBox();
            this.box_catalogue = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_name_form = new System.Windows.Forms.TextBox();
            this.lb_nom = new System.Windows.Forms.Label();
            this.grp_gestion_stock = new System.Windows.Forms.GroupBox();
            this.grp_mouv_stock = new System.Windows.Forms.GroupBox();
            this.box_mouv = new System.Windows.Forms.PictureBox();
            this.grp_inventaire = new System.Windows.Forms.GroupBox();
            this.box_inventaire = new System.Windows.Forms.PictureBox();
            this.grp_doc_stock = new System.Windows.Forms.GroupBox();
            this.box_doc = new System.Windows.Forms.PictureBox();
            this.grp_gestion_user = new System.Windows.Forms.GroupBox();
            this.grp_parametre = new System.Windows.Forms.GroupBox();
            this.box_setting = new System.Windows.Forms.PictureBox();
            this.grp_autorisation = new System.Windows.Forms.GroupBox();
            this.box_acces = new System.Windows.Forms.PictureBox();
            this.grp_users = new System.Windows.Forms.GroupBox();
            this.box_users = new System.Windows.Forms.PictureBox();
            this.grp_gestion_article.SuspendLayout();
            this.grp_article.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_article)).BeginInit();
            this.grp_accessoire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_famille)).BeginInit();
            this.grp_catalogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_catalogue)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_gestion_stock.SuspendLayout();
            this.grp_mouv_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_mouv)).BeginInit();
            this.grp_inventaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_inventaire)).BeginInit();
            this.grp_doc_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_doc)).BeginInit();
            this.grp_gestion_user.SuspendLayout();
            this.grp_parametre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_setting)).BeginInit();
            this.grp_autorisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_acces)).BeginInit();
            this.grp_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_gestion_article
            // 
            this.grp_gestion_article.Controls.Add(this.grp_article);
            this.grp_gestion_article.Controls.Add(this.grp_accessoire);
            this.grp_gestion_article.Controls.Add(this.grp_catalogue);
            this.grp_gestion_article.Location = new System.Drawing.Point(12, 12);
            this.grp_gestion_article.Name = "grp_gestion_article";
            this.grp_gestion_article.Size = new System.Drawing.Size(516, 166);
            this.grp_gestion_article.TabIndex = 0;
            this.grp_gestion_article.TabStop = false;
            this.grp_gestion_article.Text = "Gestion Articles";
            // 
            // grp_article
            // 
            this.grp_article.Controls.Add(this.box_article);
            this.grp_article.Location = new System.Drawing.Point(360, 19);
            this.grp_article.Name = "grp_article";
            this.grp_article.Size = new System.Drawing.Size(149, 141);
            this.grp_article.TabIndex = 0;
            this.grp_article.TabStop = false;
            this.grp_article.Text = "Articles";
            // 
            // box_article
            // 
            this.box_article.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_article.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_article.Image = global::CATALOGUE_ARTICLE.Properties.Resources.article;
            this.box_article.Location = new System.Drawing.Point(3, 16);
            this.box_article.Name = "box_article";
            this.box_article.Size = new System.Drawing.Size(143, 122);
            this.box_article.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_article.TabIndex = 1;
            this.box_article.TabStop = false;
            this.box_article.Click += new System.EventHandler(this.pic_article_Click);
            this.box_article.DoubleClick += new System.EventHandler(this.pic_article_DoubleClick);
            // 
            // grp_accessoire
            // 
            this.grp_accessoire.Controls.Add(this.box_famille);
            this.grp_accessoire.Location = new System.Drawing.Point(181, 19);
            this.grp_accessoire.Name = "grp_accessoire";
            this.grp_accessoire.Size = new System.Drawing.Size(149, 141);
            this.grp_accessoire.TabIndex = 0;
            this.grp_accessoire.TabStop = false;
            this.grp_accessoire.Text = "Accessoires Article";
            // 
            // box_famille
            // 
            this.box_famille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_famille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_famille.Image = global::CATALOGUE_ARTICLE.Properties.Resources.famille;
            this.box_famille.Location = new System.Drawing.Point(3, 16);
            this.box_famille.Name = "box_famille";
            this.box_famille.Size = new System.Drawing.Size(143, 122);
            this.box_famille.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_famille.TabIndex = 1;
            this.box_famille.TabStop = false;
            this.box_famille.Click += new System.EventHandler(this.pic_famille_Click);
            this.box_famille.DoubleClick += new System.EventHandler(this.pic_famille_DoubleClick);
            // 
            // grp_catalogue
            // 
            this.grp_catalogue.Controls.Add(this.box_catalogue);
            this.grp_catalogue.Location = new System.Drawing.Point(6, 19);
            this.grp_catalogue.Name = "grp_catalogue";
            this.grp_catalogue.Size = new System.Drawing.Size(149, 141);
            this.grp_catalogue.TabIndex = 0;
            this.grp_catalogue.TabStop = false;
            this.grp_catalogue.Text = "Catalogue Article";
            // 
            // box_catalogue
            // 
            this.box_catalogue.BackColor = System.Drawing.SystemColors.Control;
            this.box_catalogue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_catalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_catalogue.Image = global::CATALOGUE_ARTICLE.Properties.Resources.catalogue;
            this.box_catalogue.Location = new System.Drawing.Point(3, 16);
            this.box_catalogue.Name = "box_catalogue";
            this.box_catalogue.Size = new System.Drawing.Size(143, 122);
            this.box_catalogue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_catalogue.TabIndex = 1;
            this.box_catalogue.TabStop = false;
            this.box_catalogue.Click += new System.EventHandler(this.pic_catalogue_Click);
            this.box_catalogue.DoubleClick += new System.EventHandler(this.box_catalogue_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.txt_name_form);
            this.panel1.Controls.Add(this.lb_nom);
            this.panel1.Location = new System.Drawing.Point(-1, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 33);
            this.panel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(438, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(357, 6);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Ouvrir";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_name_form
            // 
            this.txt_name_form.Location = new System.Drawing.Point(51, 8);
            this.txt_name_form.Name = "txt_name_form";
            this.txt_name_form.Size = new System.Drawing.Size(300, 20);
            this.txt_name_form.TabIndex = 1;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(7, 11);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(38, 13);
            this.lb_nom.TabIndex = 0;
            this.lb_nom.Text = "Nom : ";
            // 
            // grp_gestion_stock
            // 
            this.grp_gestion_stock.Controls.Add(this.grp_mouv_stock);
            this.grp_gestion_stock.Controls.Add(this.grp_inventaire);
            this.grp_gestion_stock.Controls.Add(this.grp_doc_stock);
            this.grp_gestion_stock.Location = new System.Drawing.Point(12, 184);
            this.grp_gestion_stock.Name = "grp_gestion_stock";
            this.grp_gestion_stock.Size = new System.Drawing.Size(516, 166);
            this.grp_gestion_stock.TabIndex = 0;
            this.grp_gestion_stock.TabStop = false;
            this.grp_gestion_stock.Text = "Gestion Stock";
            // 
            // grp_mouv_stock
            // 
            this.grp_mouv_stock.Controls.Add(this.box_mouv);
            this.grp_mouv_stock.Location = new System.Drawing.Point(360, 19);
            this.grp_mouv_stock.Name = "grp_mouv_stock";
            this.grp_mouv_stock.Size = new System.Drawing.Size(149, 141);
            this.grp_mouv_stock.TabIndex = 0;
            this.grp_mouv_stock.TabStop = false;
            this.grp_mouv_stock.Text = "Mouvement Stock";
            // 
            // box_mouv
            // 
            this.box_mouv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_mouv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_mouv.Image = global::CATALOGUE_ARTICLE.Properties.Resources.mouvement;
            this.box_mouv.Location = new System.Drawing.Point(3, 16);
            this.box_mouv.Name = "box_mouv";
            this.box_mouv.Size = new System.Drawing.Size(143, 122);
            this.box_mouv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_mouv.TabIndex = 1;
            this.box_mouv.TabStop = false;
            this.box_mouv.Click += new System.EventHandler(this.box_mouv_Click);
            this.box_mouv.DoubleClick += new System.EventHandler(this.box_mouv_DoubleClick);
            // 
            // grp_inventaire
            // 
            this.grp_inventaire.Controls.Add(this.box_inventaire);
            this.grp_inventaire.Location = new System.Drawing.Point(181, 19);
            this.grp_inventaire.Name = "grp_inventaire";
            this.grp_inventaire.Size = new System.Drawing.Size(149, 141);
            this.grp_inventaire.TabIndex = 0;
            this.grp_inventaire.TabStop = false;
            this.grp_inventaire.Text = "Inventaire";
            this.grp_inventaire.Visible = false;
            // 
            // box_inventaire
            // 
            this.box_inventaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_inventaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_inventaire.Image = global::CATALOGUE_ARTICLE.Properties.Resources.inventaire;
            this.box_inventaire.Location = new System.Drawing.Point(3, 16);
            this.box_inventaire.Name = "box_inventaire";
            this.box_inventaire.Size = new System.Drawing.Size(143, 122);
            this.box_inventaire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_inventaire.TabIndex = 1;
            this.box_inventaire.TabStop = false;
            this.box_inventaire.Click += new System.EventHandler(this.box_inventaire_Click);
            this.box_inventaire.DoubleClick += new System.EventHandler(this.box_inventaire_DoubleClick);
            // 
            // grp_doc_stock
            // 
            this.grp_doc_stock.Controls.Add(this.box_doc);
            this.grp_doc_stock.Location = new System.Drawing.Point(6, 19);
            this.grp_doc_stock.Name = "grp_doc_stock";
            this.grp_doc_stock.Size = new System.Drawing.Size(149, 141);
            this.grp_doc_stock.TabIndex = 0;
            this.grp_doc_stock.TabStop = false;
            this.grp_doc_stock.Text = "Document Stock";
            // 
            // box_doc
            // 
            this.box_doc.BackColor = System.Drawing.SystemColors.Control;
            this.box_doc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_doc.Image = global::CATALOGUE_ARTICLE.Properties.Resources.document;
            this.box_doc.Location = new System.Drawing.Point(3, 16);
            this.box_doc.Name = "box_doc";
            this.box_doc.Size = new System.Drawing.Size(143, 122);
            this.box_doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_doc.TabIndex = 1;
            this.box_doc.TabStop = false;
            this.box_doc.Click += new System.EventHandler(this.box_doc_Click);
            this.box_doc.DoubleClick += new System.EventHandler(this.box_doc_DoubleClick);
            // 
            // grp_gestion_user
            // 
            this.grp_gestion_user.Controls.Add(this.grp_parametre);
            this.grp_gestion_user.Controls.Add(this.grp_autorisation);
            this.grp_gestion_user.Controls.Add(this.grp_users);
            this.grp_gestion_user.Location = new System.Drawing.Point(12, 356);
            this.grp_gestion_user.Name = "grp_gestion_user";
            this.grp_gestion_user.Size = new System.Drawing.Size(516, 166);
            this.grp_gestion_user.TabIndex = 0;
            this.grp_gestion_user.TabStop = false;
            this.grp_gestion_user.Text = "Gestion users";
            // 
            // grp_parametre
            // 
            this.grp_parametre.Controls.Add(this.box_setting);
            this.grp_parametre.Location = new System.Drawing.Point(360, 19);
            this.grp_parametre.Name = "grp_parametre";
            this.grp_parametre.Size = new System.Drawing.Size(149, 141);
            this.grp_parametre.TabIndex = 0;
            this.grp_parametre.TabStop = false;
            this.grp_parametre.Text = "Paramètres";
            // 
            // box_setting
            // 
            this.box_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_setting.Image = global::CATALOGUE_ARTICLE.Properties.Resources.settings;
            this.box_setting.Location = new System.Drawing.Point(3, 16);
            this.box_setting.Name = "box_setting";
            this.box_setting.Size = new System.Drawing.Size(143, 122);
            this.box_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_setting.TabIndex = 1;
            this.box_setting.TabStop = false;
            this.box_setting.Click += new System.EventHandler(this.box_setting_Click);
            this.box_setting.DoubleClick += new System.EventHandler(this.box_setting_DoubleClick);
            // 
            // grp_autorisation
            // 
            this.grp_autorisation.Controls.Add(this.box_acces);
            this.grp_autorisation.Location = new System.Drawing.Point(181, 19);
            this.grp_autorisation.Name = "grp_autorisation";
            this.grp_autorisation.Size = new System.Drawing.Size(149, 141);
            this.grp_autorisation.TabIndex = 0;
            this.grp_autorisation.TabStop = false;
            this.grp_autorisation.Text = "Autorisation";
            // 
            // box_acces
            // 
            this.box_acces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_acces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_acces.Image = global::CATALOGUE_ARTICLE.Properties.Resources.acces;
            this.box_acces.Location = new System.Drawing.Point(3, 16);
            this.box_acces.Name = "box_acces";
            this.box_acces.Size = new System.Drawing.Size(143, 122);
            this.box_acces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_acces.TabIndex = 1;
            this.box_acces.TabStop = false;
            this.box_acces.Click += new System.EventHandler(this.box_acces_Click);
            this.box_acces.DoubleClick += new System.EventHandler(this.box_acces_DoubleClick);
            // 
            // grp_users
            // 
            this.grp_users.Controls.Add(this.box_users);
            this.grp_users.Location = new System.Drawing.Point(6, 19);
            this.grp_users.Name = "grp_users";
            this.grp_users.Size = new System.Drawing.Size(149, 141);
            this.grp_users.TabIndex = 0;
            this.grp_users.TabStop = false;
            this.grp_users.Text = "Utilisateurs";
            // 
            // box_users
            // 
            this.box_users.BackColor = System.Drawing.SystemColors.Control;
            this.box_users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_users.Image = global::CATALOGUE_ARTICLE.Properties.Resources.users;
            this.box_users.Location = new System.Drawing.Point(3, 16);
            this.box_users.Name = "box_users";
            this.box_users.Size = new System.Drawing.Size(143, 122);
            this.box_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_users.TabIndex = 1;
            this.box_users.TabStop = false;
            this.box_users.Click += new System.EventHandler(this.box_users_Click);
            this.box_users.DoubleClick += new System.EventHandler(this.box_users_DoubleClick);
            // 
            // Form_Open
            // 
            this.AcceptButton = this.btn_open;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(535, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_gestion_user);
            this.Controls.Add(this.grp_gestion_stock);
            this.Controls.Add(this.grp_gestion_article);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 607);
            this.MinimumSize = new System.Drawing.Size(551, 607);
            this.Name = "Form_Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouvrir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Open_FormClosed);
            this.Load += new System.EventHandler(this.Form_Open_Load);
            this.grp_gestion_article.ResumeLayout(false);
            this.grp_article.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_article)).EndInit();
            this.grp_accessoire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_famille)).EndInit();
            this.grp_catalogue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_catalogue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_gestion_stock.ResumeLayout(false);
            this.grp_mouv_stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_mouv)).EndInit();
            this.grp_inventaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_inventaire)).EndInit();
            this.grp_doc_stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_doc)).EndInit();
            this.grp_gestion_user.ResumeLayout(false);
            this.grp_parametre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_setting)).EndInit();
            this.grp_autorisation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_acces)).EndInit();
            this.grp_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_gestion_article;
        private System.Windows.Forms.GroupBox grp_catalogue;
        private System.Windows.Forms.PictureBox box_catalogue;
        private System.Windows.Forms.GroupBox grp_article;
        private System.Windows.Forms.PictureBox box_article;
        private System.Windows.Forms.GroupBox grp_accessoire;
        private System.Windows.Forms.PictureBox box_famille;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_name_form;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.GroupBox grp_gestion_stock;
        private System.Windows.Forms.GroupBox grp_mouv_stock;
        private System.Windows.Forms.PictureBox box_mouv;
        private System.Windows.Forms.GroupBox grp_inventaire;
        private System.Windows.Forms.PictureBox box_inventaire;
        private System.Windows.Forms.GroupBox grp_doc_stock;
        private System.Windows.Forms.PictureBox box_doc;
        private System.Windows.Forms.GroupBox grp_gestion_user;
        private System.Windows.Forms.GroupBox grp_parametre;
        private System.Windows.Forms.PictureBox box_setting;
        private System.Windows.Forms.GroupBox grp_autorisation;
        private System.Windows.Forms.PictureBox box_acces;
        private System.Windows.Forms.GroupBox grp_users;
        private System.Windows.Forms.PictureBox box_users;
    }
}