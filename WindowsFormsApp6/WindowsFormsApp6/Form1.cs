using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexaoString = "server=localhost;user=root;password=;database=db_quiz_p;";


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string pergunta = "";
            string alternativaA = "", alternativaB = "", alternativaC = "", alternativaD = "";
            long ultimoID = 0;


            pergunta = rtxPergunta.Text;
            alternativaA = txbAlternativaA.Text;
            alternativaB = txbAlternativaB.Text;
            alternativaC = txbAlternativaC.Text;
            alternativaD = txbAlternativaD.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                conexao.Open();
                string scriptInsertQuestao = "INSERT INTO tb_perguntas (questao) VALUE (@questao)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsertQuestao, conexao))
                {
                    //Substitue os parametros para os valores reais
                    comando.Parameters.AddWithValue("@questao", pergunta);

                    comando.ExecuteNonQuery();

                    ultimoID = comando.LastInsertedId;

                }

                string scriptInsertAlternativa = "INSERT INTO tb_alternativa (resposta, id_pergunta) VALUE (@resposta, @ultimoID)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsertAlternativa, conexao))
                {
                    //Substitue os parametros para os valores reais
                    comando.Parameters.AddWithValue("@resposta", alternativaA);
                    comando.Parameters.AddWithValue("@ultimoID", ultimoID);
                    comando.ExecuteNonQuery();

                }

                using (MySqlCommand comando = new MySqlCommand(scriptInsertAlternativa, conexao))
                {
                    //Substitue os parametros para os valores reais
                    comando.Parameters.AddWithValue("@resposta", alternativaB);
                    comando.Parameters.AddWithValue("@ultimoID", ultimoID);
                    comando.ExecuteNonQuery();

                }

                using (MySqlCommand comando = new MySqlCommand(scriptInsertAlternativa, conexao))
                {
                    //Substitue os parametros para os valores reais
                    comando.Parameters.AddWithValue("@resposta", alternativaC);
                    comando.Parameters.AddWithValue("@ultimoID", ultimoID);
                    comando.ExecuteNonQuery();

                }

                using (MySqlCommand comando = new MySqlCommand(scriptInsertAlternativa, conexao))
                {
                    //Substitue os parametros para os valores reais
                    comando.Parameters.AddWithValue("@resposta", alternativaD);
                    comando.Parameters.AddWithValue("@ultimoID", ultimoID);
                    comando.ExecuteNonQuery();

                }

            }
            MessageBox.Show("Pergunta cadastrada com sucesso\n" + ultimoID.ToString());
        }
    }
}
