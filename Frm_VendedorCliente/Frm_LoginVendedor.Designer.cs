namespace Frm_VendedorCliente
{
    partial class Frm_LoginVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginVendedor));
            txtMail = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnRetornar = new Button();
            lblVendedor = new Label();
            rdbAcceder = new RadioButton();
            pbIconVendedor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbIconVendedor).BeginInit();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMail.ForeColor = SystemColors.WindowFrame;
            txtMail.Location = new Point(36, 114);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese mail";
            txtMail.Size = new Size(225, 23);
            txtMail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(36, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese contraseña";
            txtPassword.Size = new Size(225, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.MenuHighlight;
            btnIngresar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(198, 277);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(93, 32);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = SystemColors.MenuHighlight;
            btnRetornar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetornar.Location = new Point(12, 277);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(93, 32);
            btnRetornar.TabIndex = 5;
            btnRetornar.Text = "Volver";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Snap ITC", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblVendedor.Location = new Point(78, 9);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(208, 48);
            lblVendedor.TabIndex = 6;
            lblVendedor.Text = "Vendedor";
            // 
            // rdbAcceder
            // 
            rdbAcceder.AutoSize = true;
            rdbAcceder.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAcceder.Location = new Point(59, 205);
            rdbAcceder.Name = "rdbAcceder";
            rdbAcceder.Size = new Size(172, 21);
            rdbAcceder.TabIndex = 7;
            rdbAcceder.TabStop = true;
            rdbAcceder.Text = "Autocompletar usuario";
            rdbAcceder.UseVisualStyleBackColor = true;
            rdbAcceder.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // pbIconVendedor
            // 
            pbIconVendedor.Image = (Image)resources.GetObject("pbIconVendedor.Image");
            pbIconVendedor.Location = new Point(3, 9);
            pbIconVendedor.Name = "pbIconVendedor";
            pbIconVendedor.Size = new Size(69, 62);
            pbIconVendedor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIconVendedor.TabIndex = 8;
            pbIconVendedor.TabStop = false;
            // 
            // Frm_LoginVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(303, 321);
            Controls.Add(pbIconVendedor);
            Controls.Add(rdbAcceder);
            Controls.Add(lblVendedor);
            Controls.Add(btnRetornar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_LoginVendedor";
            Text = "Inicio sesión";
            ((System.ComponentModel.ISupportInitialize)pbIconVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnRetornar;
        private Label lblVendedor;
        private RadioButton rdbAcceder;
        private PictureBox pbIconVendedor;
    }
}