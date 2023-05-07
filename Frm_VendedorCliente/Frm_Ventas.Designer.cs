namespace Frm_VendedorCliente
{
    partial class Frm_Ventas
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
            RadioButton rbBuscar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            txtMonto = new TextBox();
            cbMetodoPago = new ComboBox();
            lblPago = new Label();
            btnComprar = new Button();
            btnVolver = new Button();
            lblNombre = new Label();
            label3 = new Label();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dgv = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            stockProducto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoDeCorte = new DataGridViewTextBoxColumn();
            cantidadComprada = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            rbBuscar = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // rbBuscar
            // 
            rbBuscar.AutoSize = true;
            rbBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbBuscar.Location = new Point(334, 68);
            rbBuscar.Name = "rbBuscar";
            rbBuscar.Size = new Size(145, 22);
            rbBuscar.TabIndex = 9;
            rbBuscar.TabStop = true;
            rbBuscar.Text = "Buscar por corte:";
            rbBuscar.UseVisualStyleBackColor = true;
            rbBuscar.CheckedChanged += rbBuscar_CheckedChanged;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = SystemColors.ActiveCaptionText;
            txtMonto.Location = new Point(205, 70);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(98, 25);
            txtMonto.TabIndex = 0;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo ", "Tarjeta de crédito", "Tarjeta de débito", "Mercado Pago" });
            cbMetodoPago.Location = new Point(243, 413);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 24);
            cbMetodoPago.TabIndex = 1;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(12, 413);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(225, 18);
            lblPago.TabIndex = 2;
            lblPago.Text = "Seleccione el metodo de pago:";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.MediumBlue;
            btnComprar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = SystemColors.ControlLightLight;
            btnComprar.Location = new Point(401, 409);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(111, 37);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MediumBlue;
            btnVolver.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(547, 9);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 27);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Wheat;
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(374, 37);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Productos disponibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(187, 18);
            label3.TabIndex = 7;
            label3.Text = "Ingrese el monto a gastar:";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "nombre";
            Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "stock";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, stockProducto, precio, detalle, tipoDeCorte, cantidadComprada });
            dgv.Location = new Point(12, 98);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(635, 305);
            dgv.TabIndex = 8;
            dgv.CellClick += dgv_CellClick;
            dgv.CellEndEdit += dgv_CellEndEdit;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre";
            nombreProducto.Name = "nombreProducto";
            // 
            // stockProducto
            // 
            stockProducto.HeaderText = "Stock";
            stockProducto.Name = "stockProducto";
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
            // tipoDeCorte
            // 
            tipoDeCorte.HeaderText = "Tipo de corte";
            tipoDeCorte.Name = "tipoDeCorte";
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Cantidad a comprar";
            cantidadComprada.Name = "cantidadComprada";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(485, 68);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(162, 22);
            txtBuscar.TabIndex = 10;
            // 
            // Frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(657, 450);
            Controls.Add(txtBuscar);
            Controls.Add(rbBuscar);
            Controls.Add(dgv);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Controls.Add(btnComprar);
            Controls.Add(lblPago);
            Controls.Add(cbMetodoPago);
            Controls.Add(txtMonto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Ventas";
            Text = "Productos en stock";
            Load += Frm_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private ComboBox cbMetodoPago;
        private Label lblPago;
        private Button btnComprar;
        private Button btnVolver;
        private Label lblNombre;
        private Label label3;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dgv;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn stockProducto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoDeCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
    }
}