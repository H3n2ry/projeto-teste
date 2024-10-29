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
    public partial class frm_crediario : Form
    {
        string nome;
        double renda;
        double valor_compra;
        public frm_crediario()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            apresentacao apresentacao = new apresentacao();
            if (guna2MessageDialog2.Show("Deseja voltar para tela inicial ?") == DialogResult.Yes)
            {
                apresentacao.Show();
                Hide();
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                dialogo1.Show("digite apenas letras");
                txt_nome.Focus();               
            }
            if (e.KeyChar == 13)
            {
                if (txt_nome.Text != "")
                {
                    nome = txt_nome.Text;
                    if (dialogo.Show("Seu nome é " + nome + "?") == DialogResult.No)
                    {
                        txt_nome.Focus();
                        txt_nome.Clear();
                    }
                    else
                    {
                        txt_renda.Enabled = true;
                        txt_nome.Enabled = false;
                        txt_renda.Focus();
                    }
                    
                   
                }
                else
                {
                    dialogo1.Show("Cadê o seu nome ?");
                }
            }
        }

        private void txt_renda_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                dialogo1.Show("digite apenas númereos");
            }
            if (e.KeyChar == 13)
            {
                if (txt_renda.Text != "")
                {
                    renda = double.Parse(txt_renda.Text);
                    txt_renda.Text = renda.ToString("c2");
                    nome = txt_nome.Text;
                    if (dialogo.Show("Sua renda é R$ " + renda + "?") == DialogResult.No)
                    {
                        txt_renda.Focus();
                        txt_renda.Clear();
                    }
                    else
                    {
                        txt_vdacompra.Enabled = true;
                        txt_renda.Enabled = false;
                        txt_vdacompra.Focus();
                    }

                }
                else
                {
                    dialogo1.Show("Qual é sua renda?");
                }
            }
        }

        private void txt_vdacompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                dialogo1.Show("digite apenas númereos");
            }
            if (e.KeyChar == 13)
            {
                if (txt_vdacompra.Text != "")
                {
                    valor_compra = double.Parse(txt_vdacompra.Text);
                    //renda = double.Parse(txt_renda.Text);
                    txt_vdacompra.Text = valor_compra.ToString("c2");
                    txt_renda.Text = renda.ToString("c2");
                    nome = txt_nome.Text;
                    if (dialogo.Show("A sua compra deu R$ " + valor_compra + "?") == DialogResult.No)
                    {
                        txt_vdacompra.Focus();
                        txt_vdacompra.Clear();
                    }
                    else if (renda > valor_compra)
                    {
                        guna2MessageDialog1.Show("Parabéns " + nome + " sua compra foi liberada");
                        txt_nome.Enabled = true;
                        txt_renda.Enabled = true;
                        txt_nome.Focus();
                        txt_nome.Clear();
                        txt_renda.Clear();
                        txt_vdacompra.Clear();
                        txt_renda.Enabled = false;
                        txt_vdacompra.Enabled = false;
                    }
                    else if (renda == valor_compra)
                    {
                        guna2MessageDialog1.Show("Prarabéns " + nome + " sua compra foi liberada");
                        txt_nome.Enabled = true;
                        txt_renda.Enabled = true;
                        txt_nome.Focus();
                        txt_nome.Clear();
                        txt_renda.Clear();
                        txt_vdacompra.Clear();
                        txt_renda.Enabled = false;
                        txt_vdacompra.Enabled = false;
                    }
                    else
                    {
                        guna2MessageDialog1.Show(nome + " infelizmente sua compra não vai poder ser liberada");
                        txt_nome.Enabled = true;
                        txt_renda.Enabled = true;
                        txt_nome.Focus();
                        txt_nome.Clear();
                        txt_renda.Clear();
                        txt_vdacompra.Clear();
                        txt_renda.Enabled = false;
                        txt_vdacompra.Enabled = false;
                    }


                }
                else
                {
                    dialogo1.Show("Quanto deu sua compra?");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
