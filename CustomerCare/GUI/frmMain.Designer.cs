﻿namespace CustomerCare.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panMain = new MetroFramework.Controls.MetroPanel();
            this.btnLocation = new MetroFramework.Controls.MetroTile();
            this.btnSetting = new MetroFramework.Controls.MetroTile();
            this.btnUser = new MetroFramework.Controls.MetroTile();
            this.btnReport = new MetroFramework.Controls.MetroTile();
            this.btnProduct = new MetroFramework.Controls.MetroTile();
            this.btnSource = new MetroFramework.Controls.MetroTile();
            this.btnCustomer = new MetroFramework.Controls.MetroTile();
            this.btnAlert = new MetroFramework.Controls.MetroTile();
            this.clock1 = new CustomerCare.GUI.Components.Clock();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panMain.AutoScroll = true;
            this.panMain.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panMain.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panMain.AutoSize = true;
            this.panMain.Controls.Add(this.btnLocation);
            this.panMain.Controls.Add(this.btnSetting);
            this.panMain.Controls.Add(this.btnUser);
            this.panMain.Controls.Add(this.btnReport);
            this.panMain.Controls.Add(this.btnProduct);
            this.panMain.Controls.Add(this.btnSource);
            this.panMain.Controls.Add(this.btnCustomer);
            this.panMain.Controls.Add(this.btnAlert);
            this.panMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panMain.HorizontalScrollbar = true;
            this.panMain.HorizontalScrollbarBarColor = true;
            this.panMain.HorizontalScrollbarHighlightOnWheel = true;
            this.panMain.HorizontalScrollbarSize = 13;
            this.panMain.Location = new System.Drawing.Point(24, 114);
            this.panMain.Margin = new System.Windows.Forms.Padding(4);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(976, 596);
            this.panMain.TabIndex = 0;
            this.panMain.VerticalScrollbar = true;
            this.panMain.VerticalScrollbarBarColor = true;
            this.panMain.VerticalScrollbarHighlightOnWheel = true;
            this.panMain.VerticalScrollbarSize = 15;
            // 
            // btnLocation
            // 
            this.btnLocation.ActiveControl = null;
            this.btnLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocation.Location = new System.Drawing.Point(524, 394);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(185, 180);
            this.btnLocation.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLocation.TabIndex = 9;
            this.btnLocation.Text = "Locations";
            this.btnLocation.TileImage = global::CustomerCare.Properties.Resources.Location1;
            this.btnLocation.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocation.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLocation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnLocation.UseSelectable = true;
            this.btnLocation.UseTileImage = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.ActiveControl = null;
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetting.Location = new System.Drawing.Point(715, 394);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(257, 180);
            this.btnSetting.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TileImage = global::CustomerCare.Properties.Resources.Setting;
            this.btnSetting.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSetting.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSetting.UseSelectable = true;
            this.btnSetting.UseTileImage = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUser
            // 
            this.btnUser.ActiveControl = null;
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.Location = new System.Drawing.Point(683, 208);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(289, 180);
            this.btnUser.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "Users";
            this.btnUser.TileImage = global::CustomerCare.Properties.Resources.Group;
            this.btnUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnUser.UseSelectable = true;
            this.btnUser.UseTileImage = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReport
            // 
            this.btnReport.ActiveControl = null;
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.Location = new System.Drawing.Point(4, 394);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(514, 180);
            this.btnReport.Style = MetroFramework.MetroColorStyle.Green;
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Reports";
            this.btnReport.TileImage = global::CustomerCare.Properties.Resources.Report;
            this.btnReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnReport.UseSelectable = true;
            this.btnReport.UseTileImage = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.ActiveControl = null;
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.Location = new System.Drawing.Point(370, 208);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(307, 180);
            this.btnProduct.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Products";
            this.btnProduct.TileImage = global::CustomerCare.Properties.Resources.Product2;
            this.btnProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnProduct.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnProduct.UseSelectable = true;
            this.btnProduct.UseTileImage = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSource
            // 
            this.btnSource.ActiveControl = null;
            this.btnSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSource.Location = new System.Drawing.Point(4, 208);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(360, 180);
            this.btnSource.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Sources";
            this.btnSource.TileImage = global::CustomerCare.Properties.Resources.Meeting;
            this.btnSource.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSource.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSource.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSource.UseSelectable = true;
            this.btnSource.UseTileImage = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.ActiveControl = null;
            this.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomer.Location = new System.Drawing.Point(418, 22);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(554, 180);
            this.btnCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TileImage = global::CustomerCare.Properties.Resources.BS_Set;
            this.btnCustomer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCustomer.UseSelectable = true;
            this.btnCustomer.UseTileImage = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.ActiveControl = null;
            this.btnAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlert.Location = new System.Drawing.Point(4, 22);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(408, 180);
            this.btnAlert.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "Alerts";
            this.btnAlert.TileImage = global::CustomerCare.Properties.Resources.Important;
            this.btnAlert.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlert.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAlert.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAlert.UseSelectable = true;
            this.btnAlert.UseTileImage = true;
            // 
            // clock1
            // 
            this.clock1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clock1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock1.Location = new System.Drawing.Point(346, 56);
            this.clock1.Margin = new System.Windows.Forms.Padding(4);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(355, 50);
            this.clock1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.panMain);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.Text = "Dashboard - {Username}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panMain;
        private MetroFramework.Controls.MetroTile btnAlert;
        private MetroFramework.Controls.MetroTile btnCustomer;
        private Components.Clock clock1;
        private MetroFramework.Controls.MetroTile btnSource;
        private MetroFramework.Controls.MetroTile btnProduct;
        private MetroFramework.Controls.MetroTile btnReport;
        private MetroFramework.Controls.MetroTile btnUser;
        private MetroFramework.Controls.MetroTile btnSetting;
        private MetroFramework.Controls.MetroTile btnLocation;
    }
}