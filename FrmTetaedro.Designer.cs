namespace FigurasGeometricas
{
    partial class FrmTetaedro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTetaedro));
            label1 = new Label();
            label2 = new Label();
            txtLadoTetaedro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtVolumenTetaedro = new TextBox();
            txtAreaTetaedro = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "TETAEDRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 94);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Introduzca el lado";
            // 
            // txtLadoTetaedro
            // 
            txtLadoTetaedro.Location = new Point(118, 135);
            txtLadoTetaedro.Name = "txtLadoTetaedro";
            txtLadoTetaedro.Size = new Size(151, 23);
            txtLadoTetaedro.TabIndex = 2;
            txtLadoTetaedro.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "AREA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 231);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "VOLUMEN";
            // 
            // txtVolumenTetaedro
            // 
            txtVolumenTetaedro.Location = new Point(291, 269);
            txtVolumenTetaedro.Name = "txtVolumenTetaedro";
            txtVolumenTetaedro.Size = new Size(107, 23);
            txtVolumenTetaedro.TabIndex = 5;
            // 
            // txtAreaTetaedro
            // 
            txtAreaTetaedro.Location = new Point(25, 269);
            txtAreaTetaedro.Name = "txtAreaTetaedro";
            txtAreaTetaedro.Size = new Size(112, 23);
            txtAreaTetaedro.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(25, 376);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 42);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(277, 376);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 42);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(552, 376);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(130, 42);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmTetaedro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtAreaTetaedro);
            Controls.Add(txtVolumenTetaedro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLadoTetaedro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTetaedro";
            Text = "FrmTetaedro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLadoTetaedro;
        private Label label3;
        private Label label4;
        private TextBox txtVolumenTetaedro;
        private TextBox txtAreaTetaedro;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
        private PictureBox pictureBox1;
    }
}