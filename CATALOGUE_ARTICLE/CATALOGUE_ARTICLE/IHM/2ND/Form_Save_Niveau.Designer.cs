namespace CATALOGUE_ARTICLE.IHM._2ND
{
    partial class Form_Save_Niveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Save_Niveau));
            this.lb_designation = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(15, 15);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 1;
            this.lb_designation.Text = "Désignation : ";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(15, 42);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(69, 13);
            this.lb_description.TabIndex = 1;
            this.lb_description.Text = "Déscription : ";
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(103, 12);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(169, 20);
            this.txt_designation.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(18, 61);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(254, 96);
            this.txt_description.TabIndex = 4;
            this.txt_description.Text = "";
            this.txt_description.Enter += new System.EventHandler(this.txt_description_Enter);
            this.txt_description.Leave += new System.EventHandler(this.txt_description_Leave);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(197, 164);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form_Save_Niveau
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_designation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 233);
            this.Name = "Form_Save_Niveau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création Famille Article";
            this.Load += new System.EventHandler(this.Form_Save_Famille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Button btn_save;
    }
}