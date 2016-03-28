namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Photo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Photo));
            this.box_users = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).BeginInit();
            this.SuspendLayout();
            // 
            // box_users
            // 
            this.box_users.BackColor = System.Drawing.SystemColors.Control;
            this.box_users.Image = global::CATALOGUE_ARTICLE.Properties.Resources.contact;
            this.box_users.Location = new System.Drawing.Point(6, 6);
            this.box_users.Name = "box_users";
            this.box_users.Size = new System.Drawing.Size(272, 249);
            this.box_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_users.TabIndex = 0;
            this.box_users.TabStop = false;
            // 
            // Form_Photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.box_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(284, 261);
            this.MinimumSize = new System.Drawing.Size(284, 261);
            this.Name = "Form_Photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identité Users";
            ((System.ComponentModel.ISupportInitialize)(this.box_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox box_users;
    }
}