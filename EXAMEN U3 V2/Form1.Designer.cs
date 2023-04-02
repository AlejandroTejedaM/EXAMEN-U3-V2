namespace EXAMEN_U3_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresarVehiculoNuevo = new Button();
            txtCola = new TextBox();
            txtProceso = new TextBox();
            txtTerminados = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            pbPintura = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pbEnsambladora = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            pbVerificacion = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbPintura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnsambladora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVerificacion).BeginInit();
            SuspendLayout();
            // 
            // btnIngresarVehiculoNuevo
            // 
            btnIngresarVehiculoNuevo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarVehiculoNuevo.Location = new Point(991, 14);
            btnIngresarVehiculoNuevo.Name = "btnIngresarVehiculoNuevo";
            btnIngresarVehiculoNuevo.Size = new Size(273, 114);
            btnIngresarVehiculoNuevo.TabIndex = 0;
            btnIngresarVehiculoNuevo.Text = "Agregar vehiculo";
            btnIngresarVehiculoNuevo.UseVisualStyleBackColor = true;
            btnIngresarVehiculoNuevo.Click += btnIngresarVehiculoNuevo_Click_1;
            // 
            // txtCola
            // 
            txtCola.Location = new Point(1731, 14);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(125, 23);
            txtCola.TabIndex = 1;
            // 
            // txtProceso
            // 
            txtProceso.Location = new Point(1731, 53);
            txtProceso.Name = "txtProceso";
            txtProceso.Size = new Size(125, 23);
            txtProceso.TabIndex = 2;
            // 
            // txtTerminados
            // 
            txtTerminados.Location = new Point(1731, 93);
            txtTerminados.Name = "txtTerminados";
            txtTerminados.Size = new Size(125, 23);
            txtTerminados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1643, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Carros en cola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1623, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "Carros en proceso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1621, 96);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Carros terminados";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1562, 197);
            progressBar1.Maximum = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(224, 23);
            progressBar1.TabIndex = 7;
            // 
            // pbPintura
            // 
            pbPintura.BorderStyle = BorderStyle.Fixed3D;
            pbPintura.Image = Properties.Resources.pintura__2_;
            pbPintura.Location = new Point(1047, 236);
            pbPintura.Name = "pbPintura";
            pbPintura.Size = new Size(159, 155);
            pbPintura.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPintura.TabIndex = 9;
            pbPintura.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.puerta;
            pictureBox4.Location = new Point(1200, 299);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(110, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = Properties.Resources.puerta;
            pictureBox5.Location = new Point(940, 299);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(110, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.puerta;
            pictureBox1.Location = new Point(376, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = Properties.Resources.puerta;
            pictureBox6.Location = new Point(637, 299);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(110, 92);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pbEnsambladora
            // 
            pbEnsambladora.BorderStyle = BorderStyle.Fixed3D;
            pbEnsambladora.Image = Properties.Resources.ensamble__1_;
            pbEnsambladora.Location = new Point(481, 236);
            pbEnsambladora.Name = "pbEnsambladora";
            pbEnsambladora.Size = new Size(159, 155);
            pbEnsambladora.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnsambladora.TabIndex = 13;
            pbEnsambladora.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.puerta;
            pictureBox3.Location = new Point(1496, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Image = Properties.Resources.camioncito__1_;
            pictureBox8.Location = new Point(1747, 299);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(124, 92);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pbVerificacion
            // 
            pbVerificacion.BorderStyle = BorderStyle.Fixed3D;
            pbVerificacion.Image = Properties.Resources.calidad;
            pbVerificacion.Location = new Point(1600, 236);
            pbVerificacion.Name = "pbVerificacion";
            pbVerificacion.Size = new Size(159, 155);
            pbVerificacion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVerificacion.TabIndex = 16;
            pbVerificacion.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(-35, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1906, 34);
            textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1870, 429);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox8);
            Controls.Add(pbVerificacion);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pbEnsambladora);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTerminados);
            Controls.Add(txtProceso);
            Controls.Add(txtCola);
            Controls.Add(btnIngresarVehiculoNuevo);
            Controls.Add(textBox1);
            Controls.Add(pbPintura);
            Name = "Form1";
            Text = "ENSAMBLADORA";
            FormClosing += Form1_FormClosing_1;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbPintura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnsambladora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVerificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresarVehiculoNuevo;
        private TextBox txtCola;
        private TextBox txtProceso;
        private TextBox txtTerminados;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private PictureBox pbPintura;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pbEnsambladora;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pbVerificacion;
        private TextBox textBox1;
    }
}