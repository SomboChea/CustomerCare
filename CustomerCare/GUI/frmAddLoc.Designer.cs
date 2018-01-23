namespace CustomerCare
{
    partial class frmAddLoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.listPro = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.listDis = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomm = new System.Windows.Forms.TextBox();
            this.listComm = new System.Windows.Forms.ListBox();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "City / Province";
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(28, 72);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(151, 31);
            this.txtpro.TabIndex = 1;
            this.txtpro.TextChanged += new System.EventHandler(this.txtpro_TextChanged);
            // 
            // listPro
            // 
            this.listPro.ContextMenuStrip = this.contextMenuStrip1;
            this.listPro.FormattingEnabled = true;
            this.listPro.ItemHeight = 22;
            this.listPro.Location = new System.Drawing.Point(28, 119);
            this.listPro.Name = "listPro";
            this.listPro.Size = new System.Drawing.Size(147, 202);
            this.listPro.TabIndex = 2;
            this.listPro.SelectedIndexChanged += new System.EventHandler(this.listPro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "District";
            // 
            // txtdis
            // 
            this.txtdis.Location = new System.Drawing.Point(220, 72);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(151, 31);
            this.txtdis.TabIndex = 1;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            // 
            // listDis
            // 
            this.listDis.ContextMenuStrip = this.contextMenuStrip1;
            this.listDis.FormattingEnabled = true;
            this.listDis.ItemHeight = 22;
            this.listDis.Location = new System.Drawing.Point(220, 119);
            this.listDis.Name = "listDis";
            this.listDis.Size = new System.Drawing.Size(147, 202);
            this.listDis.TabIndex = 2;
            this.listDis.SelectedIndexChanged += new System.EventHandler(this.listDis_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Commune";
            // 
            // txtcomm
            // 
            this.txtcomm.Location = new System.Drawing.Point(414, 72);
            this.txtcomm.Name = "txtcomm";
            this.txtcomm.Size = new System.Drawing.Size(151, 31);
            this.txtcomm.TabIndex = 1;
            this.txtcomm.TextChanged += new System.EventHandler(this.txtcomm_TextChanged);
            // 
            // listComm
            // 
            this.listComm.ContextMenuStrip = this.contextMenuStrip1;
            this.listComm.FormattingEnabled = true;
            this.listComm.ItemHeight = 22;
            this.listComm.Location = new System.Drawing.Point(414, 119);
            this.listComm.Name = "listComm";
            this.listComm.Size = new System.Drawing.Size(147, 202);
            this.listComm.TabIndex = 2;
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(28, 327);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(103, 39);
            this.btnPro.TabIndex = 3;
            this.btnPro.Text = "ADD";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(220, 327);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(103, 39);
            this.btnDis.TabIndex = 3;
            this.btnDis.Text = "ADD";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(414, 327);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(103, 39);
            this.btnComm.TabIndex = 3;
            this.btnComm.Text = "ADD";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdate,
            this.toolStripSeparator1,
            this.mnuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(152, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(112, 22);
            this.mnuDelete.Text = "Delete";
            // 
            // frmAddLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 396);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.listComm);
            this.Controls.Add(this.txtcomm);
            this.Controls.Add(this.listDis);
            this.Controls.Add(this.txtdis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAddLoc";
            this.Text = "frmAddPos";
            this.Load += new System.EventHandler(this.frmAddPos_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.ListBox listPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.ListBox listDis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomm;
        private System.Windows.Forms.ListBox listComm;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}