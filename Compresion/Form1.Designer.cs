namespace Compresion
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.BttnCargar = new System.Windows.Forms.Button();
            this.BttnComprimir = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label1.Location = new System.Drawing.Point(84, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRESOR DE ARCHIVOS";
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(129, 180);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(515, 22);
            this.TxtRuta.TabIndex = 1;
            // 
            // BttnCargar
            // 
            this.BttnCargar.Location = new System.Drawing.Point(144, 302);
            this.BttnCargar.Name = "BttnCargar";
            this.BttnCargar.Size = new System.Drawing.Size(75, 23);
            this.BttnCargar.TabIndex = 2;
            this.BttnCargar.Text = "Cargar";
            this.BttnCargar.UseVisualStyleBackColor = true;
            this.BttnCargar.Click += new System.EventHandler(this.BttnCargar_Click);
            // 
            // BttnComprimir
            // 
            this.BttnComprimir.Location = new System.Drawing.Point(531, 302);
            this.BttnComprimir.Name = "BttnComprimir";
            this.BttnComprimir.Size = new System.Drawing.Size(75, 23);
            this.BttnComprimir.TabIndex = 3;
            this.BttnComprimir.Text = "Comprimir";
            this.BttnComprimir.UseVisualStyleBackColor = true;
            this.BttnComprimir.Click += new System.EventHandler(this.BttnComprimir_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Zip",
            "Deflate",
            "Gzip"});
            this.checkedListBox1.Location = new System.Drawing.Point(301, 217);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BttnComprimir);
            this.Controls.Add(this.BttnCargar);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.Button BttnCargar;
        private System.Windows.Forms.Button BttnComprimir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

