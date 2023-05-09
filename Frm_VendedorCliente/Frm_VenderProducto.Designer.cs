namespace Frm_VendedorCliente
{
    partial class Frm_VenderProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_VenderProducto));
            lblVentas = new Label();
            dgv = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoCorte = new DataGridViewTextBoxColumn();
            cantidadComprada = new DataGridViewTextBoxColumn();
            lblInformacion = new Label();
            lblCliente = new Label();
            btnVolver = new Button();
            lblInfoPago = new Label();
            lblPago = new Label();
            lblInfoSub = new Label();
            lblSubtotal = new Label();
            lblInfoVend = new Label();
            lblVendedor = new Label();
            lblInfoCod = new Label();
            lblNombreVendedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BorderStyle = BorderStyle.FixedSingle;
            lblVentas.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentas.Location = new Point(143, 7);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(257, 37);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "Venta realizada";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, detalle, tipoCorte, cantidadComprada });
            dgv.Location = new Point(4, 47);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(549, 347);
            dgv.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            precio.Width = 60;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.Width = 161;
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            tipoCorte.Width = 110;
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Kilos vendidos";
            cantidadComprada.Name = "cantidadComprada";
            cantidadComprada.Width = 65;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblInformacion.Location = new Point(13, 476);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(173, 23);
            lblInformacion.TabIndex = 2;
            lblInformacion.Text = "Vendido al cliente:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = SystemColors.ControlText;
            lblCliente.Location = new Point(188, 479);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(59, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(464, 479);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 25);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblInfoPago
            // 
            lblInfoPago.AutoSize = true;
            lblInfoPago.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblInfoPago.Location = new Point(13, 448);
            lblInfoPago.Name = "lblInfoPago";
            lblInfoPago.Size = new Size(114, 18);
            lblInfoPago.TabIndex = 5;
            lblInfoPago.Text = "Monto vendido:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.BorderStyle = BorderStyle.FixedSingle;
            lblPago.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(84, 414);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(129, 20);
            lblPago.TabIndex = 6;
            lblPago.Text = "Subtotal a cobrar";
            // 
            // lblInfoSub
            // 
            lblInfoSub.AutoSize = true;
            lblInfoSub.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblInfoSub.Location = new Point(13, 414);
            lblInfoSub.Name = "lblInfoSub";
            lblInfoSub.Size = new Size(69, 18);
            lblInfoSub.TabIndex = 7;
            lblInfoSub.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(133, 448);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(104, 20);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "Total a cobrar";
            // 
            // lblInfoVend
            // 
            lblInfoVend.AutoSize = true;
            lblInfoVend.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblInfoVend.Location = new Point(276, 414);
            lblInfoVend.Name = "lblInfoVend";
            lblInfoVend.Size = new Size(97, 18);
            lblInfoVend.TabIndex = 9;
            lblInfoVend.Text = "Vendido por:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.BorderStyle = BorderStyle.FixedSingle;
            lblVendedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedor.Location = new Point(440, 439);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(75, 20);
            lblVendedor.TabIndex = 10;
            lblVendedor.Text = "vendedor";
            // 
            // lblInfoCod
            // 
            lblInfoCod.AutoSize = true;
            lblInfoCod.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblInfoCod.Location = new Point(276, 441);
            lblInfoCod.Name = "lblInfoCod";
            lblInfoCod.Size = new Size(158, 18);
            lblInfoCod.TabIndex = 11;
            lblInfoCod.Text = "Codigo del vendedor:";
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreVendedor.Location = new Point(379, 414);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(73, 18);
            lblNombreVendedor.TabIndex = 12;
            lblNombreVendedor.Text = "vendedor";
            // 
            // Frm_VenderProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(559, 507);
            Controls.Add(lblNombreVendedor);
            Controls.Add(lblInfoCod);
            Controls.Add(lblVendedor);
            Controls.Add(lblInfoVend);
            Controls.Add(lblSubtotal);
            Controls.Add(lblInfoSub);
            Controls.Add(lblPago);
            Controls.Add(lblInfoPago);
            Controls.Add(btnVolver);
            Controls.Add(lblCliente);
            Controls.Add(lblInformacion);
            Controls.Add(dgv);
            Controls.Add(lblVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_VenderProducto";
            Text = "Ventas Realizadas";
            Load += Frm_VenderProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVentas;
        private DataGridView dgv;
        private Label lblInformacion;
        private Label lblCliente;
        private Button btnVolver;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
        private Label lblInfoPago;
        private Label lblPago;
        private Label lblInfoSub;
        private Label lblSubtotal;
        private Label lblInfoVend;
        private Label lblVendedor;
        private Label lblInfoCod;
        private Label lblNombreVendedor;
    }
}