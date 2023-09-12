namespace FigurasGeometricas
{
    partial class frmFiguras
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
            btnFB = new Button();
            btnFT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(397, 111);
            label1.Name = "label1";
            label1.Size = new Size(451, 45);
            label1.TabIndex = 0;
            label1.Text = "ESCOJA EL TIPO DE FIGURA";
            // 
            // btnFB
            // 
            btnFB.Location = new Point(162, 241);
            btnFB.Name = "btnFB";
            btnFB.Size = new Size(376, 182);
            btnFB.TabIndex = 1;
            btnFB.Text = "FIGURAS BIDIMENSIONALES";
            btnFB.UseVisualStyleBackColor = true;
            btnFB.Click += btnFB_Click;
            // 
            // btnFT
            // 
            btnFT.Location = new Point(714, 241);
            btnFT.Name = "btnFT";
            btnFT.Size = new Size(376, 182);
            btnFT.TabIndex = 2;
            btnFT.Text = "FIGURAS TRIDIMENSIONALES";
            btnFT.UseVisualStyleBackColor = true;
            btnFT.Click += btnFT_Click;
            // 
            // frmFiguras
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 576);
            Controls.Add(btnFT);
            Controls.Add(btnFB);
            Controls.Add(label1);
            Name = "frmFiguras";
            Text = "frmFiguras";
            Load += frmFiguras_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFB;
        private Button btnFT;
    }
}