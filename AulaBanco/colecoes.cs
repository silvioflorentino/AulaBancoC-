using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaBanco
{
    public partial class colecoes : Form
    {
        public colecoes()
        {
            InitializeComponent();
        }

        private void buttonMatriz_Click(object sender, EventArgs e)
        {

            //linhas e colunas
            string[,] alunos = { 
                                  {"Robson","8","8"},
                                  {"Rob","9","9"},
                                  {"Sonia","10","10"}
                               };

            listBoxExemplo.Items.Add("Aluno " + alunos[0, 0] + " Mensal "
                + alunos[0, 1] + " Trim " + alunos[0, 2]);
            
            foreach (string fruta in alunos)
            {
                listBoxExemplo.Items.Add(fruta);
            }


        }

        private void buttonVetor_Click(object sender, EventArgs e)
        {
            string[] frutas = { "Banana", "Uva", "Laranja" };

            foreach(string fruta in frutas)
            {
                listBoxExemplo.Items.Add(fruta);
            }
            
            
        }
    }
}
