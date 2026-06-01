using MySql.Data.MySqlClient;

namespace testeClau
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;database=db_agenda;uid=root;pwd=root;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(data_source);
                conexao.Open();

                MessageBox.Show("Conexão bem-sucedida!");

                string insert = "INSERT INTO contato (nome, email, telefone) VALUES ('" + textName.Text + "', '" + textEmail.Text + "', '" + textTelefone.Text + "')";

                MySqlCommand comando = new MySqlCommand(insert, conexao);

                comando.ExecuteReader();

                MessageBox.Show("Inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
