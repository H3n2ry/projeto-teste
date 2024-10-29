
namespace projeto_teste
{
    partial class frm_contratacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fechar = new Guna.UI2.WinForms.Guna2Button();
            this.cb_regiao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dialogo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.nud_anos = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccb_expe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog4 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog5 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog6 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Dialog7 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btn_dados = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Animated = true;
            this.btn_fechar.AutoRoundedCorners = true;
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.BorderColor = System.Drawing.Color.Aqua;
            this.btn_fechar.BorderRadius = 24;
            this.btn_fechar.BorderThickness = 2;
            this.btn_fechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.IndicateFocus = true;
            this.btn_fechar.Location = new System.Drawing.Point(975, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.PressedColor = System.Drawing.Color.Aqua;
            this.btn_fechar.Size = new System.Drawing.Size(52, 50);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // cb_regiao
            // 
            this.cb_regiao.BackColor = System.Drawing.Color.Transparent;
            this.cb_regiao.BorderColor = System.Drawing.Color.Aqua;
            this.cb_regiao.BorderRadius = 15;
            this.cb_regiao.BorderThickness = 2;
            this.cb_regiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_regiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_regiao.Enabled = false;
            this.cb_regiao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.cb_regiao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_regiao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_regiao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_regiao.ForeColor = System.Drawing.Color.White;
            this.cb_regiao.ItemHeight = 30;
            this.cb_regiao.Items.AddRange(new object[] {
            "Itaquera",
            "Guaianazes",
            "Itaim Paulista",
            "Carrão",
            "Arthur Alvim",
            "São Matheus",
            "Horto Florestal",
            "Vila Curuça",
            "José Bonifácio",
            "Ferraz",
            "Robru",
            "Lageado"});
            this.cb_regiao.Location = new System.Drawing.Point(560, 272);
            this.cb_regiao.Name = "cb_regiao";
            this.cb_regiao.Size = new System.Drawing.Size(250, 36);
            this.cb_regiao.TabIndex = 11;
            this.cb_regiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_regiao.SelectedIndexChanged += new System.EventHandler(this.cb_regiao_SelectedIndexChanged);
            // 
            // dialogo
            // 
            this.dialogo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.dialogo.Caption = null;
            this.dialogo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.dialogo.Parent = this;
            this.dialogo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo.Text = null;
            // 
            // Dialog2
            // 
            this.Dialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.Dialog2.Caption = null;
            this.Dialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.Dialog2.Parent = this;
            this.Dialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog2.Text = null;
            // 
            // nud_anos
            // 
            this.nud_anos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_anos.AutoRoundedCorners = true;
            this.nud_anos.BackColor = System.Drawing.Color.Transparent;
            this.nud_anos.BorderColor = System.Drawing.Color.Aqua;
            this.nud_anos.BorderRadius = 13;
            this.nud_anos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_anos.Enabled = false;
            this.nud_anos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.nud_anos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nud_anos.ForeColor = System.Drawing.Color.White;
            this.nud_anos.Location = new System.Drawing.Point(743, 353);
            this.nud_anos.Name = "nud_anos";
            this.nud_anos.Size = new System.Drawing.Size(67, 29);
            this.nud_anos.TabIndex = 12;
            this.nud_anos.UpDownButtonFillColor = System.Drawing.Color.Aqua;
            this.nud_anos.UseTransparentBackground = true;
            this.nud_anos.ValueChanged += new System.EventHandler(this.nud_anos_ValueChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.BorderColor = System.Drawing.Color.Aqua;
            this.txt_nome.BorderRadius = 15;
            this.txt_nome.BorderThickness = 2;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.DefaultText = "";
            this.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.White;
            this.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Location = new System.Drawing.Point(267, 230);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(543, 36);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_idade
            // 
            this.txt_idade.BorderColor = System.Drawing.Color.Aqua;
            this.txt_idade.BorderRadius = 15;
            this.txt_idade.BorderThickness = 2;
            this.txt_idade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idade.DefaultText = "";
            this.txt_idade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.Enabled = false;
            this.txt_idade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.txt_idade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_idade.ForeColor = System.Drawing.Color.White;
            this.txt_idade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Location = new System.Drawing.Point(267, 272);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.PasswordChar = '\0';
            this.txt_idade.PlaceholderText = "";
            this.txt_idade.SelectedText = "";
            this.txt_idade.Size = new System.Drawing.Size(89, 36);
            this.txt_idade.TabIndex = 14;
            this.txt_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 115);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contratação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(176, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tem experiência ";
            // 
            // ccb_expe
            // 
            this.ccb_expe.BackColor = System.Drawing.Color.Transparent;
            this.ccb_expe.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ccb_expe.CheckedState.BorderColor = System.Drawing.Color.Aqua;
            this.ccb_expe.CheckedState.BorderRadius = 2;
            this.ccb_expe.CheckedState.BorderThickness = 2;
            this.ccb_expe.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ccb_expe.CheckMarkColor = System.Drawing.Color.Teal;
            this.ccb_expe.Enabled = false;
            this.ccb_expe.Location = new System.Drawing.Point(382, 353);
            this.ccb_expe.Name = "ccb_expe";
            this.ccb_expe.Size = new System.Drawing.Size(37, 29);
            this.ccb_expe.TabIndex = 17;
            this.ccb_expe.Text = "guna2CustomCheckBox1";
            this.ccb_expe.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.ccb_expe.UncheckedState.BorderRadius = 2;
            this.ccb_expe.UncheckedState.BorderThickness = 0;
            this.ccb_expe.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ccb_expe.UseTransparentBackground = true;
            this.ccb_expe.Click += new System.EventHandler(this.ccb_expe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(548, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tempo em anos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(176, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(176, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(470, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bairro:";
            // 
            // Dialog1
            // 
            this.Dialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Dialog1.Caption = null;
            this.Dialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.Dialog1.Parent = this;
            this.Dialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog1.Text = null;
            // 
            // Dialog3
            // 
            this.Dialog3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.Dialog3.Caption = null;
            this.Dialog3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.Dialog3.Parent = this;
            this.Dialog3.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog3.Text = null;
            // 
            // Dialog4
            // 
            this.Dialog4.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Dialog4.Caption = null;
            this.Dialog4.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.Dialog4.Parent = this;
            this.Dialog4.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog4.Text = null;
            // 
            // Dialog5
            // 
            this.Dialog5.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.Dialog5.Caption = null;
            this.Dialog5.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.Dialog5.Parent = this;
            this.Dialog5.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog5.Text = null;
            // 
            // Dialog6
            // 
            this.Dialog6.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.Dialog6.Caption = null;
            this.Dialog6.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.Dialog6.Parent = this;
            this.Dialog6.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog6.Text = null;
            // 
            // Dialog7
            // 
            this.Dialog7.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.Dialog7.Caption = null;
            this.Dialog7.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.Dialog7.Parent = this;
            this.Dialog7.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Dialog7.Text = null;
            // 
            // btn_dados
            // 
            this.btn_dados.Animated = true;
            this.btn_dados.AutoRoundedCorners = true;
            this.btn_dados.BackColor = System.Drawing.Color.Transparent;
            this.btn_dados.BorderColor = System.Drawing.Color.Aqua;
            this.btn_dados.BorderRadius = 29;
            this.btn_dados.BorderThickness = 2;
            this.btn_dados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dados.Enabled = false;
            this.btn_dados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btn_dados.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btn_dados.ForeColor = System.Drawing.Color.Aqua;
            this.btn_dados.Location = new System.Drawing.Point(382, 458);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.PressedColor = System.Drawing.Color.Aqua;
            this.btn_dados.Size = new System.Drawing.Size(254, 60);
            this.btn_dados.TabIndex = 22;
            this.btn_dados.Text = "Enviar dados";
            this.btn_dados.UseTransparentBackground = true;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // frm_contratacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.btn_dados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccb_expe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.nud_anos);
            this.Controls.Add(this.cb_regiao);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_contratacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.nud_anos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private Guna.UI2.WinForms.Guna2ComboBox cb_regiao;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_anos;
        private Guna.UI2.WinForms.Guna2TextBox txt_idade;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ccb_expe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog3;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog4;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog5;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog6;
        private Guna.UI2.WinForms.Guna2MessageDialog Dialog7;
        private Guna.UI2.WinForms.Guna2Button btn_dados;
    }
}