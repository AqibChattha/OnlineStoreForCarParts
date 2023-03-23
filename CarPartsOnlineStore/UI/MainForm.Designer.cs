using System.Windows.Forms;

namespace CarPartsOnlineStore.UI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlContant = new System.Windows.Forms.Panel();
			this.pnlHome = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlSideMenu = new System.Windows.Forms.Panel();
			this.pnlMenu1 = new System.Windows.Forms.Panel();
			this.pnlShowCliked = new System.Windows.Forms.Panel();
			this.btnRegisterUsers = new System.Windows.Forms.Button();
			this.btnOrderProducts = new System.Windows.Forms.Button();
			this.btnInvoiceProducts = new System.Windows.Forms.Button();
			this.pnlSubMenuAddProducts = new System.Windows.Forms.Panel();
			this.btnInsertProducts = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pnlMenuBottomMargin = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.pnlMenuLogo = new System.Windows.Forms.Panel();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlMain.SuspendLayout();
			this.pnlContant.SuspendLayout();
			this.pnlHome.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlSideMenu.SuspendLayout();
			this.pnlMenu1.SuspendLayout();
			this.pnlSubMenuAddProducts.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.pnlContant);
			this.pnlMain.Controls.Add(this.pnlSideMenu);
			this.pnlMain.Controls.Add(this.pnlHeader);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(729, 527);
			this.pnlMain.TabIndex = 17;
			// 
			// pnlContant
			// 
			this.pnlContant.BackColor = System.Drawing.Color.White;
			this.pnlContant.Controls.Add(this.pnlHome);
			this.pnlContant.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContant.Location = new System.Drawing.Point(130, 10);
			this.pnlContant.Name = "pnlContant";
			this.pnlContant.Size = new System.Drawing.Size(599, 517);
			this.pnlContant.TabIndex = 2;
			// 
			// pnlHome
			// 
			this.pnlHome.Controls.Add(this.label3);
			this.pnlHome.Controls.Add(this.pictureBox2);
			this.pnlHome.Controls.Add(this.pictureBox1);
			this.pnlHome.Controls.Add(this.label1);
			this.pnlHome.Controls.Add(this.label2);
			this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHome.Location = new System.Drawing.Point(0, 0);
			this.pnlHome.Name = "pnlHome";
			this.pnlHome.Size = new System.Drawing.Size(599, 517);
			this.pnlHome.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
			this.label3.Location = new System.Drawing.Point(90, 469);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(273, 25);
			this.label3.TabIndex = 40;
			this.label3.Text = "Let\'s go on a shopping spree !!!";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(35, 457);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(50, 48);
			this.pictureBox2.TabIndex = 39;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Location = new System.Drawing.Point(109, 157);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(379, 227);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
			this.label1.Location = new System.Drawing.Point(52, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(577, 25);
			this.label1.TabIndex = 37;
			this.label1.Text = "Here you will be able to view and purchase vast vairety of products.";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Algerian", 20.25F);
			this.label2.Location = new System.Drawing.Point(175, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(290, 30);
			this.label2.TabIndex = 36;
			this.label2.Text = "Welcome to E-Store";
			// 
			// pnlSideMenu
			// 
			this.pnlSideMenu.BackColor = System.Drawing.Color.Transparent;
			this.pnlSideMenu.Controls.Add(this.pnlMenu1);
			this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSideMenu.Location = new System.Drawing.Point(0, 10);
			this.pnlSideMenu.Name = "pnlSideMenu";
			this.pnlSideMenu.Size = new System.Drawing.Size(130, 517);
			this.pnlSideMenu.TabIndex = 1;
			// 
			// pnlMenu1
			// 
			this.pnlMenu1.AutoScroll = true;
			this.pnlMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
			this.pnlMenu1.Controls.Add(this.pnlShowCliked);
			this.pnlMenu1.Controls.Add(this.btnRegisterUsers);
			this.pnlMenu1.Controls.Add(this.btnOrderProducts);
			this.pnlMenu1.Controls.Add(this.btnInvoiceProducts);
			this.pnlMenu1.Controls.Add(this.pnlSubMenuAddProducts);
			this.pnlMenu1.Controls.Add(this.btnProducts);
			this.pnlMenu1.Controls.Add(this.btnLogout);
			this.pnlMenu1.Controls.Add(this.pnlMenuBottomMargin);
			this.pnlMenu1.Controls.Add(this.btnHome);
			this.pnlMenu1.Controls.Add(this.pnlMenuLogo);
			this.pnlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMenu1.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu1.Name = "pnlMenu1";
			this.pnlMenu1.Size = new System.Drawing.Size(130, 517);
			this.pnlMenu1.TabIndex = 0;
			// 
			// pnlShowCliked
			// 
			this.pnlShowCliked.BackColor = System.Drawing.Color.White;
			this.pnlShowCliked.Location = new System.Drawing.Point(0, 114);
			this.pnlShowCliked.Name = "pnlShowCliked";
			this.pnlShowCliked.Size = new System.Drawing.Size(2, 42);
			this.pnlShowCliked.TabIndex = 16;
			// 
			// btnRegisterUsers
			// 
			this.btnRegisterUsers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRegisterUsers.FlatAppearance.BorderSize = 0;
			this.btnRegisterUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegisterUsers.ForeColor = System.Drawing.Color.White;
			this.btnRegisterUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterUsers.Image")));
			this.btnRegisterUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegisterUsers.Location = new System.Drawing.Point(0, 344);
			this.btnRegisterUsers.Name = "btnRegisterUsers";
			this.btnRegisterUsers.Size = new System.Drawing.Size(130, 42);
			this.btnRegisterUsers.TabIndex = 18;
			this.btnRegisterUsers.Text = "  Register Users";
			this.btnRegisterUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegisterUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRegisterUsers.UseVisualStyleBackColor = true;
			this.btnRegisterUsers.Click += new System.EventHandler(this.btnRegisterUsers_Click);
			// 
			// btnOrderProducts
			// 
			this.btnOrderProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOrderProducts.FlatAppearance.BorderSize = 0;
			this.btnOrderProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderProducts.ForeColor = System.Drawing.Color.White;
			this.btnOrderProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderProducts.Image")));
			this.btnOrderProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderProducts.Location = new System.Drawing.Point(0, 302);
			this.btnOrderProducts.Name = "btnOrderProducts";
			this.btnOrderProducts.Size = new System.Drawing.Size(130, 42);
			this.btnOrderProducts.TabIndex = 17;
			this.btnOrderProducts.Text = "  Order Products";
			this.btnOrderProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOrderProducts.UseVisualStyleBackColor = true;
			this.btnOrderProducts.Click += new System.EventHandler(this.btnOrderProducts_Click);
			// 
			// btnInvoiceProducts
			// 
			this.btnInvoiceProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnInvoiceProducts.FlatAppearance.BorderSize = 0;
			this.btnInvoiceProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInvoiceProducts.ForeColor = System.Drawing.Color.White;
			this.btnInvoiceProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceProducts.Image")));
			this.btnInvoiceProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInvoiceProducts.Location = new System.Drawing.Point(0, 260);
			this.btnInvoiceProducts.Name = "btnInvoiceProducts";
			this.btnInvoiceProducts.Size = new System.Drawing.Size(130, 42);
			this.btnInvoiceProducts.TabIndex = 15;
			this.btnInvoiceProducts.Text = "  Invoice Products";
			this.btnInvoiceProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInvoiceProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInvoiceProducts.UseVisualStyleBackColor = true;
			this.btnInvoiceProducts.Click += new System.EventHandler(this.btnInvoiceProducts_Click);
			// 
			// pnlSubMenuAddProducts
			// 
			this.pnlSubMenuAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.pnlSubMenuAddProducts.Controls.Add(this.btnInsertProducts);
			this.pnlSubMenuAddProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubMenuAddProducts.Location = new System.Drawing.Point(0, 219);
			this.pnlSubMenuAddProducts.Name = "pnlSubMenuAddProducts";
			this.pnlSubMenuAddProducts.Size = new System.Drawing.Size(130, 41);
			this.pnlSubMenuAddProducts.TabIndex = 14;
			// 
			// btnInsertProducts
			// 
			this.btnInsertProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnInsertProducts.FlatAppearance.BorderSize = 0;
			this.btnInsertProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertProducts.ForeColor = System.Drawing.Color.White;
			this.btnInsertProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertProducts.Image")));
			this.btnInsertProducts.Location = new System.Drawing.Point(0, 0);
			this.btnInsertProducts.Name = "btnInsertProducts";
			this.btnInsertProducts.Size = new System.Drawing.Size(130, 42);
			this.btnInsertProducts.TabIndex = 3;
			this.btnInsertProducts.Text = "  Insert Products";
			this.btnInsertProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInsertProducts.UseVisualStyleBackColor = true;
			this.btnInsertProducts.Click += new System.EventHandler(this.btnInsertProducts_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.ForeColor = System.Drawing.Color.White;
			this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
			this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.Location = new System.Drawing.Point(0, 177);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(130, 42);
			this.btnProducts.TabIndex = 13;
			this.btnProducts.Text = "  Products";
			this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(0, 465);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(130, 42);
			this.btnLogout.TabIndex = 11;
			this.btnLogout.Text = " Logout";
			this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pnlMenuBottomMargin
			// 
			this.pnlMenuBottomMargin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
			this.pnlMenuBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlMenuBottomMargin.Location = new System.Drawing.Point(0, 507);
			this.pnlMenuBottomMargin.Name = "pnlMenuBottomMargin";
			this.pnlMenuBottomMargin.Size = new System.Drawing.Size(130, 10);
			this.pnlMenuBottomMargin.TabIndex = 10;
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 135);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(130, 42);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "  Home";
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// pnlMenuLogo
			// 
			this.pnlMenuLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenuLogo.BackgroundImage")));
			this.pnlMenuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenuLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlMenuLogo.Name = "pnlMenuLogo";
			this.pnlMenuLogo.Size = new System.Drawing.Size(130, 135);
			this.pnlMenuLogo.TabIndex = 0;
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnlHeader.Controls.Add(this.panel2);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(729, 10);
			this.pnlHeader.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(729, 10);
			this.panel2.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 527);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "E-Store";
			this.pnlMain.ResumeLayout(false);
			this.pnlContant.ResumeLayout(false);
			this.pnlHome.ResumeLayout(false);
			this.pnlHome.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlSideMenu.ResumeLayout(false);
			this.pnlMenu1.ResumeLayout(false);
			this.pnlSubMenuAddProducts.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlMain;
		private Panel pnlContant;
		private Panel pnlSideMenu;
		private Panel pnlMenu1;
		private Panel pnlShowCliked;
		private Button btnInvoiceProducts;
		private Panel pnlSubMenuAddProducts;
		private Button btnInsertProducts;
		private Button btnProducts;
		private Button btnLogout;
		private Panel pnlMenuBottomMargin;
		private Button btnHome;
		private Panel pnlMenuLogo;
		private Panel pnlHeader;
		private Panel panel2;
		private Button btnRegisterUsers;
		private Button btnOrderProducts;
		private Panel pnlHome;
		private Label label3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
	}
}