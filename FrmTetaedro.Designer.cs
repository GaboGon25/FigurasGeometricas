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
            txtLadoTetraedro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtVolumenTetraedro = new TextBox();
            txtAreaTetraedro = new TextBox();
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
            label2.Location = new Point(37, 92);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Introduzca el lado";
            // 
            // txtLadoTetraedro
            // 
            txtLadoTetraedro.Location = new Point(37, 132);
            txtLadoTetraedro.Name = "txtLadoTetraedro";
            txtLadoTetraedro.Size = new Size(151, 23);
            txtLadoTetraedro.TabIndex = 2;
            txtLadoTetraedro.TextChanged += textBox1_TextChanged;
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
            label4.Location = new Point(291, 231);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "VOLUMEN";
            // 
            // txtVolumenTetraedro
            // 
            txtVolumenTetraedro.Location = new Point(291, 269);
            txtVolumenTetraedro.Name = "txtVolumenTetraedro";
            txtVolumenTetraedro.Size = new Size(107, 23);
            txtVolumenTetraedro.TabIndex = 5;
            // 
            // txtAreaTetraedro
            // 
            txtAreaTetraedro.Location = new Point(37, 269);
            txtAreaTetraedro.Name = "txtAreaTetraedro";
            txtAreaTetraedro.Size = new Size(112, 23);
            txtAreaTetraedro.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 376);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 42);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(229, 376);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 42);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(434, 376);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(130, 42);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmTetaedro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtAreaTetraedro);
            Controls.Add(txtVolumenTetraedro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLadoTetraedro);
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
        private TextBox txtLadoTetraedro;
        private Label label3;
        private Label label4;
        private TextBox txtVolumenTetraedro;
        private TextBox txtAreaTetraedro;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnRegresar;
        private PictureBox pictureBox1;
    }
}