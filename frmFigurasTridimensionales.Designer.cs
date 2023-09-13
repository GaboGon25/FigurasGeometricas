namespace FigurasGeometricas
{
    partial class frmFigurasTridimensionales
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
            btnTetraedro = new Button();
            btnCubo = new Button();
            btnEsfera = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTetraedro
            // 
            btnTetraedro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTetraedro.Location = new Point(502, 123);
            btnTetraedro.Margin = new Padding(2, 1, 2, 1);
            btnTetraedro.Name = "btnTetraedro";
            btnTetraedro.Size = new Size(174, 71);
            btnTetraedro.TabIndex = 7;
            btnTetraedro.Text = "TETRAEDRO";
            btnTetraedro.UseVisualStyleBackColor = true;
            btnTetraedro.Click += btnTetraedro_Click;
            // 
            // btnCubo
            // 
            btnCubo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCubo.Location = new Point(263, 123);
            btnCubo.Margin = new Padding(2, 1, 2, 1);
            btnCubo.Name = "btnCubo";
            btnCubo.Size = new Size(174, 71);
            btnCubo.TabIndex = 6;
            btnCubo.Text = "CUBO";
            btnCubo.UseVisualStyleBackColor = true;
            btnCubo.Click += btnCubo_Click;
            // 
            // btnEsfera
            // 
            btnEsfera.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsfera.Location = new Point(38, 123);
            btnEsfera.Margin = new Padding(2, 1, 2, 1);
            btnEsfera.Name = "btnEsfera";
            btnEsfera.Size = new Size(174, 71);
            btnEsfera.TabIndex = 5;
            btnEsfera.Text = "ESFERA";
            btnEsfera.UseVisualStyleBackColor = true;
            btnEsfera.Click += btnEsfera_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(208, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 4;
            label1.Text = "FIGURAS TRIDIMENSIONALES";
            // 
            // frmFigurasTridimensionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 278);
            Controls.Add(btnTetraedro);
            Controls.Add(btnCubo);
            Controls.Add(btnEsfera);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmFigurasTridimensionales";
            Text = "frmFigurasTridimensionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTetraedro;
        private Button btnCubo;
        private Button btnEsfera;
        private Label label1;
    }
}