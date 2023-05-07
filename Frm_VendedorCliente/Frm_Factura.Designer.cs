namespace Frm_VendedorCliente
{
    partial class Frm_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Factura));
            dgv = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewTextBoxColumn();
            tipoDeCorte = new DataGridViewTextBoxColumn();
            cantidadComprada = new DataGridViewTextBoxColumn();
            lblNombre = new Label();
            lblTotal = new Label();
            lblInformacion = new Label();
            btnVolver = new Button();
            lblInfoPago = new Label();
            lblPago = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = SystemColors.ControlLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, detalle, tipoDeCorte, cantidadComprada });
            dgv.Location = new Point(11, 59);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(543, 348);
            dgv.TabIndex = 9;
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
            cantidadComprada.HeaderText = "Cantidad comprada";
            cantidadComprada.Name = "cantidadComprada";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.MediumBlue;
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Font = new Font("Snap ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(177, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(221, 47);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "FACTURA";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(150, 409);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 24);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Monto";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblInformacion.Location = new Point(11, 415);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(132, 18);
            lblInformacion.TabIndex = 12;
            lblInformacion.Text = "TOTAL A PAGAR:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MediumBlue;
            btnVolver.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(480, 426);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(74, 31);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblInfoPago
            // 
            lblInfoPago.AutoSize = true;
            lblInfoPago.BorderStyle = BorderStyle.FixedSingle;
            lblInfoPago.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoPago.Location = new Point(150, 433);
            lblInfoPago.Name = "lblInfoPago";
            lblInfoPago.Size = new Size(135, 24);
            lblInfoPago.TabIndex = 14;
            lblInfoPago.Text = "Modo de pago";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Arial", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblPago.Location = new Point(12, 433);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(130, 18);
            lblPago.TabIndex = 15;
            lblPago.Text = "Usted pagó con  :";
            // 
            // Frm_Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(566, 460);
            Controls.Add(lblPago);
            Controls.Add(lblInfoPago);
            Controls.Add(btnVolver);
            Controls.Add(lblInformacion);
            Controls.Add(lblTotal);
            Controls.Add(lblNombre);
            Controls.Add(dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Factura";
            Text = "Factura de compra";
            Load += Frm_Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lblNombre;
        private Label lblTotal;
        private Label lblInformacion;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn tipoDeCorte;
        private DataGridViewTextBoxColumn cantidadComprada;
        private Button btnVolver;
        private Label lblInfoPago;
        private Label lblPago;
    }
}