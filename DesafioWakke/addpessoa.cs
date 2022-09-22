using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWakke
{
    public partial class addpessoa : Form
    {
        public addpessoa()
        {
            InitializeComponent();
        }
        public addpessoa(string idSelecionado)
        {
            InitializeComponent();
            idPessoa.Text = idSelecionado;

        }

        string ativo = "false";

        public void atualizarDados()
        {
            SQLiteConnection conn3 = new SQLiteConnection(@"data source = C:\Users\Filipe\Desktop\projetoWakke\DesafioWakke\DesafioWakke\bin\Debug\wakke.db");
            conn3.Open();
            string query3 = "UPDATE pessoa SET ativo = '" + ativo + "',nome = '" + textBox1.Text + "', sobrenome = '" + textBox2.Text + "', dataNascimento = '" + maskedTextBox4.Text + "', altura = '" + maskedTextBox3.Text + "' WHERE idPessoa = '"+idPessoa.Text+"'";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn3);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd3);
            adapter.Fill(dt);

            conn3.Close();
        }

        public void conexao2()
        {
            SQLiteConnection conn2 = new SQLiteConnection(@"data source = C:\Users\Filipe\Desktop\projetoWakke\DesafioWakke\DesafioWakke\bin\Debug\wakke.db");
            conn2.Open();
            string query2 = "INSERT INTO pessoa (ativo, nome, sobrenome, datanascimento, altura)values('"+ativo+"','" + textBox1.Text+"','"+textBox2.Text+ "','"+ maskedTextBox4.Text+ "','"+ maskedTextBox3.Text+"')" ;
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn2);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd2);
            adapter.Fill(dt);

            conn2.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && maskedTextBox3.Text != "" && maskedTextBox4.Text != "")
            {
                
                if (idPessoa.Text == "")
                {
                    conexao2();
                    this.Close();
                }
                else
                {
                    atualizarDados();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Nome VAZIO");
            }
            
            
        }

        private void addpessoa_Load(object sender, EventArgs e)
        {
            if(idPessoa.Text != "")
            {
                EditarDados();
            }
        }

        public void EditarDados()
        {
            SQLiteConnection conn3 = new SQLiteConnection(@"data source = C:\Users\Filipe\Desktop\projetoWakke\DesafioWakke\DesafioWakke\bin\Debug\wakke.db");
            conn3.Open();
            string query = "SELECT * FROM pessoa where idPessoa='"+idPessoa.Text+"'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn3);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
            conn3.Close();
            ativo = dataGridView2.Rows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
            maskedTextBox3.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
            maskedTextBox4.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ativo = "true";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ativo = "false";
        }
    }
}
