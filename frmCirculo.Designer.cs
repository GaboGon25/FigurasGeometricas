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
            txtRadioCirculo = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtAreaCirculo = new TextBox();
            txtPerimetroCirculo = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(43, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 0;
            label1.Text = "CIRCULO";
            // 
            // txtRadioCirculo
            // 
            txtRadioCirculo.Location = new Point(43, 145);
            txtRadioCirculo.Margin = new Padding(2, 1, 2, 1);
            txtRadioCirculo.Name = "txtRadioCirculo";
            txtRadioCirculo.Size = new Size(297, 23);
            txtRadioCirculo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "INTRODUZCA EL RADIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 28);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "AREA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "PERIMETRO";
            // 
            // txtAreaCirculo
            // 
            txtAreaCirculo.Location = new Point(43, 230);
            txtAreaCirculo.Margin = new Padding(2, 1, 2, 1);
            txtAreaCirculo.Name = "txtAreaCirculo";
            txtAreaCirculo.Size = new Size(150, 23);
            txtAreaCirculo.TabIndex = 6;
            // 
            // txtPerimetroCirculo
            // 
            txtPerimetroCirculo.Location = new Point(263, 230);
            txtPerimetroCirculo.Margin = new Padding(2, 1, 2, 1);
            txtPerimetroCirculo.Name = "txtPerimetroCirculo";
            txtPerimetroCirculo.Size = new Size(150, 23);
            txtPerimetroCirculo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(51, 298);
            btnCalcular.Margin = new Padding(2, 1, 2, 1);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 32);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(250, 298);
            btnNuevo.Margin = new Padding(2, 1, 2, 1);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 32);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmCirculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtPerimetroCirculo);
            Controls.Add(txtAreaCirculo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtRadioCirculo);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmCirculo";
            Text = "frmCirculo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadioCirculo;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox txtAreaCirculo;
        private TextBox txtPerimetroCirculo;
        private Button btnCalcular;
        private Button btnNuevo;
    }
}