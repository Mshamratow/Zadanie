namespace Zadanie
{
    public partial class Form1 : Form
    {
        List<List<string>> people = new List<List<string>> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            people = new List<List<string>>();
            string text_c = File.ReadAllText("Candidats.txt");
            string text_p = File.ReadAllText("Positions.txt");
            string[] rows_c = text_c.Split("\n");
            string[] rows_p = text_p.Split("\n");
            for (int i = 0; i < rows_c.Length; i++)
            {
                var list = new List<string> ();
                string[] values = rows_c[i].Split(';');
                dataGridView1.Rows.Add(values[1]);
                list.Add(values[0]);
                list.Add(values[1]);
                list.Add(rows_p[i].Split(";")[1]);
                list.Add(values[3]);
                people.Add(list);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= people.Count || e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;

            textBox1.Text = people[index][0];
            textBox2.Text = people[index][1];
            textBox3.Text = people[index][2];
            richTextBox1.Text = people[index][3];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
