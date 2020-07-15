namespace NoMasAccidentesWF
{
    partial class GestionarSolicitud
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcSolicitud = new MetroFramework.Controls.MetroTabControl();
            this.tpAñadirSolis = new MetroFramework.Controls.MetroTabPage();
            this.btnAñadirSolicitud = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grdProfesional = new MetroFramework.Controls.MetroGrid();
            this.btnRecargarListado = new MetroFramework.Controls.MetroButton();
            this.grdSolicitud = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tcSolicitud.SuspendLayout();
            this.tpAñadirSolis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSolicitud
            // 
            this.tcSolicitud.Controls.Add(this.tpAñadirSolis);
            this.tcSolicitud.Location = new System.Drawing.Point(16, 4);
            this.tcSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.tcSolicitud.Name = "tcSolicitud";
            this.tcSolicitud.SelectedIndex = 0;
            this.tcSolicitud.Size = new System.Drawing.Size(1161, 599);
            this.tcSolicitud.TabIndex = 0;
            this.tcSolicitud.UseSelectable = true;
            // 
            // tpAñadirSolis
            // 
            this.tpAñadirSolis.Controls.Add(this.btnAñadirSolicitud);
            this.tpAñadirSolis.Controls.Add(this.metroLabel1);
            this.tpAñadirSolis.Controls.Add(this.grdProfesional);
            this.tpAñadirSolis.Controls.Add(this.btnRecargarListado);
            this.tpAñadirSolis.Controls.Add(this.grdSolicitud);
            this.tpAñadirSolis.Controls.Add(this.metroLabel2);
            this.tpAñadirSolis.Controls.Add(this.metroLabel18);
            this.tpAñadirSolis.HorizontalScrollbarBarColor = true;
            this.tpAñadirSolis.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAñadirSolis.HorizontalScrollbarSize = 12;
            this.tpAñadirSolis.Location = new System.Drawing.Point(4, 38);
            this.tpAñadirSolis.Margin = new System.Windows.Forms.Padding(4);
            this.tpAñadirSolis.Name = "tpAñadirSolis";
            this.tpAñadirSolis.Size = new System.Drawing.Size(1153, 557);
            this.tpAñadirSolis.TabIndex = 0;
            this.tpAñadirSolis.Text = "Añadir Solicitud";
            this.tpAñadirSolis.VerticalScrollbarBarColor = true;
            this.tpAñadirSolis.VerticalScrollbarHighlightOnWheel = false;
            this.tpAñadirSolis.VerticalScrollbarSize = 13;
            // 
            // btnAñadirSolicitud
            // 
            this.btnAñadirSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAñadirSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnAñadirSolicitud.Location = new System.Drawing.Point(437, 499);
            this.btnAñadirSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirSolicitud.Name = "btnAñadirSolicitud";
            this.btnAñadirSolicitud.Size = new System.Drawing.Size(264, 28);
            this.btnAñadirSolicitud.Style = MetroFramework.MetroColorStyle.White;
            this.btnAñadirSolicitud.TabIndex = 39;
            this.btnAñadirSolicitud.Text = "Añadir Solicitud";
            this.btnAñadirSolicitud.UseCustomBackColor = true;
            this.btnAñadirSolicitud.UseCustomForeColor = true;
            this.btnAñadirSolicitud.UseSelectable = true;
            this.btnAñadirSolicitud.UseStyleColors = true;
            this.btnAñadirSolicitud.Click += new System.EventHandler(this.btnAñadirSolicitud_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 250);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 20);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Seleccionar Profesional:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // grdProfesional
            // 
            this.grdProfesional.AllowUserToResizeRows = false;
            this.grdProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProfesional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProfesional.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProfesional.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProfesional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProfesional.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProfesional.EnableHeadersVisualStyles = false;
            this.grdProfesional.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProfesional.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProfesional.Location = new System.Drawing.Point(-16, 284);
            this.grdProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.grdProfesional.Name = "grdProfesional";
            this.grdProfesional.ReadOnly = true;
            this.grdProfesional.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProfesional.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProfesional.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProfesional.Size = new System.Drawing.Size(1136, 188);
            this.grdProfesional.TabIndex = 41;
            this.grdProfesional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfesional_CellClick);
            // 
            // btnRecargarListado
            // 
            this.btnRecargarListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecargarListado.ForeColor = System.Drawing.Color.White;
            this.btnRecargarListado.Location = new System.Drawing.Point(301, 36);
            this.btnRecargarListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecargarListado.Name = "btnRecargarListado";
            this.btnRecargarListado.Size = new System.Drawing.Size(225, 28);
            this.btnRecargarListado.Style = MetroFramework.MetroColorStyle.White;
            this.btnRecargarListado.TabIndex = 40;
            this.btnRecargarListado.Text = "Recargar Listado";
            this.btnRecargarListado.UseCustomBackColor = true;
            this.btnRecargarListado.UseCustomForeColor = true;
            this.btnRecargarListado.UseSelectable = true;
            this.btnRecargarListado.UseStyleColors = true;
            this.btnRecargarListado.Click += new System.EventHandler(this.btnRecargarListado_Click);
            // 
            // grdSolicitud
            // 
            this.grdSolicitud.AllowUserToResizeRows = false;
            this.grdSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSolicitud.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSolicitud.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSolicitud.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdSolicitud.EnableHeadersVisualStyles = false;
            this.grdSolicitud.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdSolicitud.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSolicitud.Location = new System.Drawing.Point(4, 80);
            this.grdSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.grdSolicitud.Name = "grdSolicitud";
            this.grdSolicitud.ReadOnly = true;
            this.grdSolicitud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSolicitud.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdSolicitud.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSolicitud.Size = new System.Drawing.Size(1116, 145);
            this.grdSolicitud.TabIndex = 37;
            this.grdSolicitud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSolicitud_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 44);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 20);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Seleccionar Cliente:";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Red;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.ForeColor = System.Drawing.Color.Red;
            this.metroLabel18.Location = new System.Drawing.Point(4, 14);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(136, 25);
            this.metroLabel18.TabIndex = 33;
            this.metroLabel18.Text = "Añadir Solicitud";
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(-7, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1271, 58);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // GestionarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.tcSolicitud);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarSolicitud";
            this.Size = new System.Drawing.Size(1200, 615);
            this.tcSolicitud.ResumeLayout(false);
            this.tpAñadirSolis.ResumeLayout(false);
            this.tpAñadirSolis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid grdSolicitud;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroButton btnAñadirSolicitud;
        private MetroFramework.Controls.MetroButton btnRecargarListado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid grdProfesional;
        public MetroFramework.Controls.MetroTabControl tcSolicitud;
        public MetroFramework.Controls.MetroTabPage tpAñadirSolis;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
