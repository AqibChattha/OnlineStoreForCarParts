using System.Windows.Forms;

namespace CarPartsOnlineStore.UI
{
	partial class InsertProductForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvSeller = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudStock = new System.Windows.Forms.NumericUpDown();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Algerian", 20.25F);
			this.label2.Location = new System.Drawing.Point(213, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 30);
			this.label2.TabIndex = 31;
			this.label2.Text = "Add Products";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvSeller);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Location = new System.Drawing.Point(10, 101);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 406);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sellers";
			// 
			// dgvSeller
			// 
			this.dgvSeller.AllowUserToAddRows = false;
			this.dgvSeller.AllowUserToDeleteRows = false;
			this.dgvSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvSeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSeller.BackgroundColor = System.Drawing.Color.White;
			this.dgvSeller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeller.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvSeller.Location = new System.Drawing.Point(6, 44);
			this.dgvSeller.Name = "dgvSeller";
			this.dgvSeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvSeller.RowHeadersVisible = false;
			this.dgvSeller.Size = new System.Drawing.Size(283, 356);
			this.dgvSeller.TabIndex = 35;
			this.dgvSeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 34;
			this.label1.Text = "Search";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSearch.Location = new System.Drawing.Point(158, 19);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(133, 20);
			this.txtSearch.TabIndex = 33;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudStock);
			this.groupBox2.Controls.Add(this.txtDescription);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Location = new System.Drawing.Point(310, 101);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 406);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Product Info";
			// 
			// nudStock
			// 
			this.nudStock.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudStock.Location = new System.Drawing.Point(33, 237);
			this.nudStock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudStock.Name = "nudStock";
			this.nudStock.Size = new System.Drawing.Size(206, 20);
			this.nudStock.TabIndex = 36;
			this.nudStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.White;
			this.txtDescription.Location = new System.Drawing.Point(33, 127);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(206, 84);
			this.txtDescription.TabIndex = 35;
			this.txtDescription.Text = "";
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(203, 370);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(64, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Description";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "Price";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "Stock";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "Name";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(33, 289);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(206, 20);
			this.txtPrice.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(33, 77);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(206, 20);
			this.txtName.TabIndex = 0;
			// 
			// InsertProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(599, 517);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InsertProductForm";
			this.Text = "InsertProductForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.InsertProductForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label2;
		private GroupBox groupBox1;
		private DataGridView dgvSeller;
		private Label label1;
		private TextBox txtSearch;
		private GroupBox groupBox2;
		private RichTextBox txtDescription;
		private Button btnAdd;
		private Label label4;
		private Label label5;
		private Label label3;
		private TextBox txtPrice;
		private TextBox txtName;
		private NumericUpDown nudStock;
		private Label label6;
	}
}