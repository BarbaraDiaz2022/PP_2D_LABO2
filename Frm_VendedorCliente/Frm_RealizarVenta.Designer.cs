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
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, stock, precio, detalle, tipoCorte, cantidadComprada });
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(7, 34);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(643, 360);
            dgv.TabIndex = 1;
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
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Cantidad a vender";
            cantidadComprada.Name = "cantidadComprada";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(12, 418);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(147, 23);
            cbClientes.TabIndex = 18;
            cbClientes.DropDownStyleChanged += btnVender_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccion.Location = new Point(12, 397);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(199, 18);
            lblSeleccion.TabIndex = 19;
            lblSeleccion.Text = "Seleccione cliente a vender";
            // 
            // btnVender
            // 
            btnVender.BackColor = SystemColors.MenuHighlight;
            btnVender.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.Location = new Point(12, 447);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(121, 31);
            btnVender.TabIndex = 20;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(541, 422);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(109, 46);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(36, -6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(582, 37);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Productos disponibles para vender";
            // 
            // Frm_RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(662, 480);
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
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
        private ComboBox cbClientes;
        private Label lblSeleccion;
        private Button btnVender;
        private Button btnVolver;
        private Label lblTitulo;
    }
}