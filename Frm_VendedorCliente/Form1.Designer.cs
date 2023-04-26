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
            CARNICERIA = new Label();
            botonVendedor = new Button();
            botonCliente = new Button();
            SuspendLayout();
            // 
            // CARNICERIA
            // 
            CARNICERIA.AutoSize = true;
            CARNICERIA.BorderStyle = BorderStyle.FixedSingle;
            CARNICERIA.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            CARNICERIA.Location = new Point(153, 48);
            CARNICERIA.Name = "CARNICERIA";
            CARNICERIA.Size = new Size(222, 46);
            CARNICERIA.TabIndex = 0;
            CARNICERIA.Text = "CARNICERIA";
            // 
            // botonVendedor
            // 
            botonVendedor.BackColor = SystemColors.MenuHighlight;
            botonVendedor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonVendedor.Location = new Point(166, 147);
            botonVendedor.Name = "botonVendedor";
            botonVendedor.Size = new Size(200, 68);
            botonVendedor.TabIndex = 1;
            botonVendedor.Text = "VENDEDOR";
            botonVendedor.UseVisualStyleBackColor = false;
            botonVendedor.Click += botonVendedor_Click;
            // 
            // botonCliente
            // 
            botonCliente.BackColor = SystemColors.MenuHighlight;
            botonCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonCliente.Location = new Point(166, 276);
            botonCliente.Name = "botonCliente";
            botonCliente.Size = new Size(200, 66);
            botonCliente.TabIndex = 2;
            botonCliente.Text = "CLIENTE";
            botonCliente.UseVisualStyleBackColor = false;
            botonCliente.Click += botonCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(547, 431);
            Controls.Add(botonCliente);
            Controls.Add(botonVendedor);
            Controls.Add(CARNICERIA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CARNICERIA;
        private Button botonVendedor;
        private Button botonCliente;
    }
}