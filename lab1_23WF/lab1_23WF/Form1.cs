namespace lab1_23WF
{
	public partial class Form1 : Form
	{
		int size = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int sum = 0;
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				if (String.IsNullOrEmpty(dataGridView1[i, i].FormattedValue.ToString())
					|| int.Parse("" + dataGridView1[i, i].Value) % 2 == 0)
				{
					for (int j = 0; j < dataGridView1.RowCount; j++)
					{
						if (!String.IsNullOrEmpty(dataGridView1[j, i].FormattedValue.ToString()))
						{
							sum += int.Parse("" + dataGridView1[j, i].Value);
						}
					}

				}
			}
			textBox1.Text = sum.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			size += 1;
			dataGridView1.Columns.Add("column" + size, "");
			dataGridView1.Rows.Add();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			size -= 1;
			dataGridView1.Rows.RemoveAt(size);
			dataGridView1.Columns.RemoveAt(size);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}