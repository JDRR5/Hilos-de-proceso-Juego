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
            this.IMG1 = new System.Windows.Forms.PictureBox();
            this.TMR_DESPLAZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            this.SuspendLayout();
            // 
            // TIMER_UNO
            // 
            this.TIMER_UNO.Interval = 1;
            this.TIMER_UNO.Tick += new System.EventHandler(this.TIMER_UNO_Tick);
            // 
            // IMG1
            // 
            this.IMG1.BackColor = System.Drawing.Color.Transparent;
            this.IMG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IMG1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IMG1.Image = ((System.Drawing.Image)(resources.GetObject("IMG1.Image")));
            this.IMG1.Location = new System.Drawing.Point(109, 21);
            this.IMG1.Margin = new System.Windows.Forms.Padding(2);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(390, 377);
            this.IMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            // 
            // TMR_DESPLAZAR
            // 
            this.TMR_DESPLAZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMR_DESPLAZAR.Location = new System.Drawing.Point(264, 450);
            this.TMR_DESPLAZAR.Margin = new System.Windows.Forms.Padding(2);
            this.TMR_DESPLAZAR.Name = "TMR_DESPLAZAR";
            this.TMR_DESPLAZAR.Size = new System.Drawing.Size(298, 56);
            this.TMR_DESPLAZAR.TabIndex = 3;
            this.TMR_DESPLAZAR.Text = "DESPLAZAR";
            this.TMR_DESPLAZAR.UseVisualStyleBackColor = true;
            this.TMR_DESPLAZAR.Click += new System.EventHandler(this.TMR_DESPLAZAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 523);
            this.Controls.Add(this.TMR_DESPLAZAR);
            this.Controls.Add(this.IMG1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IMG1;
        private System.Windows.Forms.Button TMR_DESPLAZAR;
        public System.Windows.Forms.Timer TIMER_UNO;
    }
}

