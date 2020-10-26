namespace Proyecto_cliente
{
    partial class Form1
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
            this.Juego = new System.Windows.Forms.GroupBox();
            this.Registro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MasLarga = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.Juego.SuspendLayout();
            this.SuspendLayout();
            // 
            // Juego
            // 
            this.Juego.BackColor = System.Drawing.Color.DarkCyan;
            this.Juego.Controls.Add(this.Registro);
            this.Juego.Controls.Add(this.label3);
            this.Juego.Controls.Add(this.label2);
            this.Juego.Controls.Add(this.Password);
            this.Juego.Controls.Add(this.Username);
            this.Juego.Controls.Add(this.IniciarSesion);
            this.Juego.Controls.Add(this.label1);
            this.Juego.Controls.Add(this.textBox1);
            this.Juego.Controls.Add(this.MasLarga);
            this.Juego.Controls.Add(this.radioButton2);
            this.Juego.Controls.Add(this.radioButton1);
            this.Juego.Controls.Add(this.Desconectar);
            this.Juego.Controls.Add(this.Aceptar);
            this.Juego.Controls.Add(this.Conectar);
            this.Juego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Juego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Juego.Location = new System.Drawing.Point(55, 29);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(767, 462);
            this.Juego.TabIndex = 1;
            this.Juego.TabStop = false;
            this.Juego.Text = "Juego";
            // 
            // Registro
            // 
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registro.Location = new System.Drawing.Point(18, 295);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(127, 39);
            this.Registro.TabIndex = 13;
            this.Registro.Text = "Registrarse";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(20, 202);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(125, 26);
            this.Password.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(22, 133);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(125, 26);
            this.Username.TabIndex = 9;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IniciarSesion.Location = new System.Drawing.Point(18, 250);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(127, 39);
            this.IniciarSesion.TabIndex = 8;
            this.IniciarSesion.Text = "Iniciar sesión";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 6;
            // 
            // MasLarga
            // 
            this.MasLarga.AutoSize = true;
            this.MasLarga.Location = new System.Drawing.Point(357, 149);
            this.MasLarga.Name = "MasLarga";
            this.MasLarga.Size = new System.Drawing.Size(338, 24);
            this.MasLarga.TabIndex = 5;
            this.MasLarga.TabStop = true;
            this.MasLarga.Text = "Dame la duración de la partida más larga";
            this.MasLarga.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(357, 191);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(357, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(355, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dame el jugador con más partidas ganadas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Desconectar
            // 
            this.Desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Desconectar.Location = new System.Drawing.Point(579, 394);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(147, 46);
            this.Desconectar.TabIndex = 2;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Aceptar.Location = new System.Drawing.Point(357, 250);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(89, 39);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Conectar
            // 
            this.Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Conectar.Location = new System.Drawing.Point(20, 30);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(138, 43);
            this.Conectar.TabIndex = 1;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 520);
            this.Controls.Add(this.Juego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Juego.ResumeLayout(false);
            this.Juego.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Juego;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton MasLarga;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Registro;
    }
}

