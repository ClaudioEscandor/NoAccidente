namespace NoMasAccidentesWF
{
    partial class GestionarContratos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcContratos = new MetroFramework.Controls.MetroTabControl();
            this.tpLstContrato = new MetroFramework.Controls.MetroTabPage();
            this.btnLstContratos = new MetroFramework.Controls.MetroButton();
            this.grdLstContratos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tpEditarContrato = new MetroFramework.Controls.MetroTabPage();
            this.dpFecExpiracion = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.chkMantencion = new MetroFramework.Controls.MetroCheckBox();
            this.chkSeguridad = new MetroFramework.Controls.MetroCheckBox();
            this.chkAsesoria = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grdEditContrato = new MetroFramework.Controls.MetroGrid();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.cboTipoContrEdit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDetContrEdit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnEditContrato = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tcContratos.SuspendLayout();
            this.tpLstContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLstContratos)).BeginInit();
            this.tpEditarContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // tcContratos
            // 
            this.tcContratos.Controls.Add(this.tpLstContrato);
            this.tcContratos.Controls.Add(this.tpEditarContrato);
            this.tcContratos.Location = new System.Drawing.Point(0, 0);
            this.tcContratos.Name = "tcContratos";
            this.tcContratos.SelectedIndex = 1;
            this.tcContratos.Size = new System.Drawing.Size(900, 500);
            this.tcContratos.TabIndex = 0;
            this.tcContratos.UseSelectable = true;
            // 
            // tpLstContrato
            // 
            this.tpLstContrato.Controls.Add(this.btnLstContratos);
            this.tpLstContrato.Controls.Add(this.grdLstContratos);
            this.tpLstContrato.Controls.Add(this.metroLabel6);
            this.tpLstContrato.HorizontalScrollbarBarColor = true;
            this.tpLstContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLstContrato.HorizontalScrollbarSize = 10;
            this.tpLstContrato.Location = new System.Drawing.Point(4, 38);
            this.tpLstContrato.Name = "tpLstContrato";
            this.tpLstContrato.Size = new System.Drawing.Size(892, 458);
            this.tpLstContrato.TabIndex = 1;
            this.tpLstContrato.Text = "Listado de Contratos";
            this.tpLstContrato.VerticalScrollbarBarColor = true;
            this.tpLstContrato.VerticalScrollbarHighlightOnWheel = false;
            this.tpLstContrato.VerticalScrollbarSize = 10;
            // 
            // btnLstContratos
            // 
            this.btnLstContratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLstContratos.Location = new System.Drawing.Point(519, 12);
            this.btnLstContratos.Name = "btnLstContratos";
            this.btnLstContratos.Size = new System.Drawing.Size(145, 23);
            this.btnLstContratos.Style = MetroFramework.MetroColorStyle.White;
            this.btnLstContratos.TabIndex = 18;
            this.btnLstContratos.Text = "Listar Contratos";
            this.btnLstContratos.UseCustomBackColor = true;
            this.btnLstContratos.UseSelectable = true;
            this.btnLstContratos.UseStyleColors = true;
            // 
            // grdLstContratos
            // 
            this.grdLstContratos.AllowUserToResizeRows = false;
            this.grdLstContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLstContratos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLstContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLstContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdLstContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLstContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdLstContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLstContratos.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdLstContratos.EnableHeadersVisualStyles = false;
            this.grdLstContratos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdLstContratos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLstContratos.Location = new System.Drawing.Point(4, 49);
            this.grdLstContratos.Name = "grdLstContratos";
            this.grdLstContratos.ReadOnly = true;
            this.grdLstContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLstContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdLstContratos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLstContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLstContratos.Size = new System.Drawing.Size(892, 413);
            this.grdLstContratos.TabIndex = 14;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Red;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.ForeColor = System.Drawing.Color.Red;
            this.metroLabel6.Location = new System.Drawing.Point(0, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(167, 25);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Listado de Contratos";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // tpEditarContrato
            // 
            this.tpEditarContrato.Controls.Add(this.dpFecExpiracion);
            this.tpEditarContrato.Controls.Add(this.metroLabel11);
            this.tpEditarContrato.Controls.Add(this.chkMantencion);
            this.tpEditarContrato.Controls.Add(this.chkSeguridad);
            this.tpEditarContrato.Controls.Add(this.chkAsesoria);
            this.tpEditarContrato.Controls.Add(this.metroLabel10);
            this.tpEditarContrato.Controls.Add(this.metroLabel9);
            this.tpEditarContrato.Controls.Add(this.metroLabel2);
            this.tpEditarContrato.Controls.Add(this.grdEditContrato);
            this.tpEditarContrato.Controls.Add(this.metroButton2);
            this.tpEditarContrato.Controls.Add(this.metroTextBox2);
            this.tpEditarContrato.Controls.Add(this.metroLabel16);
            this.tpEditarContrato.Controls.Add(this.cboTipoContrEdit);
            this.tpEditarContrato.Controls.Add(this.metroLabel1);
            this.tpEditarContrato.Controls.Add(this.txtDetContrEdit);
            this.tpEditarContrato.Controls.Add(this.metroLabel3);
            this.tpEditarContrato.Controls.Add(this.metroLabel5);
            this.tpEditarContrato.Controls.Add(this.btnEditContrato);
            this.tpEditarContrato.HorizontalScrollbarBarColor = true;
            this.tpEditarContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.tpEditarContrato.HorizontalScrollbarSize = 10;
            this.tpEditarContrato.Location = new System.Drawing.Point(4, 38);
            this.tpEditarContrato.Name = "tpEditarContrato";
            this.tpEditarContrato.Size = new System.Drawing.Size(892, 458);
            this.tpEditarContrato.TabIndex = 2;
            this.tpEditarContrato.Text = "Editar Contrato";
            this.tpEditarContrato.VerticalScrollbarBarColor = true;
            this.tpEditarContrato.VerticalScrollbarHighlightOnWheel = false;
            this.tpEditarContrato.VerticalScrollbarSize = 10;
            // 
            // dpFecExpiracion
            // 
            this.dpFecExpiracion.Location = new System.Drawing.Point(729, 139);
            this.dpFecExpiracion.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpFecExpiracion.Name = "dpFecExpiracion";
            this.dpFecExpiracion.Size = new System.Drawing.Size(146, 29);
            this.dpFecExpiracion.TabIndex = 44;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(3, 69);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(153, 19);
            this.metroLabel11.TabIndex = 43;
            this.metroLabel11.Text = "Seleccione un Contrato:";
            // 
            // chkMantencion
            // 
            this.chkMantencion.AutoSize = true;
            this.chkMantencion.Location = new System.Drawing.Point(683, 195);
            this.chkMantencion.Name = "chkMantencion";
            this.chkMantencion.Size = new System.Drawing.Size(87, 15);
            this.chkMantencion.TabIndex = 42;
            this.chkMantencion.Text = "Mantencion";
            this.chkMantencion.UseSelectable = true;
            // 
            // chkSeguridad
            // 
            this.chkSeguridad.AutoSize = true;
            this.chkSeguridad.Location = new System.Drawing.Point(756, 172);
            this.chkSeguridad.Name = "chkSeguridad";
            this.chkSeguridad.Size = new System.Drawing.Size(76, 15);
            this.chkSeguridad.TabIndex = 41;
            this.chkSeguridad.Text = "Seguridad";
            this.chkSeguridad.UseSelectable = true;
            // 
            // chkAsesoria
            // 
            this.chkAsesoria.AutoSize = true;
            this.chkAsesoria.Location = new System.Drawing.Point(683, 172);
            this.chkAsesoria.Name = "chkAsesoria";
            this.chkAsesoria.Size = new System.Drawing.Size(67, 15);
            this.chkAsesoria.TabIndex = 40;
            this.chkAsesoria.Text = "Asesoria";
            this.chkAsesoria.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(617, 168);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 19);
            this.metroLabel10.TabIndex = 39;
            this.metroLabel10.Text = "Servicios";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(616, 69);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 38;
            this.metroLabel9.Text = "Contrato:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(616, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Fecha Expiración";
            // 
            // grdEditContrato
            // 
            this.grdEditContrato.AllowUserToResizeRows = false;
            this.grdEditContrato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEditContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEditContrato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdEditContrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEditContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdEditContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEditContrato.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdEditContrato.EnableHeadersVisualStyles = false;
            this.grdEditContrato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEditContrato.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEditContrato.Location = new System.Drawing.Point(12, 104);
            this.grdEditContrato.Name = "grdEditContrato";
            this.grdEditContrato.ReadOnly = true;
            this.grdEditContrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEditContrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdEditContrato.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEditContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEditContrato.Size = new System.Drawing.Size(586, 338);
            this.grdEditContrato.TabIndex = 35;
            this.grdEditContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEditContrato_CellClick);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButton2.Location = new System.Drawing.Point(414, 39);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(134, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton2.TabIndex = 34;
            this.metroButton2.Text = "Buscar Contrato";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Visible = false;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(185, 39);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox2.TabIndex = 33;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.Visible = false;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(93, 39);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(72, 19);
            this.metroLabel16.TabIndex = 32;
            this.metroLabel16.Text = "Rut Cliente";
            this.metroLabel16.Visible = false;
            // 
            // cboTipoContrEdit
            // 
            this.cboTipoContrEdit.FormattingEnabled = true;
            this.cboTipoContrEdit.ItemHeight = 23;
            this.cboTipoContrEdit.Location = new System.Drawing.Point(729, 104);
            this.cboTipoContrEdit.Name = "cboTipoContrEdit";
            this.cboTipoContrEdit.Size = new System.Drawing.Size(146, 29);
            this.cboTipoContrEdit.TabIndex = 31;
            this.cboTipoContrEdit.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(616, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Tipo Contrato";
            // 
            // txtDetContrEdit
            // 
            // 
            // 
            // 
            this.txtDetContrEdit.CustomButton.Image = null;
            this.txtDetContrEdit.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtDetContrEdit.CustomButton.Name = "";
            this.txtDetContrEdit.CustomButton.Size = new System.Drawing.Size(173, 173);
            this.txtDetContrEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetContrEdit.CustomButton.TabIndex = 1;
            this.txtDetContrEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetContrEdit.CustomButton.UseSelectable = true;
            this.txtDetContrEdit.CustomButton.Visible = false;
            this.txtDetContrEdit.Lines = new string[0];
            this.txtDetContrEdit.Location = new System.Drawing.Point(618, 235);
            this.txtDetContrEdit.MaxLength = 32767;
            this.txtDetContrEdit.Name = "txtDetContrEdit";
            this.txtDetContrEdit.PasswordChar = '\0';
            this.txtDetContrEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetContrEdit.SelectedText = "";
            this.txtDetContrEdit.SelectionLength = 0;
            this.txtDetContrEdit.SelectionStart = 0;
            this.txtDetContrEdit.ShortcutsEnabled = true;
            this.txtDetContrEdit.Size = new System.Drawing.Size(259, 178);
            this.txtDetContrEdit.TabIndex = 28;
            this.txtDetContrEdit.UseSelectable = true;
            this.txtDetContrEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetContrEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(618, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Detalle Contrato";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(8, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 25);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Editar Contrato";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // btnEditContrato
            // 
            this.btnEditContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditContrato.Location = new System.Drawing.Point(618, 419);
            this.btnEditContrato.Name = "btnEditContrato";
            this.btnEditContrato.Size = new System.Drawing.Size(259, 23);
            this.btnEditContrato.Style = MetroFramework.MetroColorStyle.White;
            this.btnEditContrato.TabIndex = 11;
            this.btnEditContrato.Text = "Editar";
            this.btnEditContrato.UseCustomBackColor = true;
            this.btnEditContrato.UseSelectable = true;
            this.btnEditContrato.UseStyleColors = true;
            this.btnEditContrato.Click += new System.EventHandler(this.btnEditContrato_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(900, 47);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // GestionarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.tcContratos);
            this.Name = "GestionarContratos";
            this.Size = new System.Drawing.Size(900, 527);
            this.tcContratos.ResumeLayout(false);
            this.tpLstContrato.ResumeLayout(false);
            this.tpLstContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLstContratos)).EndInit();
            this.tpEditarContrato.ResumeLayout(false);
            this.tpEditarContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnEditContrato;
        private MetroFramework.Controls.MetroGrid grdLstContratos;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboTipoContrEdit;
        private MetroFramework.Controls.MetroTextBox txtDetContrEdit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnLstContratos;
        private MetroFramework.Controls.MetroGrid grdEditContrato;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkSeguridad;
        private MetroFramework.Controls.MetroCheckBox chkAsesoria;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroCheckBox chkMantencion;
        private MetroFramework.Controls.MetroDateTime dpFecExpiracion;
        public MetroFramework.Controls.MetroTabPage tpLstContrato;
        public MetroFramework.Controls.MetroTabPage tpEditarContrato;
        public MetroFramework.Controls.MetroTabControl tcContratos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}