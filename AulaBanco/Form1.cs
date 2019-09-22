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

namespace AulaBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                buttonAlterar.Enabled = false;
                buttonExcluir.Enabled = false;
                buttonGravar.Enabled = false;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão de busca
            //primeiro verificando se tem valor digitado na caixa busca
            
            
            if (textBoxbusca.Text == "")
            {
                MessageBox.Show("Digite um código no campo busca", "Atenção");
                return;
            }

            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pcliente_consul_Porcodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", textBoxbusca.Text);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    labelcodigo.Text = dr["codigo"].ToString();
                    textBoxnome.Text = dr["nome"].ToString();
                    textBoxemail.Text = dr["email"].ToString();
                    comboBoxcidade.Text = dr["cidade"].ToString();
                    //botão habilitar
                    buttonAlterar.Enabled = true;
                    buttonExcluir.Enabled = true;
                    //botão gravar desabilitar
                    buttonGravar.Enabled = false;
                    textBoxbusca.Clear();

                }
                else
                {

                   
                    MessageBox.Show("Aluno não localizado!",
               "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Question);
                   
                    buttonAlterar.Enabled = false;
                    buttonExcluir.Enabled = false;
                    buttonGravar.Enabled = false;
                    textBoxbusca.Clear();
                    textBoxemail.Clear();
                    textBoxnome.Clear();
                    labelcodigo.ResetText();
                   
                    

                }
            
             
            }
            
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }



       

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            //Codigo para gravar no banco 

            
            
            //3 linhas de acesso ao banco
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pinserir",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
               
                cmd.Parameters.AddWithValue("@nome",textBoxnome.Text);
                cmd.Parameters.AddWithValue("@email",textBoxemail.Text);
                cmd.Parameters.AddWithValue("@cidades",comboBoxcidade.Text);
                
                
                SqlParameter nv = cmd.Parameters.Add("@codigo",SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                
                cn.Open();
                cmd.ExecuteNonQuery();
                labelcodigo.Text = nv.Value.ToString();
                var resposta = 
                    MessageBox.Show("Cliente Cadastrado com sucesso, Deseja adicionar outro cliente ou sair",
                "Novo Registro",MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    textBoxnome.Clear();
                    textBoxemail.Clear();
                    labelcodigo.ResetText();

                }
                else
                {

                    this.Close();
                }
            
            
            }
            catch
            {
                MessageBox.Show("Cliente não cadastrado tente novamente cod456","Atenção");
            }
            finally
            {
                if(cn.State == ConnectionState.Open){cn.Close();}

            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pcliente_UPd_PorCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@codigo",labelcodigo.Text);
                cmd.Parameters.AddWithValue("@nome", textBoxnome.Text);
                cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                   
                
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com sucesso", "Atenção");



            }
            catch
            {
                MessageBox.Show("Cliente não alterado");
                
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pcliente_del_Porcodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", labelcodigo.Text);
                var resposta =
                MessageBox.Show(
                "Deseja mesmo excluir este usuário?",
                "Alerta de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                {
                    return;
                }

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário excluído com sucesso!");

                labelcodigo.ResetText();
                textBoxnome.Clear();
                textBoxemail.Clear();
                buttonAlterar.Enabled = false;
                buttonExcluir.Enabled = false;

            }
            
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        private void textBoxnome_TextChanged(object sender, EventArgs e)
        {
            buttonGravar.Enabled = true;
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
