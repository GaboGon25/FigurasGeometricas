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
            btnTetraedro.Location = new Point(932, 262);
            btnTetraedro.Name = "btnTetraedro";
            btnTetraedro.Size = new Size(324, 152);
            btnTetraedro.TabIndex = 7;
            btnTetraedro.Text = "TETRAEDRO";
            btnTetraedro.UseVisualStyleBackColor = true;
            // 
            // btnCubo
            // 
            btnCubo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCubo.Location = new Point(488, 262);
            btnCubo.Name = "btnCubo";
            btnCubo.Size = new Size(324, 152);
            btnCubo.TabIndex = 6;
            btnCubo.Text = "CUBO";
            btnCubo.UseVisualStyleBackColor = true;
            // 
            // btnEsfera
            // 
            btnEsfera.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsfera.Location = new Point(70, 262);
            btnEsfera.Name = "btnEsfera";
            btnEsfera.Size = new Size(324, 152);
            btnEsfera.TabIndex = 5;
            btnEsfera.Text = "ESFERA";
            btnEsfera.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(386, 139);
            label1.Name = "label1";
            label1.Size = new Size(566, 50);
            label1.TabIndex = 4;
            label1.Text = "FIGURAS TRIDIMENSIONALES";
            // 
            // frmFigurasTridimensionales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 592);
            Controls.Add(btnTetraedro);
            Controls.Add(btnCubo);
            Controls.Add(btnEsfera);
            Controls.Add(label1);
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