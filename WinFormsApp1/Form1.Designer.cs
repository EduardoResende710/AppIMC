namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Alt = new Label();
            Pes = new Label();
            lblresultado = new Label();
            lblClassif = new Label();
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            M = new Label();
            Kg = new Label();
            Calcular = new Button();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            SuspendLayout();
            // 
            // Alt
            // 
            Alt.AutoSize = true;
            Alt.Font = new Font("Segoe UI", 18F);
            Alt.Location = new Point(77, 86);
            Alt.Name = "Alt";
            Alt.Size = new Size(77, 32);
            Alt.TabIndex = 0;
            Alt.Text = "Altura";
            // 
            // Pes
            // 
            Pes.AutoSize = true;
            Pes.Font = new Font("Segoe UI", 18F);
            Pes.Location = new Point(77, 143);
            Pes.Name = "Pes";
            Pes.Size = new Size(63, 32);
            Pes.TabIndex = 1;
            Pes.Text = "Peso";
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Font = new Font("Segoe UI", 18F);
            lblresultado.Location = new Point(0, 298);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(475, 32);
            lblresultado.TabIndex = 2;
            lblresultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClassif
            // 
            lblClassif.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblClassif.Font = new Font("Segoe UI", 18F);
            lblClassif.Location = new Point(0, 373);
            lblClassif.Name = "lblClassif";
            lblClassif.Size = new Size(475, 32);
            lblClassif.TabIndex = 3;
            lblClassif.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numAltura
            // 
            numAltura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numAltura.DecimalPlaces = 2;
            numAltura.Font = new Font("Segoe UI", 18F);
            numAltura.Location = new Point(174, 84);
            numAltura.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(182, 39);
            numAltura.TabIndex = 4;
            numAltura.ValueChanged += numAltura_ValueChanged;
            // 
            // numPeso
            // 
            numPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numPeso.DecimalPlaces = 2;
            numPeso.Font = new Font("Segoe UI", 18F);
            numPeso.Location = new Point(174, 143);
            numPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(182, 39);
            numPeso.TabIndex = 5;
            // 
            // M
            // 
            M.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            M.AutoSize = true;
            M.Font = new Font("Segoe UI", 18F);
            M.Location = new Point(399, 91);
            M.Name = "M";
            M.Size = new Size(36, 32);
            M.TabIndex = 6;
            M.Text = "M";
            // 
            // Kg
            // 
            Kg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Kg.AutoSize = true;
            Kg.Font = new Font("Segoe UI", 18F);
            Kg.Location = new Point(399, 151);
            Kg.Name = "Kg";
            Kg.Size = new Size(42, 32);
            Kg.TabIndex = 7;
            Kg.Text = "Kg";
            // 
            // Calcular
            // 
            Calcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Calcular.BackColor = Color.IndianRed;
            Calcular.Enabled = false;
            Calcular.Font = new Font("Segoe UI", 18F);
            Calcular.Location = new Point(127, 213);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(267, 41);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(Calcular);
            Controls.Add(Kg);
            Controls.Add(M);
            Controls.Add(numPeso);
            Controls.Add(numAltura);
            Controls.Add(lblClassif);
            Controls.Add(lblresultado);
            Controls.Add(Pes);
            Controls.Add(Alt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Alt;
        private Label Pes;
        private Label lblresultado;
        private Label lblClassif;
        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
        private Label M;
        private Label Kg;
        private Button Calcular;
    }
}
