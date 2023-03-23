using System.Windows.Forms;

namespace CarPartsOnlineStore.UI
{
	partial class InvoiceForm
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
			this.dgvInvoices = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Algerian", 20.25F);
			this.label2.Location = new System.Drawing.Point(251, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 30);
			this.label2.TabIndex = 35;
			this.label2.Text = "Invoice";
			// 
			// dgvInvoices
			// 
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
			this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvInvoices.Location = new System.Drawing.Point(11, 150);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvInvoices.RowHeadersVisible = false;
			this.dgvInvoices.Size = new System.Drawing.Size(577, 356);
			this.dgvInvoices.TabIndex = 38;
			this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(415, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Search";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSearch.Location = new System.Drawing.Point(456, 125);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(133, 20);
			this.txtSearch.TabIndex = 36;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// InvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(599, 517);
			this.ControlBox = false;
			this.Controls.Add(this.dgvInvoices);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InvoiceForm";
			this.Text = "InvoiceForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.InvoiceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label2;
		private DataGridView dgvInvoices;
		private Label label3;
		private TextBox txtSearch;
	}
}