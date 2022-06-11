using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=DESKTOP-VDQPO57;Initial Catalog=dsbd;Integrated Security=True";
        private string strSql = "";
        SqlConnection objConect = null;
        SqlCommand objCommand = null;

        private void limparTexts()
        {
            txtCodigoRegistro.Clear();
            txtCalibre.Clear();
            txtValor.Clear();
            txtDataFabric.Clear();
            txtFornecedor.Clear();
            txtLote.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //contrução da instrução sql de cadastro de registro
            strSql = "insert into Armas(CR, Calibre, Preco, Data_fabricacao, Nome_fornecedor, Lote) values (@CR, @Calibre, @Preco, @Data_fabricacao, @Nome_fornecedor, @Lote)";

            // Abertura da tabela no sqlcon: objeto que representa o banco de dados
            sqlCon = new SqlConnection(strCon);

            //objeto que representa a instrução sql de cadastro
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //adiciona o conteudo do Text na váriavel do banco de dados
            comando.Parameters.Add("@CR", SqlDbType.VarChar).Value = txtCodigoRegistro.Text;
            comando.Parameters.Add("@Calibre", SqlDbType.VarChar).Value = txtCalibre.Text;
            comando.Parameters.Add("@Preco", SqlDbType.Real).Value = txtValor.Text;
            comando.Parameters.Add("@Data_fabricacao", SqlDbType.Date).Value = txtDataFabric.Text;
            comando.Parameters.Add("@Nome_fornecedor", SqlDbType.VarChar).Value = txtFornecedor.Text;
            comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = txtLote.Text;

            //está de fato abrindo a conexão
            sqlCon.Open();

            //executar um intrucao simples de 1 para 1
            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastro Finalizado");

            sqlCon.Close();

            limparTexts();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Armas where CR = @CR";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CR", SqlDbType.VarChar).Value = txtCodigoRegistro.Text;

            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if(dr.HasRows == true)
            {
                dr.Read();
                txtCalibre.Text = Convert.ToString(dr["Calibre"]);
                txtValor.Text = Convert.ToString(dr["Preco"]);
                txtDataFabric.Text = Convert.ToString(dr["Data_fabricacao"]);
                txtFornecedor.Text = Convert.ToString(dr["Nome_fornecedor"]);
                txtLote.Text = Convert.ToString(dr["Lote"]);
            }
            else
            {
                MessageBox.Show("Esse registro não existe");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Construção da instrução de cadastro de registro
            strSql = "update Armas set Calibre = @Calibre, Preco = @Preco, Data_fabricacao = @Data_fabricacao, Nome_fornecedor = @Nome_fornecedor, Lote = @lote where CR = @CR";

            //Abertura da tabela no sqlcon : objeto que representa o banco de dados
            sqlCon = new SqlConnection(strCon);

            //objeto que representa a instrucao sql de cadastro
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //adicionar o parametro CR nesta instrucao do int varchar
            comando.Parameters.Add("@CR", SqlDbType.VarChar).Value = txtCodigoRegistro;
            comando.Parameters.Add("@Calibre", SqlDbType.VarChar).Value = txtCalibre.Text;
            comando.Parameters.Add("@Preco", SqlDbType.Real).Value = txtValor.Text;
            comando.Parameters.Add("@Data_fabricacao", SqlDbType.Date).Value = txtDataFabric.Text;
            comando.Parameters.Add("@Nome_fornecedor", SqlDbType.VarChar).Value = txtFornecedor.Text;
            comando.Parameters.Add("@Lote", SqlDbType.VarChar).Value = txtLote.Text;

            //está de fato abrindo a conexao
            sqlCon.Open();

            //executar uma instruçao simples 1 para 1
            comando.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso");

        }
    }
}
