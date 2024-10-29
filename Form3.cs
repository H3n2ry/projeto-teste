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
    public partial class frm_futebol : Form
    {
        int idade;
        string nome;
        public frm_futebol()
        {
            InitializeComponent();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            apresentacao apresentacao = new apresentacao();
            apresentacao.Show();
            Hide();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                dialogo.Show("digite apenas letras");
            }
            if (e.KeyChar == 13)
            {
                if (txt_nome.Text != "")
                {
                    txt_idade.Focus();
                }
                else
                {
                    dialogo1.Show("Cadê o seu nome ?");
                }
            }
        }

        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                dialogo2.Show("digite apenas numeros");
            }
            if (e.KeyChar == 13)
            {
                if (txt_idade.Text != "")
                {
                    idade = int.Parse(txt_idade.Text);
                    nome = txt_nome.Text;
                    if (idade >= 5 && idade <= 10)
                    {
                        BackgroundImage = Properties.Resources.infantil;
                        dialogo3.Show("Parabens " + nome + ", vc está na categoria infantil");
                        BackgroundImage = Properties.Resources.campo_fut;
                        txt_idade.Clear();
                        txt_nome.Clear();

                    }
                    else if (idade >= 11 && idade <= 15)
                    {
                        BackgroundImage = Properties.Resources.juvenil;
                        dialogo3.Show("Parabens " + nome + ", vc está na categoria juvenil");
                        BackgroundImage = Properties.Resources.campo_fut;
                        txt_idade.Clear();
                        txt_nome.Clear();
                    }
                    else if (idade >= 16 && idade <= 20)
                    {
                        BackgroundImage = Properties.Resources.junior;
                        dialogo3.Show("Parabens " + nome + ", vc está na categoria Junior");
                        BackgroundImage = Properties.Resources.campo_fut;
                        txt_idade.Clear();
                        txt_nome.Clear();
                    }
                    else if (idade >= 21 && idade <= 25)
                    {
                        BackgroundImage = Properties.Resources.proficional;
                        dialogo3.Show("Parabens " + nome + ", vc está na categoria Proficional");
                        BackgroundImage = Properties.Resources.campo_fut;
                        txt_idade.Clear();
                        txt_nome.Clear();
                    }
                    else
                    {
                        BackgroundImage = Properties.Resources.Carita_triste;
                        dialogo4.Show(nome + ", infelizmente sua idade não foi aceita tenha de 5 à 25 anos");
                        BackgroundImage = Properties.Resources.campo_fut;
                        txt_idade.Clear();
                        txt_nome.Clear();
                        

                    }
                }
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
