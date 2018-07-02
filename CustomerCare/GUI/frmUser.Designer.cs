namespace CustomerCare
{
    partial class frmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tffullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tfusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tfcon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comborole = new System.Windows.Forms.ComboBox();
            this.butadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butremove = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.chkedit = new System.Windows.Forms.CheckBox();
            this.butcl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // tffullname
            // 
            this.tffullname.Location = new System.Drawing.Point(249, 38);
            this.tffullname.Name = "tffullname";
            this.tffullname.Size = new System.Drawing.Size(233, 35);
            this.tffullname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // tfusername
            // 
            this.tfusername.Location = new System.Drawing.Point(249, 94);
            this.tfusername.Name = "tfusername";
            this.tfusername.Size = new System.Drawing.Size(233, 35);
            this.tfusername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // tfpass
            // 
            this.tfpass.Location = new System.Drawing.Point(249, 143);
            this.tfpass.Name = "tfpass";
            this.tfpass.Size = new System.Drawing.Size(233, 35);
            this.tfpass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password :";
            // 
            // tfcon
            // 
            this.tfcon.Location = new System.Drawing.Point(249, 206);
            this.tfcon.Name = "tfcon";
            this.tfcon.Size = new System.Drawing.Size(233, 35);
            this.tfcon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Role :";
            // 
            // comborole
            // 
            this.comborole.FormattingEnabled = true;
            this.comborole.Items.AddRange(new object[] {
            "Admin"});
            this.comborole.Location = new System.Drawing.Point(249, 256);
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(233, 37);
            this.comborole.TabIndex = 2;
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(533, 38);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(151, 47);
            this.butadd.TabIndex = 3;
            this.butadd.Text = "Insert";
            this.butadd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 177);
            this.dataGridView1.TabIndex = 4;
            // 
            // butremove
            // 
            this.butremove.Location = new System.Drawing.Point(533, 144);
            this.butremove.Name = "butremove";
            this.butremove.Size = new System.Drawing.Size(151, 47);
            this.butremove.TabIndex = 3;
            this.butremove.Text = "Remove";
            this.butremove.UseVisualStyleBackColor = true;
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(533, 91);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(151, 47);
            this.butedit.TabIndex = 3;
            this.butedit.Text = "Edit";
            this.butedit.UseVisualStyleBackColor = true;
            // 
            // chkedit
            // 
            this.chkedit.AutoSize = true;
            this.chkedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkedit.Location = new System.Drawing.Point(249, 185);
            this.chkedit.Name = "chkedit";
            this.chkedit.Size = new System.Drawing.Size(116, 21);
            this.chkedit.TabIndex = 5;
            this.chkedit.Text = "Edit Password";
            this.chkedit.UseVisualStyleBackColor = true;
            // 
            // butcl
            // 
            this.butcl.Location = new System.Drawing.Point(533, 194);
            this.butcl.Name = "butcl";
            this.butcl.Size = new System.Drawing.Size(151, 47);
            this.butcl.TabIndex = 3;
            this.butcl.Text = "Clear";
            this.butcl.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Controls.Add(this.chkedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butedit);
            this.Controls.Add(this.butcl);
            this.Controls.Add(this.butremove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.comborole);
            this.Controls.Add(this.tfcon);
            this.Controls.Add(this.tfpass);
            this.Controls.Add(this.tfusername);
            this.Controls.Add(this.tffullname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmUser";
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tffullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tfcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comborole;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butremove;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.CheckBox chkedit;
        private System.Windows.Forms.Button butcl;
    }
}