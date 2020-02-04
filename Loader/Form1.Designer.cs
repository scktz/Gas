namespace Loader
{
    partial class Form
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
            this.usernameBox = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            // 
            // 
            // 
            this.usernameBox.CustomButton.Image = null;
            this.usernameBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.usernameBox.CustomButton.Name = "";
            this.usernameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameBox.CustomButton.TabIndex = 1;
            this.usernameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameBox.CustomButton.UseSelectable = true;
            this.usernameBox.CustomButton.Visible = false;
            this.usernameBox.Lines = new string[] {
        "Username"};
            this.usernameBox.Location = new System.Drawing.Point(23, 80);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.ShortcutsEnabled = true;
            this.usernameBox.Size = new System.Drawing.Size(140, 23);
            this.usernameBox.Style = MetroFramework.MetroColorStyle.Red;
            this.usernameBox.TabIndex = 1;
            this.usernameBox.Text = "Username";
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usernameBox.UseSelectable = true;
            this.usernameBox.UseStyleColors = true;
            this.usernameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usernameBox.Click += new System.EventHandler(this.usernameBox_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(23, 109);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(140, 23);
            this.loginButton.Style = MetroFramework.MetroColorStyle.Red;
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginButton.UseSelectable = true;
            this.loginButton.UseStyleColors = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 164);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Developed By Stabber";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 203);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Gas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox usernameBox;
    }
}

