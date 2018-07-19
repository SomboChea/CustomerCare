namespace CustomerCare.GUI
{
    partial class frmCustomerQuickAdd
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
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtTel1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkHasKid = new MetroFramework.Controls.MetroCheckBox();
            this.txtInfo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbFromSource = new System.Windows.Forms.ComboBox();
            this.panType = new MetroFramework.Controls.MetroPanel();
            this.cbSourceType = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panInfo = new MetroFramework.Controls.MetroPanel();
            this.panType.SuspendLayout();
            this.panInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(514, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(34, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Customer Name";
            // 
            // txtName
            // 
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(38, 128);
            this.txtName.MaxLength = 50;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter customer name here...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(271, 34);
            this.txtName.TabIndex = 2;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WordWrap = false;
            // 
            // txtTel1
            // 
            this.txtTel1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTel1.Lines = new string[0];
            this.txtTel1.Location = new System.Drawing.Point(42, 221);
            this.txtTel1.MaxLength = 50;
            this.txtTel1.Multiline = true;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.PasswordChar = '\0';
            this.txtTel1.PromptText = "eg: 012345678";
            this.txtTel1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel1.SelectedText = "";
            this.txtTel1.Size = new System.Drawing.Size(271, 34);
            this.txtTel1.TabIndex = 4;
            this.txtTel1.UseCustomBackColor = true;
            this.txtTel1.UseCustomForeColor = true;
            this.txtTel1.UseSelectable = true;
            this.txtTel1.UseStyleColors = true;
            this.txtTel1.WordWrap = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(38, 183);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contact Line 1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(350, 183);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "From Source";
            // 
            // chkHasKid
            // 
            this.chkHasKid.AutoSize = true;
            this.chkHasKid.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkHasKid.Location = new System.Drawing.Point(353, 128);
            this.chkHasKid.Name = "chkHasKid";
            this.chkHasKid.Size = new System.Drawing.Size(98, 25);
            this.chkHasKid.TabIndex = 7;
            this.chkHasKid.Text = "Have Kid";
            this.chkHasKid.UseSelectable = true;
            // 
            // txtInfo
            // 
            this.txtInfo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInfo.Lines = new string[0];
            this.txtInfo.Location = new System.Drawing.Point(3, 38);
            this.txtInfo.MaxLength = 50;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.PasswordChar = '\0';
            this.txtInfo.PromptText = "Take some information...";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo.SelectedText = "";
            this.txtInfo.Size = new System.Drawing.Size(585, 81);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.UseCustomBackColor = true;
            this.txtInfo.UseCustomForeColor = true;
            this.txtInfo.UseSelectable = true;
            this.txtInfo.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(-3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Information";
            // 
            // cbFromSource
            // 
            this.cbFromSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFromSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFromSource.Font = new System.Drawing.Font("AKbalthom KhmerLer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFromSource.FormattingEnabled = true;
            this.cbFromSource.Location = new System.Drawing.Point(353, 221);
            this.cbFromSource.Name = "cbFromSource";
            this.cbFromSource.Size = new System.Drawing.Size(275, 35);
            this.cbFromSource.TabIndex = 10;
            this.cbFromSource.SelectedIndexChanged += new System.EventHandler(this.cbFromSource_SelectedIndexChanged);
            this.cbFromSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFromSource_KeyPress);
            // 
            // panType
            // 
            this.panType.Controls.Add(this.cbSourceType);
            this.panType.Controls.Add(this.metroLabel5);
            this.panType.HorizontalScrollbarBarColor = true;
            this.panType.HorizontalScrollbarHighlightOnWheel = false;
            this.panType.HorizontalScrollbarSize = 10;
            this.panType.Location = new System.Drawing.Point(350, 256);
            this.panType.Name = "panType";
            this.panType.Size = new System.Drawing.Size(278, 92);
            this.panType.TabIndex = 11;
            this.panType.VerticalScrollbarBarColor = true;
            this.panType.VerticalScrollbarHighlightOnWheel = false;
            this.panType.VerticalScrollbarSize = 10;
            // 
            // cbSourceType
            // 
            this.cbSourceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSourceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceType.Font = new System.Drawing.Font("AKbalthom KhmerLer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSourceType.FormattingEnabled = true;
            this.cbSourceType.Location = new System.Drawing.Point(3, 55);
            this.cbSourceType.Name = "cbSourceType";
            this.cbSourceType.Size = new System.Drawing.Size(275, 35);
            this.cbSourceType.TabIndex = 14;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(0, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 25);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Source Type";
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.metroLabel4);
            this.panInfo.Controls.Add(this.txtInfo);
            this.panInfo.HorizontalScrollbarBarColor = true;
            this.panInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panInfo.HorizontalScrollbarSize = 10;
            this.panInfo.Location = new System.Drawing.Point(39, 350);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(589, 123);
            this.panInfo.TabIndex = 12;
            this.panInfo.VerticalScrollbarBarColor = true;
            this.panInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panInfo.VerticalScrollbarSize = 10;
            // 
            // frmCustomerQuickAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 550);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panType);
            this.Controls.Add(this.cbFromSource);
            this.Controls.Add(this.chkHasKid);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmCustomerQuickAdd";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Customer Quick Add";
            this.panType.ResumeLayout(false);
            this.panType.PerformLayout();
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtTel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkHasKid;
        private MetroFramework.Controls.MetroTextBox txtInfo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cbFromSource;
        private MetroFramework.Controls.MetroPanel panType;
        private System.Windows.Forms.ComboBox cbSourceType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel panInfo;
    }
}