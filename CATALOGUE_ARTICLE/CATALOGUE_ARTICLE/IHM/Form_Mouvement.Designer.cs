namespace CATALOGUE_ARTICLE.IHM
{
    partial class Form_Mouvement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mouvement));
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icon_ = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.date_search = new System.Windows.Forms.DateTimePicker();
            this.context_date = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.panel2.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.context_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_liste
            // 
            this.dgv_liste.AllowUserToAddRows = false;
            this.dgv_liste.AllowUserToDeleteRows = false;
            this.dgv_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.article_,
            this.qte_,
            this.date_,
            this.icon_});
            this.dgv_liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_liste.Location = new System.Drawing.Point(0, 0);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(559, 345);
            this.dgv_liste.TabIndex = 0;
            // 
            // id_
            // 
            this.id_.HeaderText = "ID";
            this.id_.Name = "id_";
            this.id_.ReadOnly = true;
            this.id_.Visible = false;
            // 
            // article_
            // 
            this.article_.FillWeight = 152.6926F;
            this.article_.HeaderText = "Article";
            this.article_.Name = "article_";
            this.article_.ReadOnly = true;
            // 
            // qte_
            // 
            this.qte_.FillWeight = 64.15788F;
            this.qte_.HeaderText = "Quantitée";
            this.qte_.Name = "qte_";
            this.qte_.ReadOnly = true;
            // 
            // date_
            // 
            this.date_.FillWeight = 152.6926F;
            this.date_.HeaderText = "Date Save";
            this.date_.Name = "date_";
            this.date_.ReadOnly = true;
            // 
            // icon_
            // 
            this.icon_.FillWeight = 30.45685F;
            this.icon_.HeaderText = "";
            this.icon_.Name = "icon_";
            this.icon_.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_liste);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 345);
            this.panel2.TabIndex = 2;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.date_search);
            this.grp_search.Controls.Add(this.txt_search);
            this.grp_search.Location = new System.Drawing.Point(0, 351);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(556, 39);
            this.grp_search.TabIndex = 0;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Recherche";
            // 
            // date_search
            // 
            this.date_search.ContextMenuStrip = this.context_date;
            this.date_search.Location = new System.Drawing.Point(327, 13);
            this.date_search.Name = "date_search";
            this.date_search.Size = new System.Drawing.Size(200, 20);
            this.date_search.TabIndex = 1;
            this.date_search.ValueChanged += new System.EventHandler(this.date_search_ValueChanged);
            // 
            // context_date
            // 
            this.context_date.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reinitialiserToolStripMenuItem});
            this.context_date.Name = "context_date";
            this.context_date.Size = new System.Drawing.Size(135, 26);
            // 
            // reinitialiserToolStripMenuItem
            // 
            this.reinitialiserToolStripMenuItem.Name = "reinitialiserToolStripMenuItem";
            this.reinitialiserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.reinitialiserToolStripMenuItem.Text = "Reinitialiser";
            this.reinitialiserToolStripMenuItem.Click += new System.EventHandler(this.reinitialiserToolStripMenuItem_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(41, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(240, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Form_Mouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 390);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 429);
            this.MinimumSize = new System.Drawing.Size(575, 429);
            this.Name = "Form_Mouvement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouvements Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Mouvement_FormClosed);
            this.Load += new System.EventHandler(this.Form_Mouvement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.context_date.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_;
        private System.Windows.Forms.DataGridViewImageColumn icon_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.DateTimePicker date_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ContextMenuStrip context_date;
        private System.Windows.Forms.ToolStripMenuItem reinitialiserToolStripMenuItem;
    }
}