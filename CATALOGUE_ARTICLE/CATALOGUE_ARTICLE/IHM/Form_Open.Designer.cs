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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.box_article = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.box_famille = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.box_catalogue = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_name_form = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_stock = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.box_mouv = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.box_inventaire = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.box_doc = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.box_setting = new System.Windows.Forms.PictureBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.box_acces = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.box_users = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_article)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_famille)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_catalogue)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_stock.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_mouv)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_inventaire)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_doc)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_setting)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_acces)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Articles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.box_article);
            this.groupBox3.Location = new System.Drawing.Point(360, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 141);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articles";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.box_famille);
            this.groupBox4.Location = new System.Drawing.Point(181, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 141);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Familles Article";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.box_catalogue);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 141);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catalogue Article";
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
            this.panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // grp_stock
            // 
            this.grp_stock.Controls.Add(this.groupBox6);
            this.grp_stock.Controls.Add(this.groupBox7);
            this.grp_stock.Controls.Add(this.groupBox8);
            this.grp_stock.Location = new System.Drawing.Point(12, 184);
            this.grp_stock.Name = "grp_stock";
            this.grp_stock.Size = new System.Drawing.Size(516, 166);
            this.grp_stock.TabIndex = 0;
            this.grp_stock.TabStop = false;
            this.grp_stock.Text = "Gestion Stock";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.box_mouv);
            this.groupBox6.Location = new System.Drawing.Point(360, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 141);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mouvement Stock";
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.box_inventaire);
            this.groupBox7.Location = new System.Drawing.Point(181, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 141);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Inventaire";
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.box_doc);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(149, 141);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Document Stock";
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox12);
            this.groupBox9.Location = new System.Drawing.Point(12, 356);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(516, 166);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gestion Users";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.box_setting);
            this.groupBox10.Location = new System.Drawing.Point(360, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(149, 141);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Paramètres";
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
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.box_acces);
            this.groupBox11.Location = new System.Drawing.Point(181, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(149, 141);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Autorisation";
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
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.box_users);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(149, 141);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Utilisateurs";
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
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(535, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.grp_stock);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 607);
            this.MinimumSize = new System.Drawing.Size(551, 607);
            this.Name = "Form_Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouvrir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Open_FormClosed);
            this.Load += new System.EventHandler(this.Form_Open_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_article)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_famille)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_catalogue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_stock.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_mouv)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_inventaire)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_doc)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_setting)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_acces)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox box_catalogue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox box_article;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox box_famille;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_name_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_stock;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox box_mouv;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox box_inventaire;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox box_doc;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox box_setting;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox box_acces;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox box_users;
    }
}