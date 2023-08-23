namespace PracticaN2.EjerciciosPractica2
{
    partial class validaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.letraCaracterBox = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba un numero:";
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(39, 80);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(157, 20);
            this.numeroBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escriba una letra o caracter";
            // 
            // letraCaracterBox
            // 
            this.letraCaracterBox.Location = new System.Drawing.Point(39, 206);
            this.letraCaracterBox.Name = "letraCaracterBox";
            this.letraCaracterBox.Size = new System.Drawing.Size(157, 20);
            this.letraCaracterBox.TabIndex = 3;
            // 
            // Validar
            // 
            this.Validar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Validar.Location = new System.Drawing.Point(82, 281);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(65, 26);
            this.Validar.TabIndex = 4;
            this.Validar.Text = "Validar";
            this.Validar.UseVisualStyleBackColor = false;
            this.Validar.Click += new System.EventHandler(this.Validar_Click);
            // 
            // validaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 381);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.letraCaracterBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.label1);
            this.Name = "validaciones";
            this.Text = "validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letraCaracterBox;
        private System.Windows.Forms.Button Validar;
    }
}