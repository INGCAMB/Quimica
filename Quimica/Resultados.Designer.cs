namespace Quimica
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.label2 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultado = ---";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Orange;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(90, 454);
            this.salir.Margin = new System.Windows.Forms.Padding(2);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(171, 66);
            this.salir.TabIndex = 9;
            this.salir.Text = "Salir del programa";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Orange;
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.White;
            this.regresar.Location = new System.Drawing.Point(403, 454);
            this.regresar.Margin = new System.Windows.Forms.Padding(2);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(171, 66);
            this.regresar.TabIndex = 8;
            this.regresar.Text = "Regresar al menu";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(655, 165);
            this.label3.TabIndex = 7;
            this.label3.Text = "Información";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 145);
            this.label1.TabIndex = 6;
            this.label1.Text = "---";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(677, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}