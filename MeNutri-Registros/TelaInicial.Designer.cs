namespace MeNutri_Registros
{
    partial class TelaInicial
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
            this.pictureBoxLogoMenutriPrincipal = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdicionarRegistro = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuscarRegistros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoMenutriPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdicionarRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoMenutriPrincipal
            // 
            this.pictureBoxLogoMenutriPrincipal.BackgroundImage = global::MeNutri_Registros.Properties.Resources.MeNutri_Logo_SemFundo;
            this.pictureBoxLogoMenutriPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogoMenutriPrincipal.Location = new System.Drawing.Point(191, 119);
            this.pictureBoxLogoMenutriPrincipal.Name = "pictureBoxLogoMenutriPrincipal";
            this.pictureBoxLogoMenutriPrincipal.Size = new System.Drawing.Size(370, 236);
            this.pictureBoxLogoMenutriPrincipal.TabIndex = 0;
            this.pictureBoxLogoMenutriPrincipal.TabStop = false;
            // 
            // pictureBoxAdicionarRegistro
            // 
            this.pictureBoxAdicionarRegistro.BackgroundImage = global::MeNutri_Registros.Properties.Resources.BotaoAdicionar;
            this.pictureBoxAdicionarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdicionarRegistro.Location = new System.Drawing.Point(23, 40);
            this.pictureBoxAdicionarRegistro.Name = "pictureBoxAdicionarRegistro";
            this.pictureBoxAdicionarRegistro.Size = new System.Drawing.Size(60, 50);
            this.pictureBoxAdicionarRegistro.TabIndex = 1;
            this.pictureBoxAdicionarRegistro.TabStop = false;
            this.pictureBoxAdicionarRegistro.Click += new System.EventHandler(this.pictureBoxAdicionarRegistro_Click);
            this.pictureBoxAdicionarRegistro.MouseEnter += new System.EventHandler(this.pictureBoxAdicionarRegistro_MouseEnter);
            // 
            // pictureBoxBuscarRegistros
            // 
            this.pictureBoxBuscarRegistros.BackgroundImage = global::MeNutri_Registros.Properties.Resources.LupaVerde;
            this.pictureBoxBuscarRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBuscarRegistros.Location = new System.Drawing.Point(650, 40);
            this.pictureBoxBuscarRegistros.Name = "pictureBoxBuscarRegistros";
            this.pictureBoxBuscarRegistros.Size = new System.Drawing.Size(60, 50);
            this.pictureBoxBuscarRegistros.TabIndex = 2;
            this.pictureBoxBuscarRegistros.TabStop = false;
            this.pictureBoxBuscarRegistros.Click += new System.EventHandler(this.pictureBoxBuscarRegistros_Click);
            this.pictureBoxBuscarRegistros.MouseEnter += new System.EventHandler(this.pictureBoxBuscarRegistros_MouseEnter);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.pictureBoxBuscarRegistros);
            this.Controls.Add(this.pictureBoxAdicionarRegistro);
            this.Controls.Add(this.pictureBoxLogoMenutriPrincipal);
            this.Name = "TelaInicial";
            this.Style = MetroFramework.MetroColorStyle.Green;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoMenutriPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdicionarRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoMenutriPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxAdicionarRegistro;
        private System.Windows.Forms.PictureBox pictureBoxBuscarRegistros;
    }
}