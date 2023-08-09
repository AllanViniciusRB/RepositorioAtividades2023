using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridView LinhaSelecionada;
        public FrmCadastroLivro()
        {
            InitializeComponent();

            //String de conexão
            conexaoString = "Data Source=MAR0625640W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de dados
            conexaoDB = new SqlConnection(conexaoString);
        }
        public void carregarDadosLivros()
        {
            try
            {
                string sql = "select * from livros";
                
                conexaoDB.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["Numero_Pagina"].ColumnName = "N° Página";
                dataTable.Columns["Ano_Producao"].ColumnName = "Ano Produção";
                dataTable.Columns["Preco"].ColumnName = "Valor do Livro";
                dataTable.Columns["Isbn"].ColumnName = "ISBN";
                dgvLivro.DataSource = dataTable;

                conexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO livros (Titulo, Autor, Numero_Pagina, Preco, Ano_Producao, Isbn) VALUES (@Titulo, @Autor, @Numero_Pagina, @Preco, @Ano_Producao, @Isbn)";

            try
            {
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@Autor", txtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@Numero_Pagina", Convert.ToInt32(txtNumeroPagina.Text));
                sqlCmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(txtPreco.Text));
                sqlCmd.Parameters.AddWithValue("@Ano_Producao", Convert.ToInt32(txtAnoPublicacao.Text));
                sqlCmd.Parameters.AddWithValue("@Isbn", txtISBN.Text);

                conexaoDB.Open();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                conexaoDB.Close();
                carregarDadosLivros();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar os dados: " + ex);
            }
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            carregarDadosLivros();
        }

        private void dgvLivro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {

            }
        }
    }
}
