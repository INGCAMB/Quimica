namespace Quimica
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conf_contra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.conf_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.ForestGreen;
            this.regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.White;
            this.regresar.Location = new System.Drawing.Point(12, 12);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(76, 29);
            this.regresar.TabIndex = 0;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crear una cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Crea un nombre para tu cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "No más de 40 caracteres";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(20, 134);
            this.nombre.MaxLength = 20;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(236, 19);
            this.nombre.TabIndex = 1;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Escribe una contraseña";
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.Color.White;
            this.contra.Location = new System.Drawing.Point(20, 191);
            this.contra.MaxLength = 40;
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(233, 19);
            this.contra.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vuelve a introducir la contraseña";
            // 
            // conf_contra
            // 
            this.conf_contra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.conf_contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conf_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf_contra.ForeColor = System.Drawing.Color.White;
            this.conf_contra.Location = new System.Drawing.Point(20, 246);
            this.conf_contra.MaxLength = 40;
            this.conf_contra.Name = "conf_contra";
            this.conf_contra.PasswordChar = '*';
            this.conf_contra.Size = new System.Drawing.Size(233, 19);
            this.conf_contra.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número de control actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(17, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "No más de 9 caracteres";
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.ForeColor = System.Drawing.Color.White;
            this.correo.Location = new System.Drawing.Point(20, 322);
            this.correo.MaxLength = 40;
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(233, 19);
            this.correo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vuelva a introducir el número de control";
            // 
            // conf_correo
            // 
            this.conf_correo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.conf_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conf_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf_correo.ForeColor = System.Drawing.Color.White;
            this.conf_correo.Location = new System.Drawing.Point(20, 382);
            this.conf_correo.MaxLength = 40;
            this.conf_correo.Name = "conf_correo";
            this.conf_correo.Size = new System.Drawing.Size(233, 19);
            this.conf_correo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(65, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "*Todos los campos son obligatorios";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.ForestGreen;
            this.ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.White;
            this.ingresar.Location = new System.Drawing.Point(110, 456);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(104, 42);
            this.ingresar.TabIndex = 6;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(335, 508);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.conf_correo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.conf_contra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox conf_contra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox conf_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ingresar;
    }
}