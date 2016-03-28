namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_identifiant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.temps = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_identifiant);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_annuler);
            this.panel1.Controls.Add(this.btn_connecter);
            this.panel1.Location = new System.Drawing.Point(152, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 257);
            this.panel1.TabIndex = 9;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(99, 131);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(206, 20);
            this.txt_pwd.TabIndex = 7;
            // 
            // txt_identifiant
            // 
            this.txt_identifiant.Location = new System.Drawing.Point(99, 92);
            this.txt_identifiant.Name = "txt_identifiant";
            this.txt_identifiant.Size = new System.Drawing.Size(206, 20);
            this.txt_identifiant.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identifiant : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connexion";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_annuler.Image = global::CATALOGUE_ARTICLE.Properties.Resources.exit;
            this.btn_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_annuler.Location = new System.Drawing.Point(103, 188);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(90, 31);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Sortir";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_connecter
            // 
            this.btn_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connecter.Image = global::CATALOGUE_ARTICLE.Properties.Resources.connect;
            this.btn_connecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connecter.Location = new System.Drawing.Point(210, 188);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(89, 31);
            this.btn_connecter.TabIndex = 0;
            this.btn_connecter.Text = "Entrer";
            this.btn_connecter.UseVisualStyleBackColor = true;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click);
            // 
            // temps
            // 
            this.temps.AutoSize = true;
            this.temps.BackColor = System.Drawing.Color.Transparent;
            this.temps.ForeColor = System.Drawing.Color.White;
            this.temps.Location = new System.Drawing.Point(6, 211);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(92, 13);
            this.temps.TabIndex = 12;
            this.temps.Text = "Temps Connexion";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 239);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 13);
            this.progressBar1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CATALOGUE_ARTICLE.Properties.Resources.acces;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AcceptButton = this.btn_connecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btn_annuler;
            this.ClientSize = new System.Drawing.Size(483, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(483, 271);
            this.MinimumSize = new System.Drawing.Size(483, 271);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pwd;
        public System.Windows.Forms.TextBox txt_identifiant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.Label temps;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}