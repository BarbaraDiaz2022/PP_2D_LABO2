namespace Frm_VendedorCliente
{
    partial class Frm_LoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginCliente));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnIngresar = new Button();
            lblNombre = new Label();
            btnRetornar = new Button();
            rbAutocompletar = new RadioButton();
            pbLogIn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogIn).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(42, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ingrese mail";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(42, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Ingrese contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.MediumBlue;
            btnIngresar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(204, 273);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 33);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Snap ITC", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblNombre.Location = new Point(79, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(172, 48);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Cliente";
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.MediumBlue;
            btnRetornar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetornar.ForeColor = SystemColors.ControlLightLight;
            btnRetornar.Location = new Point(12, 273);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(90, 33);
            btnRetornar.TabIndex = 5;
            btnRetornar.Text = "Volver";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // rbAutocompletar
            // 
            rbAutocompletar.AutoSize = true;
            rbAutocompletar.BackColor = Color.White;
            rbAutocompletar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbAutocompletar.Location = new Point(59, 210);
            rbAutocompletar.Name = "rbAutocompletar";
            rbAutocompletar.Size = new Size(201, 23);
            rbAutocompletar.TabIndex = 6;
            rbAutocompletar.TabStop = true;
            rbAutocompletar.Text = "Autocompletar usuario";
            rbAutocompletar.UseVisualStyleBackColor = false;
            rbAutocompletar.CheckedChanged += rbAutocompletar_CheckedChanged;
            // 
            // pbLogIn
            // 
            pbLogIn.BackColor = Color.Transparent;
            pbLogIn.Image = (Image)resources.GetObject("pbLogIn.Image");
            pbLogIn.Location = new Point(3, 0);
            pbLogIn.Name = "pbLogIn";
            pbLogIn.Size = new Size(75, 69);
            pbLogIn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogIn.TabIndex = 7;
            pbLogIn.TabStop = false;
            // 
            // Frm_LoginCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(306, 318);
            Controls.Add(pbLogIn);
            Controls.Add(rbAutocompletar);
            Controls.Add(btnRetornar);
            Controls.Add(lblNombre);
            Controls.Add(btnIngresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_LoginCliente";
            Text = "Inicio sesión";
            ((System.ComponentModel.ISupportInitialize)pbLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnIngresar;
        private Label lblNombre;
        private Button btnRetornar;
        private RadioButton rbAutocompletar;
        private PictureBox pbLogIn;
    }
}