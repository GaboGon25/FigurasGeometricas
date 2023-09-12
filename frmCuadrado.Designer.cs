namespace FigurasGeometricas
{
    partial class frmCuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadrado));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(117, 76);
            label1.Name = "label1";
            label1.Size = new Size(276, 59);
            label1.TabIndex = 0;
            label1.Text = "CUADRADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 193);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "INTRODUZCA UN LADO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 39);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(704, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 387);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "AREA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 387);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 5;
            label4.Text = "PERIMETRO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 469);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(427, 469);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(74, 559);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(254, 80);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(407, 559);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(254, 80);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(740, 559);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(254, 80);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmCuadrado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 709);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCuadrado";
            Text = "frmCuadrado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
    }
}