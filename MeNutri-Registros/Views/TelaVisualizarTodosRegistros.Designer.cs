﻿namespace MeNutri_Registros.Views
{
    partial class TelaVisualizarTodosRegistros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridVisualizacaoRegistros = new MetroFramework.Controls.MetroGrid();
            this.metroPanelControlesGrid = new MetroFramework.Controls.MetroPanel();
            this.metroComboBoxOrdenar = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonExcluirRegistro = new MetroFramework.Controls.MetroButton();
            this.metroButtonFiltrarGrid = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTimeTermino = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelTerminoData = new MetroFramework.Controls.MetroLabel();
            this.metroLabelInicioData = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxExportarPDF = new System.Windows.Forms.PictureBox();
            this.pictureBoxExportarExcel = new System.Windows.Forms.PictureBox();
            this.metroButtonEditarRegistro = new MetroFramework.Controls.MetroButton();
            this.metroButtonVisualizarRegistro = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVisualizacaoRegistros)).BeginInit();
            this.metroPanelControlesGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportarPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportarExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridVisualizacaoRegistros
            // 
            this.metroGridVisualizacaoRegistros.AllowUserToAddRows = false;
            this.metroGridVisualizacaoRegistros.AllowUserToDeleteRows = false;
            this.metroGridVisualizacaoRegistros.AllowUserToResizeRows = false;
            this.metroGridVisualizacaoRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVisualizacaoRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridVisualizacaoRegistros.CausesValidation = false;
            this.metroGridVisualizacaoRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridVisualizacaoRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVisualizacaoRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.metroGridVisualizacaoRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridVisualizacaoRegistros.DefaultCellStyle = dataGridViewCellStyle50;
            this.metroGridVisualizacaoRegistros.EnableHeadersVisualStyles = false;
            this.metroGridVisualizacaoRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridVisualizacaoRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVisualizacaoRegistros.Location = new System.Drawing.Point(15, 155);
            this.metroGridVisualizacaoRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.metroGridVisualizacaoRegistros.MaximumSize = new System.Drawing.Size(856, 372);
            this.metroGridVisualizacaoRegistros.MinimumSize = new System.Drawing.Size(856, 372);
            this.metroGridVisualizacaoRegistros.Name = "metroGridVisualizacaoRegistros";
            this.metroGridVisualizacaoRegistros.ReadOnly = true;
            this.metroGridVisualizacaoRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVisualizacaoRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.metroGridVisualizacaoRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridVisualizacaoRegistros.RowTemplate.Height = 28;
            this.metroGridVisualizacaoRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridVisualizacaoRegistros.Size = new System.Drawing.Size(856, 372);
            this.metroGridVisualizacaoRegistros.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridVisualizacaoRegistros.TabIndex = 0;
            this.metroGridVisualizacaoRegistros.Visible = false;
            // 
            // metroPanelControlesGrid
            // 
            this.metroPanelControlesGrid.Controls.Add(this.metroComboBoxOrdenar);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonExcluirRegistro);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonFiltrarGrid);
            this.metroPanelControlesGrid.Controls.Add(this.metroLabel1);
            this.metroPanelControlesGrid.Controls.Add(this.metroTextBoxFiltrar);
            this.metroPanelControlesGrid.Controls.Add(this.metroDateTimeTermino);
            this.metroPanelControlesGrid.Controls.Add(this.metroDateTimeInicio);
            this.metroPanelControlesGrid.Controls.Add(this.metroLabelTerminoData);
            this.metroPanelControlesGrid.Controls.Add(this.metroLabelInicioData);
            this.metroPanelControlesGrid.Controls.Add(this.pictureBoxExportarPDF);
            this.metroPanelControlesGrid.Controls.Add(this.pictureBoxExportarExcel);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonEditarRegistro);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonVisualizarRegistro);
            this.metroPanelControlesGrid.HorizontalScrollbarBarColor = true;
            this.metroPanelControlesGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelControlesGrid.HorizontalScrollbarSize = 10;
            this.metroPanelControlesGrid.Location = new System.Drawing.Point(15, 60);
            this.metroPanelControlesGrid.Name = "metroPanelControlesGrid";
            this.metroPanelControlesGrid.Size = new System.Drawing.Size(856, 90);
            this.metroPanelControlesGrid.TabIndex = 1;
            this.metroPanelControlesGrid.VerticalScrollbarBarColor = true;
            this.metroPanelControlesGrid.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelControlesGrid.VerticalScrollbarSize = 10;
            // 
            // metroComboBoxOrdenar
            // 
            this.metroComboBoxOrdenar.FormattingEnabled = true;
            this.metroComboBoxOrdenar.ItemHeight = 23;
            this.metroComboBoxOrdenar.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Razão Social",
            "Tipo Registro",
            "Estado"});
            this.metroComboBoxOrdenar.Location = new System.Drawing.Point(610, 58);
            this.metroComboBoxOrdenar.Name = "metroComboBoxOrdenar";
            this.metroComboBoxOrdenar.Size = new System.Drawing.Size(107, 29);
            this.metroComboBoxOrdenar.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroComboBoxOrdenar.TabIndex = 12;
            this.metroComboBoxOrdenar.UseCustomBackColor = true;
            this.metroComboBoxOrdenar.UseCustomForeColor = true;
            this.metroComboBoxOrdenar.UseSelectable = true;
            this.metroComboBoxOrdenar.UseStyleColors = true;
            // 
            // metroButtonExcluirRegistro
            // 
            this.metroButtonExcluirRegistro.Location = new System.Drawing.Point(746, 9);
            this.metroButtonExcluirRegistro.Name = "metroButtonExcluirRegistro";
            this.metroButtonExcluirRegistro.Size = new System.Drawing.Size(96, 27);
            this.metroButtonExcluirRegistro.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonExcluirRegistro.TabIndex = 3;
            this.metroButtonExcluirRegistro.Text = "Excluir";
            this.metroButtonExcluirRegistro.UseCustomBackColor = true;
            this.metroButtonExcluirRegistro.UseSelectable = true;
            this.metroButtonExcluirRegistro.UseStyleColors = true;
            this.metroButtonExcluirRegistro.Visible = false;
            // 
            // metroButtonFiltrarGrid
            // 
            this.metroButtonFiltrarGrid.Location = new System.Drawing.Point(610, 22);
            this.metroButtonFiltrarGrid.Name = "metroButtonFiltrarGrid";
            this.metroButtonFiltrarGrid.Size = new System.Drawing.Size(107, 27);
            this.metroButtonFiltrarGrid.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroButtonFiltrarGrid.TabIndex = 11;
            this.metroButtonFiltrarGrid.Text = "Filtrar";
            this.metroButtonFiltrarGrid.UseCustomBackColor = true;
            this.metroButtonFiltrarGrid.UseSelectable = true;
            this.metroButtonFiltrarGrid.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(400, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Filtrar grid:";
            // 
            // metroTextBoxFiltrar
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltrar.CustomButton.Image = null;
            this.metroTextBoxFiltrar.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.metroTextBoxFiltrar.CustomButton.Name = "";
            this.metroTextBoxFiltrar.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBoxFiltrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltrar.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltrar.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltrar.CustomButton.Visible = false;
            this.metroTextBoxFiltrar.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.metroTextBoxFiltrar.Lines = new string[0];
            this.metroTextBoxFiltrar.Location = new System.Drawing.Point(480, 27);
            this.metroTextBoxFiltrar.MaxLength = 100;
            this.metroTextBoxFiltrar.Name = "metroTextBoxFiltrar";
            this.metroTextBoxFiltrar.PasswordChar = '\0';
            this.metroTextBoxFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltrar.SelectedText = "";
            this.metroTextBoxFiltrar.SelectionLength = 0;
            this.metroTextBoxFiltrar.SelectionStart = 0;
            this.metroTextBoxFiltrar.ShortcutsEnabled = true;
            this.metroTextBoxFiltrar.Size = new System.Drawing.Size(113, 22);
            this.metroTextBoxFiltrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBoxFiltrar.TabIndex = 9;
            this.metroTextBoxFiltrar.UseSelectable = true;
            this.metroTextBoxFiltrar.UseStyleColors = true;
            this.metroTextBoxFiltrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTimeTermino
            // 
            this.metroDateTimeTermino.CustomFormat = "";
            this.metroDateTimeTermino.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeTermino.Location = new System.Drawing.Point(199, 60);
            this.metroDateTimeTermino.MinDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.metroDateTimeTermino.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeTermino.Name = "metroDateTimeTermino";
            this.metroDateTimeTermino.Size = new System.Drawing.Size(167, 25);
            this.metroDateTimeTermino.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDateTimeTermino.TabIndex = 5;
            this.metroDateTimeTermino.UseStyleColors = true;
            this.metroDateTimeTermino.ValueChanged += new System.EventHandler(this.metroDateTimeTermino_ValueChanged);
            // 
            // metroDateTimeInicio
            // 
            this.metroDateTimeInicio.CustomFormat = "";
            this.metroDateTimeInicio.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeInicio.Location = new System.Drawing.Point(3, 60);
            this.metroDateTimeInicio.MinDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.metroDateTimeInicio.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeInicio.Name = "metroDateTimeInicio";
            this.metroDateTimeInicio.Size = new System.Drawing.Size(167, 29);
            this.metroDateTimeInicio.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDateTimeInicio.TabIndex = 4;
            this.metroDateTimeInicio.UseStyleColors = true;
            this.metroDateTimeInicio.ValueChanged += new System.EventHandler(this.metroDateTimeInicio_ValueChanged);
            // 
            // metroLabelTerminoData
            // 
            this.metroLabelTerminoData.AutoSize = true;
            this.metroLabelTerminoData.Location = new System.Drawing.Point(199, 27);
            this.metroLabelTerminoData.Name = "metroLabelTerminoData";
            this.metroLabelTerminoData.Size = new System.Drawing.Size(59, 19);
            this.metroLabelTerminoData.TabIndex = 8;
            this.metroLabelTerminoData.Text = "Término:";
            // 
            // metroLabelInicioData
            // 
            this.metroLabelInicioData.AutoSize = true;
            this.metroLabelInicioData.Location = new System.Drawing.Point(3, 27);
            this.metroLabelInicioData.Name = "metroLabelInicioData";
            this.metroLabelInicioData.Size = new System.Drawing.Size(42, 19);
            this.metroLabelInicioData.TabIndex = 7;
            this.metroLabelInicioData.Text = "Início:";
            // 
            // pictureBoxExportarPDF
            // 
            this.pictureBoxExportarPDF.BackgroundImage = global::MeNutri_Registros.Properties.Resources.pdf;
            this.pictureBoxExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExportarPDF.Location = new System.Drawing.Point(797, 42);
            this.pictureBoxExportarPDF.Name = "pictureBoxExportarPDF";
            this.pictureBoxExportarPDF.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxExportarPDF.TabIndex = 6;
            this.pictureBoxExportarPDF.TabStop = false;
            // 
            // pictureBoxExportarExcel
            // 
            this.pictureBoxExportarExcel.BackgroundImage = global::MeNutri_Registros.Properties.Resources.xls;
            this.pictureBoxExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExportarExcel.Location = new System.Drawing.Point(746, 42);
            this.pictureBoxExportarExcel.Name = "pictureBoxExportarExcel";
            this.pictureBoxExportarExcel.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxExportarExcel.TabIndex = 5;
            this.pictureBoxExportarExcel.TabStop = false;
            // 
            // metroButtonEditarRegistro
            // 
            this.metroButtonEditarRegistro.Location = new System.Drawing.Point(506, 60);
            this.metroButtonEditarRegistro.Name = "metroButtonEditarRegistro";
            this.metroButtonEditarRegistro.Size = new System.Drawing.Size(87, 27);
            this.metroButtonEditarRegistro.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonEditarRegistro.TabIndex = 2;
            this.metroButtonEditarRegistro.Text = "Editar";
            this.metroButtonEditarRegistro.UseCustomBackColor = true;
            this.metroButtonEditarRegistro.UseSelectable = true;
            this.metroButtonEditarRegistro.UseStyleColors = true;
            // 
            // metroButtonVisualizarRegistro
            // 
            this.metroButtonVisualizarRegistro.Location = new System.Drawing.Point(400, 60);
            this.metroButtonVisualizarRegistro.Name = "metroButtonVisualizarRegistro";
            this.metroButtonVisualizarRegistro.Size = new System.Drawing.Size(87, 27);
            this.metroButtonVisualizarRegistro.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonVisualizarRegistro.TabIndex = 1;
            this.metroButtonVisualizarRegistro.Text = "Visualizar";
            this.metroButtonVisualizarRegistro.UseCustomBackColor = true;
            this.metroButtonVisualizarRegistro.UseSelectable = true;
            this.metroButtonVisualizarRegistro.UseStyleColors = true;
            // 
            // TelaVisualizarTodosRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 542);
            this.Controls.Add(this.metroPanelControlesGrid);
            this.Controls.Add(this.metroGridVisualizacaoRegistros);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaVisualizarTodosRegistros";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Visualizar registros";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVisualizacaoRegistros)).EndInit();
            this.metroPanelControlesGrid.ResumeLayout(false);
            this.metroPanelControlesGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportarPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportarExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridVisualizacaoRegistros;
        private MetroFramework.Controls.MetroPanel metroPanelControlesGrid;
        private MetroFramework.Controls.MetroButton metroButtonVisualizarRegistro;
        private MetroFramework.Controls.MetroButton metroButtonEditarRegistro;
        private MetroFramework.Controls.MetroButton metroButtonExcluirRegistro;
        private System.Windows.Forms.PictureBox pictureBoxExportarExcel;
        private System.Windows.Forms.PictureBox pictureBoxExportarPDF;
        private MetroFramework.Controls.MetroLabel metroLabelTerminoData;
        private MetroFramework.Controls.MetroLabel metroLabelInicioData;
        private MetroFramework.Controls.MetroDateTime metroDateTimeInicio;
        private MetroFramework.Controls.MetroDateTime metroDateTimeTermino;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltrar;
        private MetroFramework.Controls.MetroButton metroButtonFiltrarGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxOrdenar;
    }
}