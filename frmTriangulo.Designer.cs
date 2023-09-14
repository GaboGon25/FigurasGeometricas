namespace FigurasGeometricas
{
    partial class frmTriangulo
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
            label1 = new Label();
            label2 = new Label();
            txtLadoTriangulo = new TextBox();
            txtAlturaTriangulo = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtAreaTriangulo = new TextBox();
            label4 = new Label();
            txtPerimetroTriangulo = new TextBox();
            label5 = new Label();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 23);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "TRIANGULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 107);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Introduzca el lado";
            // 
            // txtLadoTriangulo
            // 
            txtLadoTriangulo.Location = new Point(64, 151);
            txtLadoTriangulo.Name = "txtLadoTriangulo";
            txtLadoTriangulo.Size = new Size(141, 23);
            txtLadoTriangulo.TabIndex = 2;
            // 
            // txtAlturaTriangulo
            // 
            txtAlturaTriangulo.Location = new Point(283, 151);
            txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            txtAlturaTriangulo.Size = new Size(141, 23);
            txtAlturaTriangulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(283, 107);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 4;
            label3.Text = "Introduzca la altura";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.equilatero;
            pictureBox1.Location = new Point(491, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtAreaTriangulo
            // 
            txtAreaTriangulo.Location = new Point(58, 255);
            txtAreaTriangulo.Name = "txtAreaTriangulo";
            txtAreaTriangulo.Size = new Size(100, 23);
            txtAreaTriangulo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(64, 219);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "AREA";
            // 
            // txtPerimetroTriangulo
            // 
            txtPerimetroTriangulo.Location = new Point(242, 255);
            txtPerimetroTriangulo.Name = "txtPerimetroTriangulo";
            txtPerimetroTriangulo.Size = new Size(100, 23);
            txtPerimetroTriangulo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(242, 219);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "PERIMETRO";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(58, 319);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 31);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(216, 319);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 31);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(368, 319);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(97, 31);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 390);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(label5);
            Controls.Add(txtPerimetroTriangulo);
            Controls.Add(label4);
            Controls.Add(txtAreaTriangulo);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtAlturaTriangulo);
            Controls.Add(txtLadoTriangulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTriangulo";
            Text = "frmTriangulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLadoTriangulo;
        private TextBox txtAlturaTriangulo;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtAreaTriangulo;
        private Label label4;
        private TextBox txtPerimetroTriangulo;
        private Label label5;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
    }
}