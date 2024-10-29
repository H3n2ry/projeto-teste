
namespace projeto_teste
{
    partial class frm_futebol
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
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dialogo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo4 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Animated = true;
            this.btn_fechar.AutoRoundedCorners = true;
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_fechar.BorderRadius = 24;
            this.btn_fechar.BorderThickness = 2;
            this.btn_fechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fechar.FillColor = System.Drawing.Color.OliveDrab;
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.IndicateFocus = true;
            this.btn_fechar.Location = new System.Drawing.Point(977, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.PressedColor = System.Drawing.Color.Gold;
            this.btn_fechar.Size = new System.Drawing.Size(52, 50);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Transparent;
            this.txt_nome.BorderRadius = 15;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.DefaultText = "";
            this.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Location = new System.Drawing.Point(391, 149);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(214, 42);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_idade
            // 
            this.txt_idade.BackColor = System.Drawing.Color.Transparent;
            this.txt_idade.BorderRadius = 15;
            this.txt_idade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idade.DefaultText = "";
            this.txt_idade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Location = new System.Drawing.Point(391, 254);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.PasswordChar = '\0';
            this.txt_idade.PlaceholderText = "";
            this.txt_idade.SelectedText = "";
            this.txt_idade.Size = new System.Drawing.Size(214, 42);
            this.txt_idade.TabIndex = 7;
            this.txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Idade";
            // 
            // dialogo
            // 
            this.dialogo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo.Caption = null;
            this.dialogo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogo.Parent = this;
            this.dialogo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo.Text = null;
            // 
            // dialogo1
            // 
            this.dialogo1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo1.Caption = null;
            this.dialogo1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.dialogo1.Parent = this;
            this.dialogo1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo1.Text = null;
            // 
            // dialogo2
            // 
            this.dialogo2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo2.Caption = null;
            this.dialogo2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogo2.Parent = this;
            this.dialogo2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo2.Text = null;
            // 
            // dialogo3
            // 
            this.dialogo3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo3.Caption = null;
            this.dialogo3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.dialogo3.Parent = this;
            this.dialogo3.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo3.Text = null;
            // 
            // dialogo4
            // 
            this.dialogo4.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo4.Caption = null;
            this.dialogo4.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.dialogo4.Parent = this;
            this.dialogo4.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo4.Text = null;
            // 
            // frm_futebol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = global::projeto_teste.Properties.Resources.campo_fut;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_futebol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_futebol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private Guna.UI2.WinForms.Guna2TextBox txt_idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo1;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo2;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo3;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo4;
    }
}