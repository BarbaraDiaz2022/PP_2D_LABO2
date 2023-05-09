﻿namespace Frm_VendedorCliente
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
            cbBuscarCorte = new ComboBox();
            btnBuscar = new Button();
            lblCliente = new Label();
            txtNombreCliente = new TextBox();
            nombreProducto = new DataGridViewTextBoxColumn();
            stockProducto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoDeCorte = new DataGridViewTextBoxColumn();
            cantidadComprada = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = SystemColors.ActiveCaptionText;
            txtMonto.Location = new Point(205, 95);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(98, 25);
            txtMonto.TabIndex = 0;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo ", "Tarjeta de crédito", "Tarjeta de débito", "Mercado Pago" });
            cbMetodoPago.Location = new Point(243, 423);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 24);
            cbMetodoPago.TabIndex = 1;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(12, 423);
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
            btnComprar.Location = new Point(534, 415);
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
            btnVolver.Location = new Point(545, 9);
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
            label3.Location = new Point(12, 97);
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
            dgv.Location = new Point(12, 128);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(633, 275);
            dgv.TabIndex = 8;
            dgv.CellClick += dgv_CellClick;
            dgv.CellEndEdit += dgv_CellEndEdit;
            // 
            // cbBuscarCorte
            // 
            cbBuscarCorte.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbBuscarCorte.ForeColor = SystemColors.MenuText;
            cbBuscarCorte.FormattingEnabled = true;
            cbBuscarCorte.Items.AddRange(new object[] { "Mostrar todos los cortes", "Peceto", "Pechuga", "Bondiola", "Bola de lomo" });
            cbBuscarCorte.Location = new Point(387, 99);
            cbBuscarCorte.Name = "cbBuscarCorte";
            cbBuscarCorte.Size = new Size(163, 26);
            cbBuscarCorte.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumBlue;
            btnBuscar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(387, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 26);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(12, 66);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(140, 18);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Ingrese su nombre:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreCliente.Location = new Point(203, 61);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 26);
            txtNombreCliente.TabIndex = 12;
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
            stockProducto.Width = 45;
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            precio.Width = 80;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.Width = 195;
            // 
            // tipoDeCorte
            // 
            tipoDeCorte.HeaderText = "Tipo de corte";
            tipoDeCorte.Name = "tipoDeCorte";
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Cant. a comprar";
            cantidadComprada.Name = "cantidadComprada";
            cantidadComprada.Width = 70;
            // 
            // Frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(648, 457);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnBuscar);
            Controls.Add(cbBuscarCorte);
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
        private ComboBox cbBuscarCorte;
        private Button btnBuscar;
        private Label lblCliente;
        private TextBox txtNombreCliente;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn stockProducto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoDeCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
    }
}