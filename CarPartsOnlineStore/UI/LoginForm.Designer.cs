using System.Windows.Forms;

namespace CarPartsOnlineStore.UI
{
	partial class LoginForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.lblLoginTime = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbShowPassword = new System.Windows.Forms.CheckBox();
			this.cbIsAdmin = new System.Windows.Forms.CheckBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(5, 8);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username:";
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.Location = new System.Drawing.Point(69, 4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(190, 20);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(69, 33);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(190, 20);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(197, 320);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(120, 140);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 13);
			this.lblError.TabIndex = 5;
			// 
			// lblLoginTime
			// 
			this.lblLoginTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblLoginTime.AutoSize = true;
			this.lblLoginTime.Location = new System.Drawing.Point(22, 304);
			this.lblLoginTime.Name = "lblLoginTime";
			this.lblLoginTime.Size = new System.Drawing.Size(0, 13);
			this.lblLoginTime.TabIndex = 6;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.35714F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.64286F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 123);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 85);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.42105F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.57895F));
			this.tableLayoutPanel2.Controls.Add(this.cbShowPassword, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbIsAdmin, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(69, 61);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 21);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// cbShowPassword
			// 
			this.cbShowPassword.AutoSize = true;
			this.cbShowPassword.Location = new System.Drawing.Point(3, 3);
			this.cbShowPassword.Name = "cbShowPassword";
			this.cbShowPassword.Size = new System.Drawing.Size(102, 15);
			this.cbShowPassword.TabIndex = 8;
			this.cbShowPassword.Text = "Show Password";
			this.cbShowPassword.UseVisualStyleBackColor = true;
			this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
			// 
			// cbIsAdmin
			// 
			this.cbIsAdmin.AutoSize = true;
			this.cbIsAdmin.Location = new System.Drawing.Point(114, 3);
			this.cbIsAdmin.Name = "cbIsAdmin";
			this.cbIsAdmin.Size = new System.Drawing.Size(66, 15);
			this.cbIsAdmin.TabIndex = 8;
			this.cbIsAdmin.Text = "Is Admin";
			this.cbIsAdmin.UseVisualStyleBackColor = true;
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(7, 37);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password:";
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(10, 320);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 20.25F);
			this.label1.Location = new System.Drawing.Point(105, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(282, 354);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLoginTime);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label lblUsername;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
		private Label lblLoginTime;
		private Label lblError;
		private System.Windows.Forms.Timer loginTimer;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblPassword;
		private Button btnExit;
		private Label label1;
		private CheckBox cbShowPassword;
		private TableLayoutPanel tableLayoutPanel2;
		private CheckBox cbIsAdmin;
	}
}