namespace FigurasGeometricas
{
    partial class FrmEsfera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsfera));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtRadioEsfera = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtVolumenEsfera = new TextBox();
            txtAreaEsfera = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 0;
            label1.Text = "ESFERA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(516, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 230);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 93);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Introduzca el Radio";
            // 
            // txtRadioEsfera
            // 
            txtRadioEsfera.Location = new Point(167, 138);
            txtRadioEsfera.Name = "txtRadioEsfera";
            txtRadioEsfera.Size = new Size(119, 23);
            txtRadioEsfera.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 6;
            label4.Text = "AREA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 220);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 7;
            label5.Text = "VOLUMEN";
            label5.Click += label5_Click;
            // 
            // txtVolumenEsfera
            // 
            txtVolumenEsfera.Location = new Point(306, 264);
            txtVolumenEsfera.Name = "txtVolumenEsfera";
            txtVolumenEsfera.Size = new Size(133, 23);
            txtVolumenEsfera.TabIndex = 8;
            // 
            // txtAreaEsfera
            // 
            txtAreaEsfera.Location = new Point(12, 264);
            txtAreaEsfera.Name = "txtAreaEsfera";
            txtAreaEsfera.Size = new Size(133, 23);
            txtAreaEsfera.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(17, 382);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.RightToLeft = RightToLeft.Yes;
            btnCalcular.Size = new Size(114, 37);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(313, 382);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(114, 37);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(609, 382);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(114, 37);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmEsfera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtAreaEsfera);
            Controls.Add(txtVolumenEsfera);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRadioEsfera);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FrmEsfera";
            Text = "FrmEsfera";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtRadioEsfera;
        private Label label4;
        private Label label5;
        private TextBox txtVolumenEsfera;
        private TextBox txtAreaEsfera;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
    }
}