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

    public partial class frm_contratacao : Form
    {
        string nome;
        int idade;
        string bairro;
        int anos;
        bool expe;
        public frm_contratacao()
        {
            InitializeComponent();
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

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                Dialog1.Show("digite apenas letras");
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
                        txt_idade.Enabled = true;
                        txt_nome.Enabled = false;
                        txt_idade.Focus();
                    }


                }
                else
                {
                    Dialog1.Show("Cadê o seu nome ?");
                }
            }
        }

        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                Dialog1.Show("digite apenas númereos");
            }
            if (e.KeyChar == 13)
            {
                if (txt_idade.Text != "")
                {
                    idade = int.Parse(txt_idade.Text);
                    nome = txt_nome.Text;
                    if (dialogo.Show("Sua idade é " + idade + "?") == DialogResult.No)
                    {
                            txt_idade.Focus();
                            txt_idade.Clear();
                    }
                    

                    else
                    {
                        if (idade >= 18 && idade<=50)
                        {
                             cb_regiao.Enabled = true;
                             txt_idade.Enabled = false;
                             cb_regiao.Focus();
                        }
                        else
                        {
                            Dialog1.Show("Só aceitamos pessoas com 18 a 50 anos");
                            txt_idade.Clear();
                            txt_idade.Focus();
                        }
                        
                    }
                    

                }
                else
                {
                    Dialog7.Show("Qual é sua renda?");
                }
            }
        }

        private void cb_regiao_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(cb_regiao.Text != "")
             {
                    ccb_expe.Enabled = true;
                    btn_dados.Enabled= true;
             }
        }

        private void ccb_expe_Click(object sender, EventArgs e)
        {
            if (ccb_expe.Checked == true)
            {
                nud_anos.Enabled = true;
                cb_regiao.Enabled = false;
            }
        }

        private void nud_anos_ValueChanged(object sender, EventArgs e)
        {
            if(nud_anos.Value == 0)
            {
                ccb_expe.Checked = false;
                nud_anos.Enabled = false;
            }
        }

        private void btn_dados_Click(object sender, EventArgs e)
        {
            anos = (int)nud_anos.Value;
            if (anos >= 1 && idade >= 18 && idade <= 50 && cb_regiao.Text == "Itaquera" | cb_regiao.Text == "Guaianases" | cb_regiao.Text == "São Matheus" | cb_regiao.Text == "Carrão")
            {
                
                Dialog4.Show(nome + " seu perfil está adequado para a vaga");
                Controls.Clear();
                InitializeComponent();
                txt_nome.Focus();
            }
            else
            {
                Dialog4.Show(nome + " infelizmente seu paifil não está de acordo com a vaga");
                Controls.Clear();
                InitializeComponent();
                txt_nome.Focus();
            }
        }
    }
}
