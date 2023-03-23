namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System;
	using System.Data;
	using System.Windows.Forms;

	public partial class ProductsForm : Form
	{
		private static ProductsForm _instance;

		public static ProductsForm Instance
		{
			get
			{
				if (_instance == null)
					_instance = new ProductsForm();
				return _instance;
			}
		}

		public ProductsForm()
		{
			InitializeComponent();
			this.TopLevel = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			LoadDataInDGV(textBox1.Text);
		}

		private void ProductsForm_Load(object sender, EventArgs e)
		{

			DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.HeaderText = "Details";
			btn.Text = "Details";
			btn.Name = "details";
			btn.UseColumnTextForButtonValue = true;

			LoadDataInDGV();
		}

		private void LoadDataInDGV(string serchedText = "")
		{
			try
			{
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				DataTable table = new DataTable();
				MySqlCommand command = new MySqlCommand("SELECT p.name AS `Product Name`, p.description AS `Description`, p.stock AS `Stock`, p.price AS `Price`, s.name AS seller_name, s.email AS seller_email," +
					" s.phone AS seller_phone, s.address AS seller_address FROM (SELECT * FROM product) p JOIN seller s ON p.seller_id = s.id WHERE CONCAT(p.name, p.description, p.stock, p.price) LIKE '%" + serchedText + "%'", DBConfiguration.Instance.Connection);
				adapter.SelectCommand = command;
				adapter.Fill(table);
				dataGridView1.DataSource = table;
				dataGridView1.Columns[5].Visible = false;
				dataGridView1.Columns[6].Visible = false;
				dataGridView1.Columns[7].Visible = false;
				dataGridView1.Columns[8].Visible = false;
				dataGridView1.Columns["details"].DisplayIndex = dataGridView1.Columns.Count - 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void RefreshData()
		{
			textBox1.Text = "";
			LoadDataInDGV();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				if (e.ColumnIndex == 0)
				{
					string details = "Product Name: " + row.Cells[1].Value.ToString() + "\n" +
						"Description: " + row.Cells[2].Value.ToString() + "\n" +
						"Stock: " + row.Cells[3].Value.ToString() + "\n" +
						"Price: " + row.Cells[4].Value.ToString() + "\n\n" +
						"Seller Name: " + row.Cells[5].Value.ToString() + "\n" +
						"Seller Email: " + row.Cells[6].Value.ToString() + "\n" +
						"Seller Phone: " + row.Cells[7].Value.ToString() + "\n" +
						"Seller Address: " + row.Cells[8].Value.ToString() + "\n";

					MessageBox.Show(details, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
