namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Serveur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Serveur));
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_serveur = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_database = new System.Windows.Forms.Label();
            this.lb_users = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(197, 172);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(69, 27);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_serveur
            // 
            this.lb_serveur.AutoSize = true;
            this.lb_serveur.Location = new System.Drawing.Point(12, 10);
            this.lb_serveur.Name = "lb_serveur";
            this.lb_serveur.Size = new System.Drawing.Size(57, 15);
            this.lb_serveur.TabIndex = 1;
            this.lb_serveur.Text = "Serveur : ";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(12, 42);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(38, 15);
            this.lb_port.TabIndex = 2;
            this.lb_port.Text = "Port : ";
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(12, 74);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(101, 15);
            this.lb_database.TabIndex = 3;
            this.lb_database.Text = "Base de donnée : ";
            // 
            // lb_users
            // 
            this.lb_users.AutoSize = true;
            this.lb_users.Location = new System.Drawing.Point(12, 107);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(71, 15);
            this.lb_users.TabIndex = 4;
            this.lb_users.Text = "Utilisateur : ";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(119, 7);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(116, 22);
            this.txt_adress.TabIndex = 5;
            this.txt_adress.Text = "127.0.0.1";
            this.txt_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(119, 39);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(66, 22);
            this.txt_port.TabIndex = 6;
            this.txt_port.Text = "5432";
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(119, 71);
            this.txt_db.Name = "txt_db";
            this.txt_db.ReadOnly = true;
            this.txt_db.Size = new System.Drawing.Size(157, 22);
            this.txt_db.TabIndex = 7;
            this.txt_db.Text = "catalogue_article";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(119, 104);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(116, 22);
            this.txt_user.TabIndex = 8;
            this.txt_user.Text = "postgres";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(12, 142);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(89, 15);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Mot de passe : ";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(119, 139);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(157, 22);
            this.txt_pwd.TabIndex = 8;
            this.txt_pwd.Text = "yves1910/";
            // 
            // Form_Serveur
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 211);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.lb_database);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_serveur);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 250);
            this.MinimumSize = new System.Drawing.Size(302, 250);
            this.Name = "Form_Serveur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serveur";
            this.Load += new System.EventHandler(this.Form_Serveur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_serveur;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_database;
        private System.Windows.Forms.Label lb_users;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_pwd;
    }
}