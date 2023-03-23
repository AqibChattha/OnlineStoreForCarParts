using System.Windows.Forms;

namespace CarPartsOnlineStore.UI
{
	partial class OrderForm
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
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudStock = new System.Windows.Forms.NumericUpDown();
			this.btnOrder = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Algerian", 20.25F);
			this.label2.Location = new System.Drawing.Point(258, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 30);
			this.label2.TabIndex = 5;
			this.label2.Text = "Order";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvProducts);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Location = new System.Drawing.Point(10, 101);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 406);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Product";
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
			this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvProducts.Location = new System.Drawing.Point(6, 44);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvProducts.RowHeadersVisible = false;
			this.dgvProducts.Size = new System.Drawing.Size(283, 356);
			this.dgvProducts.TabIndex = 35;
			this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
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
			this.groupBox2.Controls.Add(this.btnOrder);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(310, 101);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 167);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Order Products";
			// 
			// nudStock
			// 
			this.nudStock.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudStock.Location = new System.Drawing.Point(36, 75);
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
			// btnOrder
			// 
			this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.Location = new System.Drawing.Point(209, 138);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(64, 23);
			this.btnOrder.TabIndex = 1;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "Select Quantity";
			// 
			// OrderForm
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
			this.Name = "OrderForm";
			this.Text = "OrderForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OrderForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label2;
		private GroupBox groupBox1;
		private DataGridView dgvProducts;
		private Label label1;
		private TextBox txtSearch;
		private GroupBox groupBox2;
		private NumericUpDown nudStock;
		private Button btnOrder;
		private Label label5;
	}
}