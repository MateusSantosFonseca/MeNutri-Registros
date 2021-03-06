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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridVisualizacaoRegistros = new MetroFramework.Controls.MetroGrid();
            this.metroPanelControlesGrid = new MetroFramework.Controls.MetroPanel();
            this.metroButtonExcluirRegistro = new MetroFramework.Controls.MetroButton();
            this.metroButtonResetarFiltrosEGrid = new MetroFramework.Controls.MetroButton();
            this.metroButtonPesquisarRegistros = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxOrdenar = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonFiltrarGrid = new MetroFramework.Controls.MetroButton();
            this.metroLabelFiltrarGridExplicativo = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTimeTermino = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelTerminoData = new MetroFramework.Controls.MetroLabel();
            this.metroLabelInicioData = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxExportarPDF = new System.Windows.Forms.PictureBox();
            this.pictureBoxExportarExcel = new System.Windows.Forms.PictureBox();
            this.metroButtonEditarRegistro = new MetroFramework.Controls.MetroButton();
            this.metroButtonVisualizarRegistro = new MetroFramework.Controls.MetroButton();
            this.metroLabelOrdenar = new MetroFramework.Controls.MetroLabel();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVisualizacaoRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridVisualizacaoRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridVisualizacaoRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridVisualizacaoRegistros.EnableHeadersVisualStyles = false;
            this.metroGridVisualizacaoRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridVisualizacaoRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVisualizacaoRegistros.Location = new System.Drawing.Point(22, 269);
            this.metroGridVisualizacaoRegistros.MaximumSize = new System.Drawing.Size(1284, 572);
            this.metroGridVisualizacaoRegistros.MinimumSize = new System.Drawing.Size(1284, 572);
            this.metroGridVisualizacaoRegistros.Name = "metroGridVisualizacaoRegistros";
            this.metroGridVisualizacaoRegistros.ReadOnly = true;
            this.metroGridVisualizacaoRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVisualizacaoRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridVisualizacaoRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridVisualizacaoRegistros.RowTemplate.Height = 28;
            this.metroGridVisualizacaoRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGridVisualizacaoRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridVisualizacaoRegistros.Size = new System.Drawing.Size(1284, 572);
            this.metroGridVisualizacaoRegistros.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridVisualizacaoRegistros.TabIndex = 30;
            this.metroGridVisualizacaoRegistros.UseCustomForeColor = true;
            this.metroGridVisualizacaoRegistros.UseStyleColors = true;
            this.metroGridVisualizacaoRegistros.Visible = false;
            // 
            // metroPanelControlesGrid
            // 
            this.metroPanelControlesGrid.Controls.Add(this.metroLabelOrdenar);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonExcluirRegistro);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonResetarFiltrosEGrid);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonPesquisarRegistros);
            this.metroPanelControlesGrid.Controls.Add(this.metroComboBoxOrdenar);
            this.metroPanelControlesGrid.Controls.Add(this.metroButtonFiltrarGrid);
            this.metroPanelControlesGrid.Controls.Add(this.metroLabelFiltrarGridExplicativo);
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
            this.metroPanelControlesGrid.HorizontalScrollbarSize = 15;
            this.metroPanelControlesGrid.Location = new System.Drawing.Point(22, 91);
            this.metroPanelControlesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanelControlesGrid.Name = "metroPanelControlesGrid";
            this.metroPanelControlesGrid.Size = new System.Drawing.Size(1284, 152);
            this.metroPanelControlesGrid.TabIndex = 1;
            this.metroPanelControlesGrid.VerticalScrollbarBarColor = true;
            this.metroPanelControlesGrid.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelControlesGrid.VerticalScrollbarSize = 15;
            // 
            // metroButtonExcluirRegistro
            // 
            this.metroButtonExcluirRegistro.Enabled = false;
            this.metroButtonExcluirRegistro.Location = new System.Drawing.Point(952, 5);
            this.metroButtonExcluirRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonExcluirRegistro.Name = "metroButtonExcluirRegistro";
            this.metroButtonExcluirRegistro.Size = new System.Drawing.Size(130, 42);
            this.metroButtonExcluirRegistro.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonExcluirRegistro.TabIndex = 10;
            this.metroButtonExcluirRegistro.Text = "Excluir";
            this.metroButtonExcluirRegistro.UseCustomBackColor = true;
            this.metroButtonExcluirRegistro.UseSelectable = true;
            this.metroButtonExcluirRegistro.UseStyleColors = true;
            this.metroButtonExcluirRegistro.Visible = false;
            this.metroButtonExcluirRegistro.Click += new System.EventHandler(this.metroButtonExcluirRegistro_Click);
            // 
            // metroButtonResetarFiltrosEGrid
            // 
            this.metroButtonResetarFiltrosEGrid.Location = new System.Drawing.Point(1120, 5);
            this.metroButtonResetarFiltrosEGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonResetarFiltrosEGrid.Name = "metroButtonResetarFiltrosEGrid";
            this.metroButtonResetarFiltrosEGrid.Size = new System.Drawing.Size(144, 42);
            this.metroButtonResetarFiltrosEGrid.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButtonResetarFiltrosEGrid.TabIndex = 9;
            this.metroButtonResetarFiltrosEGrid.Text = "Resetar filtros";
            this.metroButtonResetarFiltrosEGrid.UseCustomBackColor = true;
            this.metroButtonResetarFiltrosEGrid.UseSelectable = true;
            this.metroButtonResetarFiltrosEGrid.UseStyleColors = true;
            this.metroButtonResetarFiltrosEGrid.Click += new System.EventHandler(this.metroButtonResetarFiltrosEGrid_Click);
            // 
            // metroButtonPesquisarRegistros
            // 
            this.metroButtonPesquisarRegistros.Enabled = false;
            this.metroButtonPesquisarRegistros.Location = new System.Drawing.Point(586, 108);
            this.metroButtonPesquisarRegistros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonPesquisarRegistros.Name = "metroButtonPesquisarRegistros";
            this.metroButtonPesquisarRegistros.Size = new System.Drawing.Size(171, 40);
            this.metroButtonPesquisarRegistros.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButtonPesquisarRegistros.TabIndex = 3;
            this.metroButtonPesquisarRegistros.Text = "Pesquisar";
            this.metroButtonPesquisarRegistros.UseCustomBackColor = true;
            this.metroButtonPesquisarRegistros.UseSelectable = true;
            this.metroButtonPesquisarRegistros.UseStyleColors = true;
            this.metroButtonPesquisarRegistros.Click += new System.EventHandler(this.metroButtonPesquisarRegistros_Click);
            // 
            // metroComboBoxOrdenar
            // 
            this.metroComboBoxOrdenar.FormattingEnabled = true;
            this.metroComboBoxOrdenar.ItemHeight = 23;
            this.metroComboBoxOrdenar.Items.AddRange(new object[] {
            "Data cadastro",
            "Nome",
            "Razão Social",
            "Tipo Registro",
            "Estado"});
            this.metroComboBoxOrdenar.Location = new System.Drawing.Point(586, 52);
            this.metroComboBoxOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroComboBoxOrdenar.Name = "metroComboBoxOrdenar";
            this.metroComboBoxOrdenar.Size = new System.Drawing.Size(169, 29);
            this.metroComboBoxOrdenar.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroComboBoxOrdenar.TabIndex = 5;
            this.metroComboBoxOrdenar.UseCustomBackColor = true;
            this.metroComboBoxOrdenar.UseCustomForeColor = true;
            this.metroComboBoxOrdenar.UseSelectable = true;
            this.metroComboBoxOrdenar.UseStyleColors = true;
            this.metroComboBoxOrdenar.SelectionChangeCommitted += new System.EventHandler(this.metroComboBoxOrdenar_SelectionChangeCommited);
            // 
            // metroButtonFiltrarGrid
            // 
            this.metroButtonFiltrarGrid.Enabled = false;
            this.metroButtonFiltrarGrid.Location = new System.Drawing.Point(952, 55);
            this.metroButtonFiltrarGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonFiltrarGrid.Name = "metroButtonFiltrarGrid";
            this.metroButtonFiltrarGrid.Size = new System.Drawing.Size(130, 42);
            this.metroButtonFiltrarGrid.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroButtonFiltrarGrid.TabIndex = 7;
            this.metroButtonFiltrarGrid.Text = "Filtrar";
            this.metroButtonFiltrarGrid.UseCustomBackColor = true;
            this.metroButtonFiltrarGrid.UseSelectable = true;
            this.metroButtonFiltrarGrid.UseStyleColors = true;
            this.metroButtonFiltrarGrid.Click += new System.EventHandler(this.metroButtonFiltrarGrid_Click);
            // 
            // metroLabelFiltrarGridExplicativo
            // 
            this.metroLabelFiltrarGridExplicativo.AutoSize = true;
            this.metroLabelFiltrarGridExplicativo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelFiltrarGridExplicativo.Location = new System.Drawing.Point(795, 23);
            this.metroLabelFiltrarGridExplicativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelFiltrarGridExplicativo.Name = "metroLabelFiltrarGridExplicativo";
            this.metroLabelFiltrarGridExplicativo.Size = new System.Drawing.Size(61, 15);
            this.metroLabelFiltrarGridExplicativo.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabelFiltrarGridExplicativo.TabIndex = 10;
            this.metroLabelFiltrarGridExplicativo.Text = "Filtrar grid:";
            // 
            // metroTextBoxFiltrar
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltrar.CustomButton.Image = null;
            this.metroTextBoxFiltrar.CustomButton.Location = new System.Drawing.Point(135, 3);
            this.metroTextBoxFiltrar.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBoxFiltrar.CustomButton.Name = "";
            this.metroTextBoxFiltrar.CustomButton.Size = new System.Drawing.Size(56, 57);
            this.metroTextBoxFiltrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltrar.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltrar.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltrar.CustomButton.Visible = false;
            this.metroTextBoxFiltrar.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.metroTextBoxFiltrar.Lines = new string[0];
            this.metroTextBoxFiltrar.Location = new System.Drawing.Point(795, 52);
            this.metroTextBoxFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBoxFiltrar.MaxLength = 100;
            this.metroTextBoxFiltrar.Name = "metroTextBoxFiltrar";
            this.metroTextBoxFiltrar.PasswordChar = '\0';
            this.metroTextBoxFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltrar.SelectedText = "";
            this.metroTextBoxFiltrar.SelectionLength = 0;
            this.metroTextBoxFiltrar.SelectionStart = 0;
            this.metroTextBoxFiltrar.ShortcutsEnabled = true;
            this.metroTextBoxFiltrar.Size = new System.Drawing.Size(130, 42);
            this.metroTextBoxFiltrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBoxFiltrar.TabIndex = 6;
            this.metroTextBoxFiltrar.UseSelectable = true;
            this.metroTextBoxFiltrar.UseStyleColors = true;
            this.metroTextBoxFiltrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTimeTermino
            // 
            this.metroDateTimeTermino.CustomFormat = "";
            this.metroDateTimeTermino.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeTermino.Location = new System.Drawing.Point(298, 106);
            this.metroDateTimeTermino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroDateTimeTermino.MinDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.metroDateTimeTermino.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeTermino.Name = "metroDateTimeTermino";
            this.metroDateTimeTermino.Size = new System.Drawing.Size(248, 26);
            this.metroDateTimeTermino.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDateTimeTermino.TabIndex = 2;
            this.metroDateTimeTermino.UseStyleColors = true;
            this.metroDateTimeTermino.ValueChanged += new System.EventHandler(this.metroDateTimeTermino_ValueChanged);
            // 
            // metroDateTimeInicio
            // 
            this.metroDateTimeInicio.CustomFormat = "";
            this.metroDateTimeInicio.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeInicio.Location = new System.Drawing.Point(22, 106);
            this.metroDateTimeInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroDateTimeInicio.MinDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.metroDateTimeInicio.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeInicio.Name = "metroDateTimeInicio";
            this.metroDateTimeInicio.Size = new System.Drawing.Size(248, 26);
            this.metroDateTimeInicio.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDateTimeInicio.TabIndex = 1;
            this.metroDateTimeInicio.UseStyleColors = true;
            this.metroDateTimeInicio.ValueChanged += new System.EventHandler(this.metroDateTimeInicio_ValueChanged);
            // 
            // metroLabelTerminoData
            // 
            this.metroLabelTerminoData.AutoSize = true;
            this.metroLabelTerminoData.Location = new System.Drawing.Point(298, 55);
            this.metroLabelTerminoData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelTerminoData.Name = "metroLabelTerminoData";
            this.metroLabelTerminoData.Size = new System.Drawing.Size(59, 19);
            this.metroLabelTerminoData.TabIndex = 8;
            this.metroLabelTerminoData.Text = "Término:";
            // 
            // metroLabelInicioData
            // 
            this.metroLabelInicioData.AutoSize = true;
            this.metroLabelInicioData.Location = new System.Drawing.Point(22, 55);
            this.metroLabelInicioData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelInicioData.Name = "metroLabelInicioData";
            this.metroLabelInicioData.Size = new System.Drawing.Size(42, 19);
            this.metroLabelInicioData.TabIndex = 7;
            this.metroLabelInicioData.Text = "Início:";
            // 
            // pictureBoxExportarPDF
            // 
            this.pictureBoxExportarPDF.BackgroundImage = global::MeNutri_Registros.Properties.Resources.pdf;
            this.pictureBoxExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExportarPDF.Enabled = false;
            this.pictureBoxExportarPDF.Location = new System.Drawing.Point(1197, 78);
            this.pictureBoxExportarPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxExportarPDF.Name = "pictureBoxExportarPDF";
            this.pictureBoxExportarPDF.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxExportarPDF.TabIndex = 6;
            this.pictureBoxExportarPDF.TabStop = false;
            this.pictureBoxExportarPDF.Click += new System.EventHandler(this.pictureBoxExportarPDF_Click);
            this.pictureBoxExportarPDF.MouseEnter += new System.EventHandler(this.pictureBoxExportarPDF_MouseEnter);
            // 
            // pictureBoxExportarExcel
            // 
            this.pictureBoxExportarExcel.BackgroundImage = global::MeNutri_Registros.Properties.Resources.xls;
            this.pictureBoxExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExportarExcel.Enabled = false;
            this.pictureBoxExportarExcel.Location = new System.Drawing.Point(1120, 78);
            this.pictureBoxExportarExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxExportarExcel.Name = "pictureBoxExportarExcel";
            this.pictureBoxExportarExcel.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxExportarExcel.TabIndex = 5;
            this.pictureBoxExportarExcel.TabStop = false;
            this.pictureBoxExportarExcel.Click += new System.EventHandler(this.pictureBoxExportarExcel_Click);
            this.pictureBoxExportarExcel.MouseEnter += new System.EventHandler(this.pictureBoxExportarExcel_MouseEnter);
            // 
            // metroButtonEditarRegistro
            // 
            this.metroButtonEditarRegistro.Enabled = false;
            this.metroButtonEditarRegistro.Location = new System.Drawing.Point(952, 106);
            this.metroButtonEditarRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonEditarRegistro.Name = "metroButtonEditarRegistro";
            this.metroButtonEditarRegistro.Size = new System.Drawing.Size(130, 42);
            this.metroButtonEditarRegistro.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonEditarRegistro.TabIndex = 8;
            this.metroButtonEditarRegistro.Text = "Editar";
            this.metroButtonEditarRegistro.UseCustomBackColor = true;
            this.metroButtonEditarRegistro.UseSelectable = true;
            this.metroButtonEditarRegistro.UseStyleColors = true;
            this.metroButtonEditarRegistro.Click += new System.EventHandler(this.metroButtonEditarRegistro_Click);
            // 
            // metroButtonVisualizarRegistro
            // 
            this.metroButtonVisualizarRegistro.Enabled = false;
            this.metroButtonVisualizarRegistro.Location = new System.Drawing.Point(795, 106);
            this.metroButtonVisualizarRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonVisualizarRegistro.Name = "metroButtonVisualizarRegistro";
            this.metroButtonVisualizarRegistro.Size = new System.Drawing.Size(130, 42);
            this.metroButtonVisualizarRegistro.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButtonVisualizarRegistro.TabIndex = 4;
            this.metroButtonVisualizarRegistro.Text = "Visualizar";
            this.metroButtonVisualizarRegistro.UseCustomBackColor = true;
            this.metroButtonVisualizarRegistro.UseSelectable = true;
            this.metroButtonVisualizarRegistro.UseStyleColors = true;
            this.metroButtonVisualizarRegistro.Click += new System.EventHandler(this.metroButtonVisualizarRegistro_Click);
            // 
            // metroLabelOrdenar
            // 
            this.metroLabelOrdenar.AutoSize = true;
            this.metroLabelOrdenar.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelOrdenar.Location = new System.Drawing.Point(586, 23);
            this.metroLabelOrdenar.Name = "metroLabelOrdenar";
            this.metroLabelOrdenar.Size = new System.Drawing.Size(75, 15);
            this.metroLabelOrdenar.TabIndex = 11;
            this.metroLabelOrdenar.Text = "Ordenar grid:";
            // 
            // TelaVisualizarTodosRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 865);
            this.Controls.Add(this.metroPanelControlesGrid);
            this.Controls.Add(this.metroGridVisualizacaoRegistros);
            this.Name = "TelaVisualizarTodosRegistros";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
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
        private MetroFramework.Controls.MetroLabel metroLabelFiltrarGridExplicativo;
        private MetroFramework.Controls.MetroComboBox metroComboBoxOrdenar;
        private MetroFramework.Controls.MetroButton metroButtonPesquisarRegistros;
        private MetroFramework.Controls.MetroButton metroButtonResetarFiltrosEGrid;
        private MetroFramework.Controls.MetroLabel metroLabelOrdenar;
    }
}