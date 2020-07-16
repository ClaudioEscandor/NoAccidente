namespace NoMasAccidentesWF
{
    partial class GestionarReportes
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
            this.TcReportes = new MetroFramework.Controls.MetroTabControl();
            this.tpPago = new MetroFramework.Controls.MetroTabPage();
            this.btnPDF = new MetroFramework.Controls.MetroButton();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btnListarPago = new MetroFramework.Controls.MetroButton();
            this.grListarDetaPago = new MetroFramework.Controls.MetroGrid();
            this.tpAccidentes = new MetroFramework.Controls.MetroTabPage();
            this.grdAccidente = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TcReportes.SuspendLayout();
            this.tpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grListarDetaPago)).BeginInit();
            this.tpAccidentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccidente)).BeginInit();
            this.SuspendLayout();
            // 
            // TcReportes
            // 
            this.TcReportes.Controls.Add(this.tpPago);
            this.TcReportes.Controls.Add(this.tpAccidentes);
            this.TcReportes.Location = new System.Drawing.Point(19, 17);
            this.TcReportes.Name = "TcReportes";
            this.TcReportes.SelectedIndex = 0;
            this.TcReportes.Size = new System.Drawing.Size(1063, 753);
            this.TcReportes.TabIndex = 0;
            this.TcReportes.UseSelectable = true;
            // 
            // tpPago
            // 
            this.tpPago.Controls.Add(this.btnPDF);
            this.tpPago.Controls.Add(this.metroLabel18);
            this.tpPago.Controls.Add(this.btnListarPago);
            this.tpPago.Controls.Add(this.grListarDetaPago);
            this.tpPago.HorizontalScrollbarBarColor = true;
            this.tpPago.HorizontalScrollbarHighlightOnWheel = false;
            this.tpPago.HorizontalScrollbarSize = 10;
            this.tpPago.Location = new System.Drawing.Point(4, 38);
            this.tpPago.Name = "tpPago";
            this.tpPago.Size = new System.Drawing.Size(1055, 711);
            this.tpPago.TabIndex = 0;
            this.tpPago.Text = "Detalle Pago";
            this.tpPago.VerticalScrollbarBarColor = true;
            this.tpPago.VerticalScrollbarHighlightOnWheel = false;
            this.tpPago.VerticalScrollbarSize = 10;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPDF.Location = new System.Drawing.Point(504, 500);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(194, 35);
            this.btnPDF.Style = MetroFramework.MetroColorStyle.White;
            this.btnPDF.TabIndex = 35;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseCustomBackColor = true;
            this.btnPDF.UseSelectable = true;
            this.btnPDF.UseStyleColors = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Red;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.ForeColor = System.Drawing.Color.Red;
            this.metroLabel18.Location = new System.Drawing.Point(24, 23);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(105, 25);
            this.metroLabel18.TabIndex = 34;
            this.metroLabel18.Text = "Listar Pagos";
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // btnListarPago
            // 
            this.btnListarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarPago.Location = new System.Drawing.Point(283, 500);
            this.btnListarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPago.Name = "btnListarPago";
            this.btnListarPago.Size = new System.Drawing.Size(195, 35);
            this.btnListarPago.Style = MetroFramework.MetroColorStyle.White;
            this.btnListarPago.TabIndex = 19;
            this.btnListarPago.Text = "Listar Pagos";
            this.btnListarPago.UseCustomBackColor = true;
            this.btnListarPago.UseSelectable = true;
            this.btnListarPago.UseStyleColors = true;
            this.btnListarPago.Click += new System.EventHandler(this.btnListarPago_Click);
            // 
            // grListarDetaPago
            // 
            this.grListarDetaPago.AllowUserToResizeRows = false;
            this.grListarDetaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grListarDetaPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grListarDetaPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grListarDetaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grListarDetaPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grListarDetaPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grListarDetaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grListarDetaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grListarDetaPago.DefaultCellStyle = dataGridViewCellStyle8;
            this.grListarDetaPago.EnableHeadersVisualStyles = false;
            this.grListarDetaPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grListarDetaPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grListarDetaPago.Location = new System.Drawing.Point(83, 72);
            this.grListarDetaPago.Name = "grListarDetaPago";
            this.grListarDetaPago.ReadOnly = true;
            this.grListarDetaPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grListarDetaPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grListarDetaPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grListarDetaPago.RowTemplate.Height = 24;
            this.grListarDetaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grListarDetaPago.Size = new System.Drawing.Size(863, 355);
            this.grListarDetaPago.TabIndex = 2;
            // 
            // tpAccidentes
            // 
            this.tpAccidentes.Controls.Add(this.grdAccidente);
            this.tpAccidentes.Controls.Add(this.metroLabel1);
            this.tpAccidentes.HorizontalScrollbarBarColor = true;
            this.tpAccidentes.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAccidentes.HorizontalScrollbarSize = 10;
            this.tpAccidentes.Location = new System.Drawing.Point(4, 38);
            this.tpAccidentes.Name = "tpAccidentes";
            this.tpAccidentes.Size = new System.Drawing.Size(1055, 711);
            this.tpAccidentes.TabIndex = 1;
            this.tpAccidentes.Text = "Accidentes clientes";
            this.tpAccidentes.VerticalScrollbarBarColor = true;
            this.tpAccidentes.VerticalScrollbarHighlightOnWheel = false;
            this.tpAccidentes.VerticalScrollbarSize = 10;
            // 
            // grdAccidente
            // 
            this.grdAccidente.AllowUserToResizeRows = false;
            this.grdAccidente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAccidente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAccidente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAccidente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAccidente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAccidente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdAccidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccidente.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdAccidente.EnableHeadersVisualStyles = false;
            this.grdAccidente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAccidente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAccidente.Location = new System.Drawing.Point(63, 97);
            this.grdAccidente.Name = "grdAccidente";
            this.grdAccidente.ReadOnly = true;
            this.grdAccidente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidente.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdAccidente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAccidente.RowTemplate.Height = 24;
            this.grdAccidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccidente.Size = new System.Drawing.Size(863, 355);
            this.grdAccidente.TabIndex = 36;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Red;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(17, 29);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 25);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Listar Accidentes";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(-48, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1248, 74);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // GestionarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TcReportes);
            this.Name = "GestionarReportes";
            this.Size = new System.Drawing.Size(1103, 786);
            this.Load += new System.EventHandler(this.GestionarReportes_Load);
            this.TcReportes.ResumeLayout(false);
            this.tpPago.ResumeLayout(false);
            this.tpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grListarDetaPago)).EndInit();
            this.tpAccidentes.ResumeLayout(false);
            this.tpAccidentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccidente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTabControl TcReportes;
        public MetroFramework.Controls.MetroTabPage tpPago;
        public MetroFramework.Controls.MetroTabPage tpAccidentes;
        private MetroFramework.Controls.MetroGrid grListarDetaPago;
        private MetroFramework.Controls.MetroButton btnListarPago;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroGrid grdAccidente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPDF;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}