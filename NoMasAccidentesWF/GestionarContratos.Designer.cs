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
            this.tcContratos = new MetroFramework.Controls.MetroTabControl();
            this.tpLstContrato = new MetroFramework.Controls.MetroTabPage();
            this.btnLstContratos = new MetroFramework.Controls.MetroButton();
            this.grdLstContratos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAceptarContrato = new MetroFramework.Controls.MetroButton();
            this.tcContratos.SuspendLayout();
            this.tpLstContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLstContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // tcContratos
            // 
            this.tcContratos.Controls.Add(this.tpLstContrato);
            this.tcContratos.Location = new System.Drawing.Point(0, 0);
            this.tcContratos.Margin = new System.Windows.Forms.Padding(4);
            this.tcContratos.Name = "tcContratos";
            this.tcContratos.SelectedIndex = 0;
            this.tcContratos.Size = new System.Drawing.Size(900, 338);
            this.tcContratos.TabIndex = 0;
            this.tcContratos.UseSelectable = true;
            // 
            // tpLstContrato
            // 
            this.tpLstContrato.Controls.Add(this.grdLstContratos);
            this.tpLstContrato.Controls.Add(this.metroLabel6);
            this.tpLstContrato.HorizontalScrollbarBarColor = true;
            this.tpLstContrato.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLstContrato.HorizontalScrollbarSize = 12;
            this.tpLstContrato.Location = new System.Drawing.Point(4, 38);
            this.tpLstContrato.Margin = new System.Windows.Forms.Padding(4);
            this.tpLstContrato.Name = "tpLstContrato";
            this.tpLstContrato.Size = new System.Drawing.Size(892, 296);
            this.tpLstContrato.TabIndex = 1;
            this.tpLstContrato.Text = "Listado de Contratos";
            this.tpLstContrato.VerticalScrollbarBarColor = true;
            this.tpLstContrato.VerticalScrollbarHighlightOnWheel = false;
            this.tpLstContrato.VerticalScrollbarSize = 13;
            // 
            // btnLstContratos
            // 
            this.btnLstContratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLstContratos.Location = new System.Drawing.Point(938, 174);
            this.btnLstContratos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLstContratos.Name = "btnLstContratos";
            this.btnLstContratos.Size = new System.Drawing.Size(195, 35);
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
            this.grdLstContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.grdLstContratos.Location = new System.Drawing.Point(5, 60);
            this.grdLstContratos.Margin = new System.Windows.Forms.Padding(4);
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
            this.grdLstContratos.Size = new System.Drawing.Size(885, 375);
            this.grdLstContratos.TabIndex = 14;
            this.grdLstContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLstContratos_CellContentClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Red;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.ForeColor = System.Drawing.Color.Red;
            this.metroLabel6.Location = new System.Drawing.Point(0, 11);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(178, 25);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Listado de Contratos";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1200, 45);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // btnAceptarContrato
            // 
            this.btnAceptarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAceptarContrato.Location = new System.Drawing.Point(324, 488);
            this.btnAceptarContrato.Name = "btnAceptarContrato";
            this.btnAceptarContrato.Size = new System.Drawing.Size(175, 50);
            this.btnAceptarContrato.Style = MetroFramework.MetroColorStyle.White;
            this.btnAceptarContrato.TabIndex = 19;
            this.btnAceptarContrato.Text = "Aceptar Contrato";
            this.btnAceptarContrato.UseCustomBackColor = true;
            this.btnAceptarContrato.UseSelectable = true;
            this.btnAceptarContrato.UseStyleColors = true;
            this.btnAceptarContrato.Click += new System.EventHandler(this.btnAceptarContrato_Click);
            // 
            // GestionarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAceptarContrato);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnLstContratos);
            this.Controls.Add(this.tcContratos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarContratos";
            this.Size = new System.Drawing.Size(1200, 649);
            this.tcContratos.ResumeLayout(false);
            this.tpLstContrato.ResumeLayout(false);
            this.tpLstContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLstContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid grdLstContratos;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnLstContratos;
        public MetroFramework.Controls.MetroTabPage tpLstContrato;
        public MetroFramework.Controls.MetroTabControl tcContratos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnAceptarContrato;
    }
}