namespace MeNutri_Registros.Views
{
    partial class TelaLogin
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
            this.metroTextBoxUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSenha = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogar = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxSenha = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxUser
            // 
            this.metroTextBoxUser.Location = new System.Drawing.Point(133, 106);
            this.metroTextBoxUser.Name = "metroTextBoxUser";
            this.metroTextBoxUser.Size = new System.Drawing.Size(151, 23);
            this.metroTextBoxUser.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxUser.TabIndex = 0;
            this.metroTextBoxUser.UseStyleColors = true;
            // 
            // metroLabelUser
            // 
            this.metroLabelUser.AutoSize = true;
            this.metroLabelUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelUser.Location = new System.Drawing.Point(37, 104);
            this.metroLabelUser.Name = "metroLabelUser";
            this.metroLabelUser.Size = new System.Drawing.Size(74, 25);
            this.metroLabelUser.TabIndex = 2;
            this.metroLabelUser.Text = "Usuário:";
            // 
            // metroLabelSenha
            // 
            this.metroLabelSenha.AutoSize = true;
            this.metroLabelSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSenha.Location = new System.Drawing.Point(48, 151);
            this.metroLabelSenha.Name = "metroLabelSenha";
            this.metroLabelSenha.Size = new System.Drawing.Size(63, 25);
            this.metroLabelSenha.TabIndex = 3;
            this.metroLabelSenha.Text = "Senha:";
            // 
            // metroButtonLogar
            // 
            this.metroButtonLogar.Highlight = true;
            this.metroButtonLogar.Location = new System.Drawing.Point(342, 206);
            this.metroButtonLogar.Name = "metroButtonLogar";
            this.metroButtonLogar.Size = new System.Drawing.Size(86, 29);
            this.metroButtonLogar.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonLogar.TabIndex = 4;
            this.metroButtonLogar.Text = "Login";
            this.metroButtonLogar.Click += new System.EventHandler(this.metroButtonLogar_Click);
            // 
            // metroTextBoxSenha
            // 
            this.metroTextBoxSenha.Location = new System.Drawing.Point(133, 153);
            this.metroTextBoxSenha.Name = "metroTextBoxSenha";
            this.metroTextBoxSenha.PasswordChar = '●';
            this.metroTextBoxSenha.Size = new System.Drawing.Size(151, 23);
            this.metroTextBoxSenha.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxSenha.TabIndex = 1;
            this.metroTextBoxSenha.UseStyleColors = true;
            this.metroTextBoxSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeNutri_Registros.Properties.Resources.MeNutri_Logo_SemFundo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButtonLogar);
            this.Controls.Add(this.metroLabelSenha);
            this.Controls.Add(this.metroLabelUser);
            this.Controls.Add(this.metroTextBoxSenha);
            this.Controls.Add(this.metroTextBoxUser);
            this.Name = "TelaLogin";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxUser;
        private MetroFramework.Controls.MetroLabel metroLabelUser;
        private MetroFramework.Controls.MetroLabel metroLabelSenha;
        private MetroFramework.Controls.MetroButton metroButtonLogar;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}