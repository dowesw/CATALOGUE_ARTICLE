namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Licence
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
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_valide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_key
            // 
            this.txt_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_key.Location = new System.Drawing.Point(7, 5);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(285, 24);
            this.txt_key.TabIndex = 0;
            this.txt_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(-2, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(10, 10);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_valide
            // 
            this.btn_valide.Location = new System.Drawing.Point(299, 5);
            this.btn_valide.Name = "btn_valide";
            this.btn_valide.Size = new System.Drawing.Size(47, 23);
            this.btn_valide.TabIndex = 2;
            this.btn_valide.Text = "Ok";
            this.btn_valide.UseVisualStyleBackColor = true;
            this.btn_valide.Click += new System.EventHandler(this.btn_valide_Click);
            // 
            // Form_Licence
            // 
            this.AcceptButton = this.btn_valide;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(353, 35);
            this.ControlBox = false;
            this.Controls.Add(this.btn_valide);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 35);
            this.MinimumSize = new System.Drawing.Size(353, 35);
            this.Name = "Form_Licence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Licence";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Licence_FormClosed);
            this.Load += new System.EventHandler(this.Form_Licence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_valide;
    }
}