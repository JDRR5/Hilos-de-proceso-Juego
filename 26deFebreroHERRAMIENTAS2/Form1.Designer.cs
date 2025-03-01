namespace _26deFebreroHERRAMIENTAS2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TIMER_UNO = new System.Windows.Forms.Timer(this.components);
            this.Pelota = new System.Windows.Forms.PictureBox();
            this.Raqueta = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // TIMER_UNO
            // 
            this.TIMER_UNO.Interval = 40;
            this.TIMER_UNO.Tick += new System.EventHandler(this.TIMER_UNO_Tick);
            // 
            // Pelota
            // 
            this.Pelota.BackColor = System.Drawing.Color.Transparent;
            this.Pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pelota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pelota.Image = ((System.Drawing.Image)(resources.GetObject("Pelota.Image")));
            this.Pelota.Location = new System.Drawing.Point(40, 53);
            this.Pelota.Margin = new System.Windows.Forms.Padding(2);
            this.Pelota.Name = "Pelota";
            this.Pelota.Size = new System.Drawing.Size(133, 149);
            this.Pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pelota.TabIndex = 2;
            this.Pelota.TabStop = false;
            // 
            // Raqueta
            // 
            this.Raqueta.Image = ((System.Drawing.Image)(resources.GetObject("Raqueta.Image")));
            this.Raqueta.Location = new System.Drawing.Point(536, 53);
            this.Raqueta.Name = "Raqueta";
            this.Raqueta.Size = new System.Drawing.Size(70, 180);
            this.Raqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Raqueta.TabIndex = 4;
            this.Raqueta.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button1.Location = new System.Drawing.Point(235, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "DESPLAZA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_DESPLAZAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Raqueta);
            this.Controls.Add(this.Pelota);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pelota;
        public System.Windows.Forms.Timer TIMER_UNO;
        private System.Windows.Forms.PictureBox Raqueta;
        private System.Windows.Forms.Button button1;
    }
}

