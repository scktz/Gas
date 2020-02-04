namespace Loader
{
    partial class Form2
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
            this.versionPlace = new MetroFramework.Controls.MetroLabel();
            this.versionLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.currentUser = new MetroFramework.Controls.MetroLabel();
            this.launchButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.devRadio = new MetroFramework.Controls.MetroRadioButton();
            this.stableRadio = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // versionPlace
            // 
            this.versionPlace.AutoSize = true;
            this.versionPlace.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.versionPlace.Location = new System.Drawing.Point(23, 79);
            this.versionPlace.Name = "versionPlace";
            this.versionPlace.Size = new System.Drawing.Size(57, 19);
            this.versionPlace.Style = MetroFramework.MetroColorStyle.White;
            this.versionPlace.TabIndex = 0;
            this.versionPlace.Text = "Version:";
            this.versionPlace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versionPlace.UseStyleColors = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(79, 79);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(29, 19);
            this.versionLabel.Style = MetroFramework.MetroColorStyle.White;
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "null";
            this.versionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versionLabel.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "User:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Location = new System.Drawing.Point(79, 98);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(29, 19);
            this.currentUser.Style = MetroFramework.MetroColorStyle.White;
            this.currentUser.TabIndex = 5;
            this.currentUser.Text = "null";
            this.currentUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.currentUser.UseStyleColors = true;
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(23, 152);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(137, 28);
            this.launchButton.Style = MetroFramework.MetroColorStyle.White;
            this.launchButton.TabIndex = 6;
            this.launchButton.Text = "Launch";
            this.launchButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.launchButton.UseSelectable = true;
            this.launchButton.UseStyleColors = true;
            this.launchButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Status:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(79, 60);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 19);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.White;
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "null";
            this.statusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.statusLabel.UseStyleColors = true;
            // 
            // devRadio
            // 
            this.devRadio.AutoSize = true;
            this.devRadio.Location = new System.Drawing.Point(87, 131);
            this.devRadio.Name = "devRadio";
            this.devRadio.Size = new System.Drawing.Size(73, 15);
            this.devRadio.Style = MetroFramework.MetroColorStyle.White;
            this.devRadio.TabIndex = 9;
            this.devRadio.Text = "Dev Build";
            this.devRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.devRadio.UseSelectable = true;
            this.devRadio.UseStyleColors = true;
            // 
            // stableRadio
            // 
            this.stableRadio.AutoSize = true;
            this.stableRadio.Location = new System.Drawing.Point(23, 131);
            this.stableRadio.Name = "stableRadio";
            this.stableRadio.Size = new System.Drawing.Size(55, 15);
            this.stableRadio.Style = MetroFramework.MetroColorStyle.White;
            this.stableRadio.TabIndex = 10;
            this.stableRadio.Text = "Stable";
            this.stableRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stableRadio.UseSelectable = true;
            this.stableRadio.UseStyleColors = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 203);
            this.Controls.Add(this.stableRadio);
            this.Controls.Add(this.devRadio);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionPlace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Gas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel versionPlace;
        private MetroFramework.Controls.MetroLabel versionLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel currentUser;
        private MetroFramework.Controls.MetroButton launchButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroRadioButton devRadio;
        private MetroFramework.Controls.MetroRadioButton stableRadio;
    }
}