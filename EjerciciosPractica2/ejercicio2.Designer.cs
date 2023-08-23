namespace PracticaN2.EjerciciosPractica2
{
    partial class ejercicio2
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
            this.bttLanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttLanzar
            // 
            this.bttLanzar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLanzar.Location = new System.Drawing.Point(37, 61);
            this.bttLanzar.Name = "bttLanzar";
            this.bttLanzar.Size = new System.Drawing.Size(124, 281);
            this.bttLanzar.TabIndex = 0;
            this.bttLanzar.Text = "Lanzar";
            this.bttLanzar.UseVisualStyleBackColor = false;
            this.bttLanzar.Click += new System.EventHandler(this.bttLanzar_Click);
            // 
            // ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 450);
            this.Controls.Add(this.bttLanzar);
            this.Name = "ejercicio2";
            this.Text = "ejercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttLanzar;
    }
}