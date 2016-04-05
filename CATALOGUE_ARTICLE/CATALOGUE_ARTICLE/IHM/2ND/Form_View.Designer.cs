namespace CATALOGUE_ARTICLE.IHM._2ND
{
    partial class Form_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_View));
            this.grp_photo = new System.Windows.Forms.GroupBox();
            this.box_photo = new System.Windows.Forms.PictureBox();
            this.lb_reference = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.lb_marque = new System.Windows.Forms.Label();
            this.lb_famille = new System.Windows.Forms.Label();
            this.lb_pua = new System.Windows.Forms.Label();
            this.lb_puv = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.txt_famille = new System.Windows.Forms.TextBox();
            this.txt_pua = new System.Windows.Forms.TextBox();
            this.txt_puv = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.grp_photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_photo
            // 
            this.grp_photo.Controls.Add(this.box_photo);
            this.grp_photo.Location = new System.Drawing.Point(278, 12);
            this.grp_photo.Name = "grp_photo";
            this.grp_photo.Size = new System.Drawing.Size(156, 147);
            this.grp_photo.TabIndex = 0;
            this.grp_photo.TabStop = false;
            this.grp_photo.Text = "Photo";
            // 
            // box_photo
            // 
            this.box_photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.article;
            this.box_photo.Location = new System.Drawing.Point(3, 16);
            this.box_photo.Name = "box_photo";
            this.box_photo.Size = new System.Drawing.Size(150, 128);
            this.box_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_photo.TabIndex = 0;
            this.box_photo.TabStop = false;
            // 
            // lb_reference
            // 
            this.lb_reference.AutoSize = true;
            this.lb_reference.Location = new System.Drawing.Point(20, 15);
            this.lb_reference.Name = "lb_reference";
            this.lb_reference.Size = new System.Drawing.Size(66, 13);
            this.lb_reference.TabIndex = 2;
            this.lb_reference.Text = "Reference : ";
            // 
            // lb_designation
            // 
            this.lb_designation.AutoSize = true;
            this.lb_designation.Location = new System.Drawing.Point(19, 46);
            this.lb_designation.Name = "lb_designation";
            this.lb_designation.Size = new System.Drawing.Size(72, 13);
            this.lb_designation.TabIndex = 3;
            this.lb_designation.Text = "Désignation : ";
            // 
            // lb_marque
            // 
            this.lb_marque.AutoSize = true;
            this.lb_marque.Location = new System.Drawing.Point(20, 78);
            this.lb_marque.Name = "lb_marque";
            this.lb_marque.Size = new System.Drawing.Size(52, 13);
            this.lb_marque.TabIndex = 4;
            this.lb_marque.Text = "Marque : ";
            // 
            // lb_famille
            // 
            this.lb_famille.AutoSize = true;
            this.lb_famille.Location = new System.Drawing.Point(20, 110);
            this.lb_famille.Name = "lb_famille";
            this.lb_famille.Size = new System.Drawing.Size(48, 13);
            this.lb_famille.TabIndex = 5;
            this.lb_famille.Text = "Famille : ";
            // 
            // lb_pua
            // 
            this.lb_pua.AutoSize = true;
            this.lb_pua.Location = new System.Drawing.Point(19, 143);
            this.lb_pua.Name = "lb_pua";
            this.lb_pua.Size = new System.Drawing.Size(64, 13);
            this.lb_pua.TabIndex = 6;
            this.lb_pua.Text = "Prix Achat : ";
            // 
            // lb_puv
            // 
            this.lb_puv.AutoSize = true;
            this.lb_puv.Location = new System.Drawing.Point(19, 174);
            this.lb_puv.Name = "lb_puv";
            this.lb_puv.Size = new System.Drawing.Size(64, 13);
            this.lb_puv.TabIndex = 7;
            this.lb_puv.Text = "Prix Vente : ";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(295, 173);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(44, 13);
            this.lb_stock.TabIndex = 8;
            this.lb_stock.Text = "Stock : ";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(19, 201);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(69, 13);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Déscription : ";
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(97, 43);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.ReadOnly = true;
            this.txt_designation.Size = new System.Drawing.Size(175, 20);
            this.txt_designation.TabIndex = 10;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(97, 12);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.ReadOnly = true;
            this.txt_reference.Size = new System.Drawing.Size(175, 20);
            this.txt_reference.TabIndex = 10;
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(97, 75);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.ReadOnly = true;
            this.txt_marque.Size = new System.Drawing.Size(175, 20);
            this.txt_marque.TabIndex = 10;
            // 
            // txt_famille
            // 
            this.txt_famille.Location = new System.Drawing.Point(97, 107);
            this.txt_famille.Name = "txt_famille";
            this.txt_famille.ReadOnly = true;
            this.txt_famille.Size = new System.Drawing.Size(175, 20);
            this.txt_famille.TabIndex = 10;
            // 
            // txt_pua
            // 
            this.txt_pua.Location = new System.Drawing.Point(97, 140);
            this.txt_pua.Name = "txt_pua";
            this.txt_pua.ReadOnly = true;
            this.txt_pua.Size = new System.Drawing.Size(175, 20);
            this.txt_pua.TabIndex = 10;
            this.txt_pua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_puv
            // 
            this.txt_puv.Location = new System.Drawing.Point(97, 171);
            this.txt_puv.Name = "txt_puv";
            this.txt_puv.ReadOnly = true;
            this.txt_puv.Size = new System.Drawing.Size(175, 20);
            this.txt_puv.TabIndex = 10;
            this.txt_puv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(345, 171);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(89, 20);
            this.txt_stock.TabIndex = 10;
            this.txt_stock.Text = "0";
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(23, 217);
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(411, 61);
            this.txt_description.TabIndex = 11;
            this.txt_description.Text = "";
            // 
            // Form_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 284);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_puv);
            this.Controls.Add(this.txt_pua);
            this.Controls.Add(this.txt_famille);
            this.Controls.Add(this.txt_marque);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.lb_puv);
            this.Controls.Add(this.lb_pua);
            this.Controls.Add(this.lb_famille);
            this.Controls.Add(this.lb_marque);
            this.Controls.Add(this.lb_designation);
            this.Controls.Add(this.lb_reference);
            this.Controls.Add(this.grp_photo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 323);
            this.Name = "Form_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail Article";
            this.Load += new System.EventHandler(this.Form_View_Load);
            this.grp_photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_photo;
        private System.Windows.Forms.PictureBox box_photo;
        private System.Windows.Forms.Label lb_reference;
        private System.Windows.Forms.Label lb_designation;
        private System.Windows.Forms.Label lb_marque;
        private System.Windows.Forms.Label lb_famille;
        private System.Windows.Forms.Label lb_pua;
        private System.Windows.Forms.Label lb_puv;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.TextBox txt_famille;
        private System.Windows.Forms.TextBox txt_pua;
        private System.Windows.Forms.TextBox txt_puv;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.RichTextBox txt_description;
    }
}