using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppCrud
{
    public partial class FrmCadastro : Form
    {
        public string connectionString = @"Server=BRSZW03396\SQLEXPRESS;Database=Banco;Trusted_Connection=True;";
        public bool novo;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            /*botões como Verdadeiros ou Falsos*/
            TsbNovo.Enabled = true;
            TsbSalvar.Enabled = false;
            TsbCancelar.Enabled = false;
            TsbExcluir.Enabled = false;
            TstId.Enabled = true;//TextBox ID dentro do tooStrip
            TsbBuscar.Enabled = true;

            /*TextBox como Verdadeiros ou Falsos*/
            TxtNome.Enabled = false;
            TxtEndereco.Enabled = false;
            MskCep.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUf.Enabled = false;
            MskTelefone.Enabled = false;
        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            /*botões como Verdadeiros ou Falsos*/
            TsbNovo.Enabled = false;
            TsbSalvar.Enabled = true;
            TsbCancelar.Enabled = true;
            TsbExcluir.Enabled = false;
            TstId.Enabled = false;//TextBox ID dentro do tooStrip
            TsbBuscar.Enabled = false;

            /*TextBox como Verdadeiros ou Falsos*/
            TxtNome.Enabled = true;
            TxtEndereco.Enabled = true;
            MskCep.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            TxtUf.Enabled = true;
            MskTelefone.Enabled = true;
            TxtNome.Focus();//Ao clicar em Novo TextBox Nome recebe o focu!
            novo = true;//ao clicar no botão Novo será incluído um novo registro,sem salvar no banco ainda!
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)//Consultar se existe registro; No caso de não houver irá inserir um "Novo"
            {
                string sql = "INSERT INTO CLIENTE (NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) " 
               + "VALUES" +"('" 
               + TxtNome.Text + "', '" 
               + TxtEndereco.Text + "', '" 
               + MskCep.Text + "', '" 
               + TxtBairro.Text + "', '" 
                + TxtCidade.Text + "', '" 
                + TxtUf.Text + "', '" 
                + MskTelefone.Text 
                + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME='" //Caso Registro já exista ira atualizar apenas!
               + TxtNome.Text + "',ENDERECO = '" 
               + TxtEndereco.Text + "', " + "CEP='" 
               + MskCep.Text + "', BAIRRO='" 
               + TxtBairro.Text + "', CIDADE = '" 
               + TxtCidade.Text + "', " +"UF='" 
               + TxtUf.Text + "', TELEFONE='" 
               + MskTelefone.Text + "' WHERE ID=" 
               + TxtId.Text;
        

        SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            //botões tooStrip's
            TsbNovo.Enabled = true;
            TsbSalvar.Enabled = false;
            TsbCancelar.Enabled = false;
            TsbExcluir.Enabled = false;
            TstId.Enabled = true;
            TsbBuscar.Enabled = true;

            //TextBoxs
            TxtNome.Enabled = false;
            TxtEndereco.Enabled = false;
            MskCep.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUf.Enabled = false;
            MskTelefone.Enabled = false;
            
            //limpando campos de textos
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtEndereco.Text = "";
            MskCep.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUf.Text = "";
            MskTelefone.Text = "";
        }

        private void TsbCancelar_Click(object sender, EventArgs e)//Botão cancelar apenas limpa os TextBox e ativa novamento os Botões: Novo/Buscar/TextId
        {
            
            //botões tooStrip's
            TsbNovo.Enabled = true;
            TsbSalvar.Enabled = false;
            TsbCancelar.Enabled = false;
            TsbExcluir.Enabled = false;
            TstId.Enabled = true;
            TsbBuscar.Enabled = true;

            //TextBoxs
            TxtNome.Enabled = false;
            TxtEndereco.Enabled = false;
            MskCep.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUf.Enabled = false;
            MskTelefone.Enabled = false;

            //limpando campos de textos
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtEndereco.Text = "";
            MskCep.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUf.Text = "";
            MskTelefone.Text = "";
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CLIENTE WHERE ID=" + TxtId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            //botões tooStrip's
            TsbNovo.Enabled = true;
            TsbSalvar.Enabled = false;
            TsbCancelar.Enabled = false;
            TsbExcluir.Enabled = false;
            TstId.Enabled = true;
            TsbBuscar.Enabled = true;

            //TextBoxs
            TxtNome.Enabled = false;
            TxtEndereco.Enabled = false;
            MskCep.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUf.Enabled = false;
            MskTelefone.Enabled = false;

            //limpando os campos de textos
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtEndereco.Text = "";
            MskCep.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUf.Text = "";
            MskTelefone.Text = "";
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID=" + TstId.Text;//select basico na tabela pelo campo TooStrip Id.Text

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();//objeto reader armazena o conteúdo retornado da consulta
                if (reader.Read())
                {
                    //botões tooStrip's
                    TsbNovo.Enabled = false;
                    TsbSalvar.Enabled = true;
                    TsbCancelar.Enabled = true;
                    TsbExcluir.Enabled = true;
                    TstId.Enabled = false;
                    TsbBuscar.Enabled = false;

                    //TextBox's
                    TxtNome.Enabled = true;
                    TxtEndereco.Enabled = true;
                    MskCep.Enabled = true;
                    TxtBairro.Enabled = true;
                    TxtCidade.Enabled = true;
                    TxtUf.Enabled = true;
                    MskTelefone.Enabled = true;

                    TxtNome.Focus();//Focu retorno campo TextBox Nome!

                    //Parametro irá consultar todos campos abaixo com seus respectivos indices 0 á 7 e converter para string
                    TxtId.Text = reader[0].ToString();
                    TxtNome.Text = reader[1].ToString();
                    TxtEndereco.Text = reader[2].ToString();
                    MskCep.Text = reader[3].ToString();
                    TxtBairro.Text = reader[4].ToString();
                    TxtCidade.Text = reader[5].ToString();
                    TxtUf.Text = reader[6].ToString();
                    MskTelefone.Text = reader[7].ToString();

                    novo = false;//botão novo retornara desativado como valor falso, pois é uma consulta não irá inserir novos registros
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o Id informado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            TstId.Text = "";
           
         }
    }
}
