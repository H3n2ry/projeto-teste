using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_teste
{
    public partial class frm_meses : Form
    {
        int mes;
        public frm_meses()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            apresentacao apresentacao = new apresentacao();
            if (dialogo.Show("Deseja voltar para tela inicial ?") == DialogResult.Yes)
            {
                apresentacao.Show();
                Hide();
            }
        }

        private void txt_nmes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                dialogo1.Show("digite apenas numeros");
            }
            if (e.KeyChar == 13)
            {
                if (txt_nmes.Text != "")
                {
                    mes = int.Parse(txt_nmes.Text);
                    if (mes == 1)
                    {
                        lbl_mes.Text = "Janeiro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 2)
                    {
                        lbl_mes.Text = "Fevereiro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 3)
                    {
                        lbl_mes.Text = "Março";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 4)
                    {
                        lbl_mes.Text = "Abriu";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 5)
                    {
                        lbl_mes.Text = "Maio";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 6)
                    {
                        lbl_mes.Text = "Junho";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 7)
                    {
                        lbl_mes.Text = "Julho";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 8)
                    {
                        lbl_mes.Text = "Agosto";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 9)
                    {
                        lbl_mes.Text = "Setembro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 10)
                    {
                        lbl_mes.Text = "Outubro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 11)
                    {
                        lbl_mes.Text = "Novembro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else if (mes == 12)
                    {
                        lbl_mes.Text = "Dezembro";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                    else
                    {
                        dialogo2.Show("Não existe esse mês né amigo :)");
                        lbl_mes.Text = "2024";
                        txt_nmes.Clear();
                        txt_nmes.Focus();
                    }
                }
                else
                {
                    dialogo3.Show("Como vou te falar sem saber qual é o numero?");
                    txt_nmes.Clear();
                    txt_nmes.Focus();
                }
            }
        }
    }
}
