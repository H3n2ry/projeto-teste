
namespace projeto_teste
{
    partial class frm_meses
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
            this.txt_nmes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_mesdigi = new System.Windows.Forms.Label();
            this.btn_fechar = new Guna.UI2.WinForms.Guna2Button();
            this.dialogo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.dialogo1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogo3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // txt_nmes
            // 
            this.txt_nmes.BorderRadius = 10;
            this.txt_nmes.BorderThickness = 2;
            this.txt_nmes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nmes.DefaultText = "";
            this.txt_nmes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nmes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nmes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.txt_nmes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nmes.ForeColor = System.Drawing.Color.Aqua;
            this.txt_nmes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmes.Location = new System.Drawing.Point(339, 78);
            this.txt_nmes.MaxLength = 2;
            this.txt_nmes.Name = "txt_nmes";
            this.txt_nmes.PasswordChar = '\0';
            this.txt_nmes.PlaceholderText = "";
            this.txt_nmes.SelectedText = "";
            this.txt_nmes.Size = new System.Drawing.Size(112, 28);
            this.txt_nmes.TabIndex = 0;
            this.txt_nmes.TextChanged += new System.EventHandler(this.txt_nmes_TextChanged);
            this.txt_nmes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nmes_KeyPress);
            // 
            // lbl_mesdigi
            // 
            this.lbl_mesdigi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesdigi.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_mesdigi.Location = new System.Drawing.Point(92, 78);
            this.lbl_mesdigi.Name = "lbl_mesdigi";
            this.lbl_mesdigi.Size = new System.Drawing.Size(241, 28);
            this.lbl_mesdigi.TabIndex = 1;
            this.lbl_mesdigi.Text = "Digite o numero do mês\r\n";
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
            this.btn_fechar.Location = new System.Drawing.Point(977, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.PressedColor = System.Drawing.Color.Aqua;
            this.btn_fechar.Size = new System.Drawing.Size(52, 50);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            // lbl_mes
            // 
            this.lbl_mes.Font = new System.Drawing.Font("standard 07_63", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_mes.Location = new System.Drawing.Point(125, 179);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(811, 217);
            this.lbl_mes.TabIndex = 5;
            this.lbl_mes.Text = "2024";
            this.lbl_mes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dialogo1
            // 
            this.dialogo1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo1.Caption = null;
            this.dialogo1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogo1.Parent = this;
            this.dialogo1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo1.Text = null;
            // 
            // dialogo2
            // 
            this.dialogo2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo2.Caption = null;
            this.dialogo2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.dialogo2.Parent = this;
            this.dialogo2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo2.Text = null;
            // 
            // dialogo3
            // 
            this.dialogo3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogo3.Caption = null;
            this.dialogo3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogo3.Parent = this;
            this.dialogo3.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.dialogo3.Text = null;
            // 
            // frm_meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_mesdigi);
            this.Controls.Add(this.txt_nmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_meses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_meses";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_nmes;
        private System.Windows.Forms.Label lbl_mesdigi;
        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo;
        private System.Windows.Forms.Label lbl_mes;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo1;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo2;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogo3;
    }
}