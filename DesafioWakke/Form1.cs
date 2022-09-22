using System.Data;
using System.Data.SQLite;

namespace DesafioWakke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conexao();
        }

        string idSelecionado;

        public void conexao()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Filipe\Desktop\projetoWakke\DesafioWakke\DesafioWakke\bin\Debug\wakke.db");
            conn.Open();
            string query = "SELECT * FROM pessoa";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }       
        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void aDDPESSOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpessoa add = new addpessoa();
            add.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao();
        }

        public void DeletarDados()
        {
            SQLiteConnection conn2 = new SQLiteConnection(@"data source = C:\Users\Filipe\Desktop\projetoWakke\DesafioWakke\DesafioWakke\bin\Debug\wakke.db");
            conn2.Open();
            string query2 = "DELETE FROM pessoa WHERE idPessoa = '"+idSelecionado+"'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn2);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd2);
            adapter.Fill(dt);

            conn2.Close();

        }

        private void eXCLUIRSELECIONADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 

            idSelecionado = dataGridView1.SelectedCells[0].Value.ToString();
            DeletarDados();
            conexao();

            }

            catch(Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void eDITARSELECIONADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idSelecionado = dataGridView1.SelectedCells[0].Value.ToString();
            addpessoa add2 = new addpessoa(idSelecionado);
            add2.ShowDialog();
        }
    }
}