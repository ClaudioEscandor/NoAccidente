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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TcReportes.Location = new System.Drawing.Point(14, 14);
            this.TcReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TcReportes.Name = "TcReportes";
            this.TcReportes.SelectedIndex = 0;
            this.TcReportes.Size = new System.Drawing.Size(797, 612);
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
            this.tpPago.HorizontalScrollbarSize = 8;
            this.tpPago.Location = new System.Drawing.Point(4, 38);
            this.tpPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPago.Name = "tpPago";
            this.tpPago.Size = new System.Drawing.Size(789, 570);
            this.tpPago.TabIndex = 0;
            this.tpPago.Text = "Detalle Pago";
            this.tpPago.VerticalScrollbarBarColor = true;
            this.tpPago.VerticalScrollbarHighlightOnWheel = false;
            this.tpPago.VerticalScrollbarSize = 8;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPDF.Location = new System.Drawing.Point(378, 406);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(146, 28);
            this.btnPDF.Style = MetroFramework.MetroColorStyle.White;
            this.btnPDF.TabIndex = 35;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseCustomBackColor = true;
            this.btnPDF.UseSelectable = true;
            this.btnPDF.UseStyleColors = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Red;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.ForeColor = System.Drawing.Color.Red;
            this.metroLabel18.Location = new System.Drawing.Point(18, 19);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(101, 25);
            this.metroLabel18.TabIndex = 34;
            this.metroLabel18.Text = "Listar Pagos";
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // btnListarPago
            // 
            this.btnListarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarPago.Location = new System.Drawing.Point(212, 406);
            this.btnListarPago.Name = "btnListarPago";
            this.btnListarPago.Size = new System.Drawing.Size(146, 28);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grListarDetaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grListarDetaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grListarDetaPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.grListarDetaPago.EnableHeadersVisualStyles = false;
            this.grListarDetaPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grListarDetaPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grListarDetaPago.Location = new System.Drawing.Point(62, 58);
            this.grListarDetaPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grListarDetaPago.Name = "grListarDetaPago";
            this.grListarDetaPago.ReadOnly = true;
            this.grListarDetaPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grListarDetaPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grListarDetaPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grListarDetaPago.RowTemplate.Height = 24;
            this.grListarDetaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grListarDetaPago.Size = new System.Drawing.Size(647, 288);
            this.grListarDetaPago.TabIndex = 2;
            this.grListarDetaPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grListarDetaPago_CellContentClick);
            // 
            // tpAccidentes
            // 
            this.tpAccidentes.Controls.Add(this.grdAccidente);
            this.tpAccidentes.Controls.Add(this.metroLabel1);
            this.tpAccidentes.HorizontalScrollbarBarColor = true;
            this.tpAccidentes.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAccidentes.HorizontalScrollbarSize = 8;
            this.tpAccidentes.Location = new System.Drawing.Point(4, 38);
            this.tpAccidentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAccidentes.Name = "tpAccidentes";
            this.tpAccidentes.Size = new System.Drawing.Size(789, 570);
            this.tpAccidentes.TabIndex = 1;
            this.tpAccidentes.Text = "Accidentes clientes";
            this.tpAccidentes.VerticalScrollbarBarColor = true;
            this.tpAccidentes.VerticalScrollbarHighlightOnWheel = false;
            this.tpAccidentes.VerticalScrollbarSize = 8;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAccidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccidente.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdAccidente.EnableHeadersVisualStyles = false;
            this.grdAccidente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAccidente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAccidente.Location = new System.Drawing.Point(47, 79);
            this.grdAccidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdAccidente.Name = "grdAccidente";
            this.grdAccidente.ReadOnly = true;
            this.grdAccidente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAccidente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAccidente.RowTemplate.Height = 24;
            this.grdAccidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccidente.Size = new System.Drawing.Size(647, 288);
            this.grdAccidente.TabIndex = 36;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Red;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(13, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 25);
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
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-36, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(936, 60);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // GestionarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TcReportes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionarReportes";
            this.Size = new System.Drawing.Size(827, 639);
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