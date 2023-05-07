namespace Frm_VendedorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVendedor = new Button();
            btnCliente = new Button();
            btnCerrar = new Button();
            pbMarca = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbMarca).BeginInit();
            SuspendLayout();
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = SystemColors.MenuHighlight;
            btnVendedor.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendedor.Location = new Point(329, 348);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(200, 68);
            btnVendedor.TabIndex = 1;
            btnVendedor.Text = "VENDEDOR";
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.MenuHighlight;
            btnCliente.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.Location = new Point(12, 350);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(200, 66);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "CLIENTE";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ActiveCaption;
            btnCerrar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(228, 442);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(83, 26);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pbMarca
            // 
            pbMarca.Image = (Image)resources.GetObject("pbMarca.Image");
            pbMarca.Location = new Point(12, 12);
            pbMarca.Name = "pbMarca";
            pbMarca.Size = new Size(517, 318);
            pbMarca.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMarca.TabIndex = 4;
            pbMarca.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(541, 480);
            Controls.Add(pbMarca);
            Controls.Add(btnCerrar);
            Controls.Add(btnCliente);
            Controls.Add(btnVendedor);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pbMarca).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnVendedor;
        private Button btnCliente;
        private Button btnCerrar;
        private PictureBox pbMarca;
    }
}