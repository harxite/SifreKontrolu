namespace Assignment_SifreKontrolu
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
            txtSifre = new TextBox();
            lblBaslik = new Label();
            lblDerece = new Label();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(128, 138);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(598, 27);
            txtSifre.TabIndex = 0;
            txtSifre.TextChanged += textBox1_TextChanged;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.Location = new Point(320, 61);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(226, 28);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "Şifre Kontrol Programı";
            // 
            // lblDerece
            // 
            lblDerece.AutoSize = true;
            lblDerece.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDerece.ForeColor = Color.Red;
            lblDerece.Location = new Point(128, 201);
            lblDerece.Name = "lblDerece";
            lblDerece.Size = new Size(60, 23);
            lblDerece.TabIndex = 2;
            lblDerece.Text = "Düşük";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 304);
            Controls.Add(lblDerece);
            Controls.Add(lblBaslik);
            Controls.Add(txtSifre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private Label lblBaslik;
        private Label lblDerece;
    }
}