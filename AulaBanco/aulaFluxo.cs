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
    public partial class aulaFluxo : Form
    {
        public aulaFluxo()
        {
            InitializeComponent();
        }

        private void buttonIfelse_Click(object sender, EventArgs e)
        {
            int senha = Convert.ToInt16(textBoxIfelse.Text);

            if(senha >= 18)
            {
                MessageBox.Show("Acesso Permitido");
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            int senha = Convert.ToInt16(textBoxSwitch.Text);
            switch(senha)
            {
                case 123:
                    MessageBox.Show("Acesso Permitido");
                    break;

                case 1234:
                    MessageBox.Show("Acesso Negado");
                    break;

                default:
                    MessageBox.Show("Acesso Negado");
                    break;
            }
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            while(n1<=10)
            {
                listBoxExemplo.Items.Add(n1);
                n1++;
            }
        }

        private void buttonDowhile_Click(object sender, EventArgs e)
        {
            int n2 = 11;
            do{
                
                listBoxExemplo.Items.Add(n2);
                n2++;
            
            }while(n2<=10);
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                 listBoxExemplo.Items.Add(i);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            listBoxExemplo.Items.Clear();
        }
    }
}
