namespace MeNutri_Registros.Views
{
    partial class TelaObterEmailsRegistros
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
            this.metroTextBoxEmailsGerados = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonGerarEmails = new MetroFramework.Controls.MetroButton();
            this.metroLabelFiltrarPor = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxFiltrarEmail = new MetroFramework.Controls.MetroComboBox();
            this.pictureBoxMeNutrinho = new System.Windows.Forms.PictureBox();
            this.metroButtonCopiarClipboard = new MetroFramework.Controls.MetroButton();
            this.metroLabelCopiadoParaClipboard = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeNutrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxEmailsGerados
            // 
            // 
            // 
            // 
            this.metroTextBoxEmailsGerados.CustomButton.Image = null;
            this.metroTextBoxEmailsGerados.CustomButton.Location = new System.Drawing.Point(556, 2);
            this.metroTextBoxEmailsGerados.CustomButton.Name = "";
            this.metroTextBoxEmailsGerados.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.metroTextBoxEmailsGerados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmailsGerados.CustomButton.TabIndex = 1;
            this.metroTextBoxEmailsGerados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmailsGerados.CustomButton.UseSelectable = true;
            this.metroTextBoxEmailsGerados.CustomButton.Visible = false;
            this.metroTextBoxEmailsGerados.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxEmailsGerados.Lines = new string[0];
            this.metroTextBoxEmailsGerados.Location = new System.Drawing.Point(23, 227);
            this.metroTextBoxEmailsGerados.MaxLength = 32767;
            this.metroTextBoxEmailsGerados.Multiline = true;
            this.metroTextBoxEmailsGerados.Name = "metroTextBoxEmailsGerados";
            this.metroTextBoxEmailsGerados.PasswordChar = '\0';
            this.metroTextBoxEmailsGerados.ReadOnly = true;
            this.metroTextBoxEmailsGerados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBoxEmailsGerados.SelectedText = "";
            this.metroTextBoxEmailsGerados.SelectionLength = 0;
            this.metroTextBoxEmailsGerados.SelectionStart = 0;
            this.metroTextBoxEmailsGerados.ShortcutsEnabled = true;
            this.metroTextBoxEmailsGerados.Size = new System.Drawing.Size(754, 200);
            this.metroTextBoxEmailsGerados.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxEmailsGerados.TabIndex = 0;
            this.metroTextBoxEmailsGerados.UseSelectable = true;
            this.metroTextBoxEmailsGerados.UseStyleColors = true;
            this.metroTextBoxEmailsGerados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmailsGerados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonGerarEmails
            // 
            this.metroButtonGerarEmails.Location = new System.Drawing.Point(680, 187);
            this.metroButtonGerarEmails.Name = "metroButtonGerarEmails";
            this.metroButtonGerarEmails.Size = new System.Drawing.Size(97, 34);
            this.metroButtonGerarEmails.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonGerarEmails.TabIndex = 1;
            this.metroButtonGerarEmails.Text = "Gerar";
            this.metroButtonGerarEmails.UseCustomBackColor = true;
            this.metroButtonGerarEmails.UseSelectable = true;
            this.metroButtonGerarEmails.UseStyleColors = true;
            this.metroButtonGerarEmails.Click += new System.EventHandler(this.metroButtonGerarEmails_Click);
            // 
            // metroLabelFiltrarPor
            // 
            this.metroLabelFiltrarPor.AutoSize = true;
            this.metroLabelFiltrarPor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelFiltrarPor.Location = new System.Drawing.Point(23, 96);
            this.metroLabelFiltrarPor.Name = "metroLabelFiltrarPor";
            this.metroLabelFiltrarPor.Size = new System.Drawing.Size(288, 19);
            this.metroLabelFiltrarPor.TabIndex = 2;
            this.metroLabelFiltrarPor.Text = "Gerar os destinatários do e-mail filtrando por:";
            // 
            // metroComboBoxFiltrarEmail
            // 
            this.metroComboBoxFiltrarEmail.FormattingEnabled = true;
            this.metroComboBoxFiltrarEmail.ItemHeight = 23;
            this.metroComboBoxFiltrarEmail.Items.AddRange(new object[] {
            "Todos",
            "Cliente",
            "Potencial cliente",
            "Funcionário"});
            this.metroComboBoxFiltrarEmail.Location = new System.Drawing.Point(316, 96);
            this.metroComboBoxFiltrarEmail.Name = "metroComboBoxFiltrarEmail";
            this.metroComboBoxFiltrarEmail.Size = new System.Drawing.Size(143, 29);
            this.metroComboBoxFiltrarEmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxFiltrarEmail.TabIndex = 3;
            this.metroComboBoxFiltrarEmail.UseSelectable = true;
            this.metroComboBoxFiltrarEmail.UseStyleColors = true;
            this.metroComboBoxFiltrarEmail.SelectionChangeCommitted += new System.EventHandler(this.metroComboBoxOrdenar_SelectionChangeCommited);
            // 
            // pictureBoxMeNutrinho
            // 
            this.pictureBoxMeNutrinho.BackgroundImage = global::MeNutri_Registros.Properties.Resources.Menutrinho_Imagem;
            this.pictureBoxMeNutrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMeNutrinho.Location = new System.Drawing.Point(680, 38);
            this.pictureBoxMeNutrinho.Name = "pictureBoxMeNutrinho";
            this.pictureBoxMeNutrinho.Size = new System.Drawing.Size(97, 87);
            this.pictureBoxMeNutrinho.TabIndex = 4;
            this.pictureBoxMeNutrinho.TabStop = false;
            // 
            // metroButtonCopiarClipboard
            // 
            this.metroButtonCopiarClipboard.Location = new System.Drawing.Point(24, 187);
            this.metroButtonCopiarClipboard.Name = "metroButtonCopiarClipboard";
            this.metroButtonCopiarClipboard.Size = new System.Drawing.Size(97, 34);
            this.metroButtonCopiarClipboard.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonCopiarClipboard.TabIndex = 5;
            this.metroButtonCopiarClipboard.Text = "Copiar tudo";
            this.metroButtonCopiarClipboard.UseCustomBackColor = true;
            this.metroButtonCopiarClipboard.UseSelectable = true;
            this.metroButtonCopiarClipboard.UseStyleColors = true;
            this.metroButtonCopiarClipboard.Click += new System.EventHandler(this.metroButtonCopiarClipboard_Click);
            // 
            // metroLabelCopiadoParaClipboard
            // 
            this.metroLabelCopiadoParaClipboard.AutoSize = true;
            this.metroLabelCopiadoParaClipboard.Location = new System.Drawing.Point(128, 202);
            this.metroLabelCopiadoParaClipboard.Name = "metroLabelCopiadoParaClipboard";
            this.metroLabelCopiadoParaClipboard.Size = new System.Drawing.Size(0, 0);
            this.metroLabelCopiadoParaClipboard.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabelCopiadoParaClipboard.TabIndex = 6;
            this.metroLabelCopiadoParaClipboard.UseStyleColors = true;
            // 
            // TelaObterEmailsRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabelCopiadoParaClipboard);
            this.Controls.Add(this.metroButtonCopiarClipboard);
            this.Controls.Add(this.pictureBoxMeNutrinho);
            this.Controls.Add(this.metroComboBoxFiltrarEmail);
            this.Controls.Add(this.metroLabelFiltrarPor);
            this.Controls.Add(this.metroButtonGerarEmails);
            this.Controls.Add(this.metroTextBoxEmailsGerados);
            this.Name = "TelaObterEmailsRegistros";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Obter e-mails para envio:";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeNutrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxEmailsGerados;
        private MetroFramework.Controls.MetroButton metroButtonGerarEmails;
        private MetroFramework.Controls.MetroLabel metroLabelFiltrarPor;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFiltrarEmail;
        private System.Windows.Forms.PictureBox pictureBoxMeNutrinho;
        private MetroFramework.Controls.MetroButton metroButtonCopiarClipboard;
        private MetroFramework.Controls.MetroLabel metroLabelCopiadoParaClipboard;
    }
}