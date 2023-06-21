namespace Frm_VendedorCliente
{
    partial class Frm_RealizarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RealizarVenta));
            dgv = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoCorte = new DataGridViewTextBoxColumn();
            cantidadComprada = new DataGridViewTextBoxColumn();
            cbClientes = new ComboBox();
            lblSeleccion = new Label();
            btnVender = new Button();
            btnVolver = new Button();
            lblTitulo = new Label();
            lblInfoMonto = new Label();
            txtInfoMonto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, stock, precio, detalle, tipoCorte, cantidadComprada });
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(7, 34);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(643, 369);
            dgv.TabIndex = 1;
            dgv.CellBeginEdit += dgv_CellBeginEdit;
            dgv.CellClick += dgv_CellClick;
            dgv.CellEndEdit += dgv_CellEndEdit;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.Width = 70;
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            precio.Width = 70;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.Width = 220;
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            tipoCorte.Width = 80;
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Cant. a vender";
            cantidadComprada.Name = "cantidadComprada";
            cantidadComprada.Width = 60;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(212, 412);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(147, 23);
            cbClientes.TabIndex = 18;
            cbClientes.DropDownStyleChanged += btnVender_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccion.Location = new Point(7, 417);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(203, 18);
            lblSeleccion.TabIndex = 19;
            lblSeleccion.Text = "Seleccione cliente a vender:";
            // 
            // btnVender
            // 
            btnVender.BackColor = SystemColors.MenuHighlight;
            btnVender.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.Location = new Point(524, 409);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(126, 28);
            btnVender.TabIndex = 20;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(524, 443);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(126, 28);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(29, -6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(582, 37);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Productos disponibles para vender";
            // 
            // lblInfoMonto
            // 
            lblInfoMonto.AutoSize = true;
            lblInfoMonto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoMonto.Location = new Point(7, 453);
            lblInfoMonto.Name = "lblInfoMonto";
            lblInfoMonto.Size = new Size(174, 18);
            lblInfoMonto.TabIndex = 23;
            lblInfoMonto.Text = "Monto actual del cliente:";
            // 
            // txtInfoMonto
            // 
            txtInfoMonto.Location = new Point(212, 453);
            txtInfoMonto.Name = "txtInfoMonto";
            txtInfoMonto.ReadOnly = true;
            txtInfoMonto.Size = new Size(147, 23);
            txtInfoMonto.TabIndex = 24;
            // 
            // Frm_RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(658, 480);
            Controls.Add(txtInfoMonto);
            Controls.Add(lblInfoMonto);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(btnVender);
            Controls.Add(lblSeleccion);
            Controls.Add(cbClientes);
            Controls.Add(dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_RealizarVenta";
            Text = "Vender";
            Load += Frm_RealizarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private ComboBox cbClientes;
        private Label lblSeleccion;
        private Button btnVender;
        private Button btnVolver;
        private Label lblTitulo;
        private Label lblInfoMonto;
        private TextBox txtInfoMonto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
    }
}