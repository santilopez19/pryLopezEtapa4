namespace pryLopezEtapa4
{
    partial class frmVehiculos
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
            pctImagen = new PictureBox();
            btnBarco = new Button();
            btnAvion = new Button();
            btnAuto = new Button();
            ((System.ComponentModel.ISupportInitialize)pctImagen).BeginInit();
            SuspendLayout();
            // 
            // pctImagen
            // 
            pctImagen.Image = Properties.Resources.auto;
            pctImagen.Location = new Point(243, 63);
            pctImagen.Name = "pctImagen";
            pctImagen.Size = new Size(520, 323);
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pctImagen.TabIndex = 7;
            pctImagen.TabStop = false;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(728, 411);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(94, 29);
            btnBarco.TabIndex = 6;
            btnBarco.Text = "Barco";
            btnBarco.UseVisualStyleBackColor = true;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(437, 411);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(94, 29);
            btnAvion.TabIndex = 5;
            btnAvion.Text = "Avion";
            btnAvion.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(197, 411);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(94, 29);
            btnAuto.TabIndex = 4;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 502);
            Controls.Add(pctImagen);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(btnAuto);
            Name = "frmVehiculos";
            Text = "Vehiculos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctImagen;
        private Button btnBarco;
        private Button btnAvion;
        private Button btnAuto;
    }
}
