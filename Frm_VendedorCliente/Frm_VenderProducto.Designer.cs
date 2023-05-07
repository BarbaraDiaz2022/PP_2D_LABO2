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
            lblInformacion = new Label();
            lblCliente = new Label();
            btnVolver = new Button();
            cantidadComprada = new DataGridViewTextBoxColumn();
            tipoCorte = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BorderStyle = BorderStyle.FixedSingle;
            lblVentas.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentas.Location = new Point(188, 9);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(291, 37);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "Ventas realizadas";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, stock, precio, detalle, tipoCorte, cantidadComprada });
            dgv.Location = new Point(13, 47);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(642, 336);
            dgv.TabIndex = 1;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblInformacion.Location = new Point(13, 421);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(173, 23);
            lblInformacion.TabIndex = 2;
            lblInformacion.Text = "Vendido al cliente:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = SystemColors.ControlText;
            lblCliente.Location = new Point(188, 424);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 19);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "cliente";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuHighlight;
            btnVolver.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(566, 421);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 25);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // cantidadComprada
            // 
            cantidadComprada.HeaderText = "Cantidad a comprar";
            cantidadComprada.Name = "cantidadComprada";
            // 
            // tipoCorte
            // 
            tipoCorte.HeaderText = "Tipo de corte";
            tipoCorte.Name = "tipoCorte";
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            // 
            // precio
            // 
            precio.HeaderText = "Precio x kilo";
            precio.Name = "precio";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // Frm_VenderProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(667, 450);
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
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
    }
}