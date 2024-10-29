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
    public partial class apresentacao : Form
    {
        public apresentacao()
        {
            InitializeComponent();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mes_Click(object sender, EventArgs e)
        {
            frm_meses _Meses = new frm_meses();
            if (dialogo1.Show ("Deseja trocar de tela?") == DialogResult.Yes)
            {
                _Meses.Show();
                Hide();
            }
        }

        private void btn_fut_Click(object sender, EventArgs e)
        {
            frm_futebol _Futebol = new frm_futebol();
            if (dialogo1.Show("Deseja trocar de tela?") == DialogResult.Yes)
            {
                _Futebol.Show();
                Hide();
            }
           
        }

        private void btn_eleicoes_Click(object sender, EventArgs e)
        {
            frm_eleicoes _Eleicoes = new frm_eleicoes();
            if (dialogo1.Show("Deseja trocar de tela?") == DialogResult.Yes)
            {
                _Eleicoes.Show();
                Hide();
            }
        }

        private void btn_crediario_Click(object sender, EventArgs e)
        {
            frm_crediario _Crediario = new frm_crediario();
            _Crediario.Show();
            Hide();
        }

        private void btn_contratacao_Click(object sender, EventArgs e)
        {
            frm_contratacao _Contratacao = new frm_contratacao();
            _Contratacao.Show();
            Hide();
        }
    }
}
