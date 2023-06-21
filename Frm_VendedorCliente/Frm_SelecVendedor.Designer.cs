namespace Frm_VendedorCliente
{
    partial class Frm_SelecVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelecVendedor));
            btnHeladera = new Button();
            btnVender = new Button();
            btnHistorial = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnHeladera
            // 
            btnHeladera.BackColor = SystemColors.MenuHighlight;
            btnHeladera.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHeladera.Location = new Point(88, 123);
            btnHeladera.Name = "btnHeladera";
            btnHeladera.Size = new Size(147, 68);
            btnHeladera.TabIndex = 0;
            btnHeladera.Text = "Ver heladera";
            btnHeladera.UseVisualStyleBackColor = false;
            btnHeladera.Click += btnHeladera_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = SystemColors.MenuHighlight;
            btnVender.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.Location = new Point(88, 31);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(147, 68);
            btnVender.TabIndex = 1;
            btnVender.Text = "Vender productos";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = SystemColors.MenuHighlight;
            btnHistorial.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorial.Location = new Point(88, 223);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(147, 68);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Ver historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(182, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 31);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Frm_SelecVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(282, 362);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnHistorial);
            Controls.Add(btnVender);
            Controls.Add(btnHeladera);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_SelecVendedor";
            Text = "Seleccionar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHeladera;
        private Button btnVender;
        private Button btnHistorial;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}