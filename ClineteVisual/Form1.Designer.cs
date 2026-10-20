namespace ClineteVisual
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
            btnEjecutar = new Button();
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(191, 319);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(145, 234);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(164, 23);
            txtNumero2.TabIndex = 1;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(145, 179);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(164, 23);
            txtNumero1.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 281);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 371);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(btnEjecutar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Label lblResultado;
    }
}
