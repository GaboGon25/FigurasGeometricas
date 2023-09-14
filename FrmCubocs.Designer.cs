namespace FigurasGeometricas
{
    partial class FrmCubocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCubocs));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtLadoCubo = new TextBox();
            label3 = new Label();
            txtAreaCubo = new TextBox();
            label4 = new Label();
            txtVolumenCubo = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "CUBO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 233);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 92);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 2;
            label2.Text = "Introduzca el lado";
            // 
            // txtLadoCubo
            // 
            txtLadoCubo.Location = new Point(135, 135);
            txtLadoCubo.Name = "txtLadoCubo";
            txtLadoCubo.Size = new Size(189, 23);
            txtLadoCubo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 225);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "AREA";
            // 
            // txtAreaCubo
            // 
            txtAreaCubo.Location = new Point(16, 262);
            txtAreaCubo.Name = "txtAreaCubo";
            txtAreaCubo.Size = new Size(100, 23);
            txtAreaCubo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(371, 215);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 6;
            label4.Text = "VOLUMEN";
            // 
            // txtVolumenCubo
            // 
            txtVolumenCubo.Location = new Point(371, 262);
            txtVolumenCubo.Name = "txtVolumenCubo";
            txtVolumenCubo.Size = new Size(115, 23);
            txtVolumenCubo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(16, 383);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 37);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(295, 383);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(115, 37);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(607, 383);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(115, 37);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmCubocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtVolumenCubo);
            Controls.Add(label4);
            Controls.Add(txtAreaCubo);
            Controls.Add(label3);
            Controls.Add(txtLadoCubo);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FrmCubocs";
            Text = "FrmCubocs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtLadoCubo;
        private Label label3;
        private TextBox txtAreaCubo;
        private Label label4;
        private TextBox txtVolumenCubo;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
    }
}