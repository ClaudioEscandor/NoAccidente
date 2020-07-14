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
            this.TcReportes = new MetroFramework.Controls.MetroTabControl();
            this.tpPago = new MetroFramework.Controls.MetroTabPage();
            this.tpAccidentes = new MetroFramework.Controls.MetroTabPage();
            this.TcReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcReportes
            // 
            this.TcReportes.Controls.Add(this.tpPago);
            this.TcReportes.Controls.Add(this.tpAccidentes);
            this.TcReportes.Location = new System.Drawing.Point(19, 17);
            this.TcReportes.Name = "TcReportes";
            this.TcReportes.SelectedIndex = 1;
            this.TcReportes.Size = new System.Drawing.Size(1063, 753);
            this.TcReportes.TabIndex = 0;
            this.TcReportes.UseSelectable = true;
            // 
            // tpPago
            // 
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
            // tpAccidentes
            // 
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
            // GestionarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TcReportes);
            this.Name = "GestionarReportes";
            this.Size = new System.Drawing.Size(1103, 786);
            this.Load += new System.EventHandler(this.GestionarReportes_Load);
            this.TcReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTabControl TcReportes;
        public MetroFramework.Controls.MetroTabPage tpPago;
        public MetroFramework.Controls.MetroTabPage tpAccidentes;
    }
}