namespace FigurasGeometricas
{
    partial class frmCirculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCirculo));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
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
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(235, 65);
            label1.TabIndex = 0;
            label1.Text = "CIRCULO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(549, 39);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 252);
            label2.Name = "label2";
            label2.Size = new Size(267, 32);
            label2.TabIndex = 2;
            label2.Text = "INTRODUZCA EL RADIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 419);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "AREA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 419);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 5;
            label4.Text = "PERIMETRO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 490);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(489, 490);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 39);
            textBox3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(95, 636);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(228, 69);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(465, 636);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(228, 69);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(821, 636);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(228, 69);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmCirculo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 854);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmCirculo";
            Text = "frmCirculo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
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