namespace FigurasGeometricas
{
    partial class frmFigurasBidimensionales
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
            btnCirculo = new Button();
            btnCuadrado = new Button();
            btnTriangulo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(406, 107);
            label1.Name = "label1";
            label1.Size = new Size(543, 50);
            label1.TabIndex = 0;
            label1.Text = "FIGURAS BIDIMENSIONALES";
            // 
            // btnCirculo
            // 
            btnCirculo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCirculo.Location = new Point(90, 230);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(324, 152);
            btnCirculo.TabIndex = 1;
            btnCirculo.Text = "CIRCULO";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuadrado.Location = new Point(508, 230);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(324, 152);
            btnCuadrado.TabIndex = 2;
            btnCuadrado.Text = "CUADRADO";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // btnTriangulo
            // 
            btnTriangulo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTriangulo.Location = new Point(952, 230);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(324, 152);
            btnTriangulo.TabIndex = 3;
            btnTriangulo.Text = "TRIANGULO";
            btnTriangulo.UseVisualStyleBackColor = true;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // frmFigurasBidimensionales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 579);
            Controls.Add(btnTriangulo);
            Controls.Add(btnCuadrado);
            Controls.Add(btnCirculo);
            Controls.Add(label1);
            Name = "frmFigurasBidimensionales";
            Text = "frmFigurasBidimensionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCirculo;
        private Button btnCuadrado;
        private Button btnTriangulo;
    }
}