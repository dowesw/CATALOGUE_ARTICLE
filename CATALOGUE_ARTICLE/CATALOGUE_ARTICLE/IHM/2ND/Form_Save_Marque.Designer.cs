namespace CATALOGUE_ARTICLE.IHM._2ND
{
    partial class Form_Save_Marque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Save_Marque));
            this.lb_reference = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_reference
            // 
            this.lb_reference.AutoSize = true;
            this.lb_reference.Location = new System.Drawing.Point(15, 13);
            this.lb_reference.Name = "lb_reference";
            this.lb_reference.Size = new System.Drawing.Size(66, 13);
            this.lb_reference.TabIndex = 0;
            this.lb_reference.Text = "Reference : ";
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(15, 46);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 1;
            this.lb_designation.Text = "Désignation : ";
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(103, 10);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(169, 20);
            this.txt_reference.TabIndex = 2;
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(103, 43);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(169, 20);
            this.txt_designation.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::CATALOGUE_ARTICLE.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(197, 69);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form_Save_Marque
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.lb_designation);
            this.Controls.Add(this.lb_reference);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 138);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 138);
            this.Name = "Form_Save_Marque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création Marque Article";
            this.Load += new System.EventHandler(this.Form_Save_Marque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_reference;
        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.Button btn_save;
    }
}